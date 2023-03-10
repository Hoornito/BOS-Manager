using Contratos.Controllers;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;
using System.Windows.Forms;

using UI.GrandChildForms;
using UI.Tools.FormComms;
using UI.Tools.LanguageManager;

namespace UI.ChildForms
{
    public partial class PedidosForm : Form, ICommPedidoCliente
    {
        IPedidoController _pedidoController;
        IDetalleController _detalleController;
        IProductoController _productoController;
        IClienteController _clienteController;
        public PedidosForm(IPedidoController pedidoController, IDetalleController detalleController, IProductoController productoController, IClienteController clienteController)
        {
            _detalleController = detalleController;
            _pedidoController = pedidoController;
            _productoController = productoController;
            _clienteController = clienteController;
            InitializeComponent();

            LlenarComboBoxClientes();
            TranducirForm.Current.TraducirFormulario(this);
        }

        #region métodos
        private void OnlyNumber(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void ActualizarDir()
        {
            var cliente = _clienteController.GetCliente(cbCliente.Text);
            txtDireccion.Text = cliente.Dirección;
        }
        private void CrearPedidoId()
        {
            var resultado = _pedidoController.ObtenerUltimoPedido();
            if (resultado == null)
                txtPedido.Text = 1.ToString();
            else
                txtPedido.Text = (resultado.Id_Pedido + 1).ToString();
        }
        private void LimpiarForm()
        {
            txtPedido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cbCliente.Text = string.Empty;
            cboTipoProducto.Text = string.Empty;
            txtDescripción.Text = string.Empty;
            dataGridView1.DataSource = null;
            txtCant.Text = "1";
            cbCliente.Enabled = false;
            cboTipoProducto.Enabled = false;
            btnFinalizar.Enabled = false;
            btnComenzar.Enabled = true;
            txtDescripción.Enabled = false;
            btnMenos.Enabled = true;
            btnMAS.Enabled = true;
            btnCancelar.Enabled = false;
            btnAgregar.Enabled = false;
        }
        private void LlenarGrilla()
        {
            PedidoEntity pedido = new PedidoEntity();
            pedido.Id_Pedido = Convert.ToInt32(txtPedido.Text);

            dataGridView1.AutoGenerateColumns = true;

            //UTILIZANDO LINQ
            var listaDetalle = _detalleController.ObtenerDetalle(pedido).Select
            (x => new
            {
                Tipo = x.Tipo,
                Nombre = x.Nombre,
                Precio = x.PrecioUnidad,
                Cantidad = x.Cantidad,
                SubTotal = x.SubTotal,
            });

            dataGridView1.DataSource = listaDetalle.ToList();
        }
        private void LlenarComboBoxProductos()
        {
            cboProducto.Items.Clear();
            if (cboTipoProducto.Text == "Empanadas")
            {
                var listaProductos = _productoController.GetAll().Where(x => x.Tipo == "Empanada");
                foreach (var item in listaProductos)
                {
                    cboProducto.Items.Add(item.Nombre);
                }
            }
            else
            {
                var listaProductos = _productoController.GetAll().Where(x => x.Tipo == "Pizza");
                foreach (var item in listaProductos)
                {
                    cboProducto.Items.Add(item.Nombre);
                }
            }
        }
        private string SeleccionarModoRetiro()
        {
            if (radioLocal.Checked)
            {
                return "Local";
            }
            else
            {
                return "Repartir";
            }
        }
        private void LlenarComboBoxClientes()
        {
            var listaProductos = _clienteController.GetAll();

            foreach (var item in listaProductos)
            {
                cbCliente.Items.Add(item.Teléfono);
            }
        }

        private void RegistroProducto()
        {
            try
            {
                ProductoAddForm registrarProducto = new ProductoAddForm(_productoController, cboProducto.Text, cboTipoProducto.Text);
                registrarProducto.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistroCliente()
        {
            try
            {
                ClientesAddForm registrarCliente = new ClientesAddForm(_clienteController, cbCliente.Text);
                registrarCliente.commPedido = this;
                registrarCliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefeshDir(ClienteEntity cliente)
        {
            txtDireccion.Text = cliente.Dirección;
        }
        #endregion

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PedidoEntity pedidoEntity = new PedidoEntity(EntityState.Modified);
        //    pedidoEntity.Id_Pedido = Convert.ToInt32(txtPedido.Text);
        //    pedidoEntity.Dirección = txtDireccion.Text;
        //    pedidoEntity.TelefonoContacto = cbCliente.Text;
        //    pedidoEntity.Total = 1500; //luego ver de como calcular el total sumando detalle pedido 
        //    pedidoEntity.Descripción = txtDescripción.Text;
        //    _pedidoController.GuardarCambios(pedidoEntity);
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleEntity detalle = new DetalleEntity(EntityState.Added);

                detalle.Tipo = cboTipoProducto.Text.Remove(cboTipoProducto.Text.Length - 1, 1);
                detalle.Id_Pedido = Convert.ToInt32(txtPedido.Text);
                detalle.Nombre = cboProducto.Text;
                detalle.Cantidad = Convert.ToInt32(txtCant.Text);

                _detalleController.GuardarCambios(detalle);

                LlenarGrilla();
                cboProducto.SelectedItem = null;
                btnAgregar.Enabled = false;
                btnFinalizar.Enabled = true;
            }
            catch (Exception ex)
            {
                //esta bien aplicar la logica asi aca?
                DialogResult d;
                d = MessageBox.Show($"{ex.Message} \nDesea agregar stock?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    RegistroProducto();
                }
                else
                {
                    LlenarGrilla();
                }
            }
        }

        private void btnMAS_Click(object sender, EventArgs e)
        {
            //suma de a 1 la cantidad
            txtCant.Text = (Convert.ToInt32(txtCant.Text) + 1).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //resta de a 1 la cantidad
            if (txtCant.Text == "1")
            {

            }
            else
            {
                txtCant.Text = (Convert.ToInt32(txtCant.Text) - 1).ToString();
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDir();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DetalleEntity detalle = new DetalleEntity(EntityState.Deleted);
            detalle.Nombre = (string)dataGridView1.SelectedCells[1].Value;
            detalle.Tipo = (string)dataGridView1.SelectedCells[0].Value;
            detalle.Id_Pedido = Convert.ToInt32(txtPedido.Text);
            btnQuitar.Enabled = false;
            _detalleController.GuardarCambios(detalle);
            LlenarGrilla();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoEntity pedidoEntity = new PedidoEntity(EntityState.Added);
                CrearPedidoId();
                pedidoEntity.Id_Pedido = Convert.ToInt32(txtPedido.Text);
                cbCliente.Enabled = true;
                cboTipoProducto.Enabled = true;
                _pedidoController.GuardarCambios(pedidoEntity);
                btnComenzar.Enabled = false;
                txtDescripción.Enabled = true;
                btnMAS.Enabled = true;
                btnMenos.Enabled = true;
                txtCant.Enabled = true;
                btnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCliente_Leave(object sender, EventArgs e)
        {

            var cliente = _clienteController.GetCliente(cbCliente.Text);
            //Esta bien hacer un if así aca en el front? o sería mejor manejarlo en las excepciones
            //como sería con las excepciones? puedo hacer referencias a los forms (hacer uso de system.windows.forms)?
            if (cliente == null)
            {
                DialogResult d;
                d = MessageBox.Show("El cliente ingresado no existe, desea registrarlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    RegistroCliente();
                    cbCliente.Items.Clear();
                    LlenarComboBoxClientes();
                    ActualizarDir();
                }
                else
                {
                    cbCliente.Text = string.Empty;
                }

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoEntity pedidoEntity = new PedidoEntity(EntityState.Modified);
                pedidoEntity.Retiro = SeleccionarModoRetiro();
                pedidoEntity.Estado = "En preparación";
                pedidoEntity.Id_Pedido = Convert.ToInt32(txtPedido.Text);
                pedidoEntity.Dirección = txtDireccion.Text;
                pedidoEntity.TelefonoContacto = cbCliente.Text;
                pedidoEntity.Descripción = txtDescripción.Text;
                _pedidoController.GuardarCambios(pedidoEntity);
                LimpiarForm();
                MessageBox.Show("Pedido creado con éxito.");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PedidoEntity pedidoEntity = new PedidoEntity(EntityState.Modified);
            pedidoEntity.Id_Pedido = Convert.ToInt32(txtPedido.Text);
            pedidoEntity.Retiro = SeleccionarModoRetiro();
            pedidoEntity.Estado = "Cancelado";
            pedidoEntity.Dirección = txtDireccion.Text;
            pedidoEntity.TelefonoContacto = cbCliente.Text;
            pedidoEntity.Descripción = txtDescripción.Text;
            _pedidoController.GuardarCambios(pedidoEntity);
            LimpiarForm();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnQuitar.Enabled = true;
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void cbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboBoxProductos();
        }

        private void PedidosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LeaveForm();
        }

        private void LeaveForm()
        {
            if (txtPedido.Text != "")
            {
                PedidoEntity pedidoEntity = new PedidoEntity(EntityState.Modified);
                pedidoEntity.Id_Pedido = Convert.ToInt32(txtPedido.Text);
                pedidoEntity.Retiro = SeleccionarModoRetiro();
                pedidoEntity.Estado = "Cancelado";
                pedidoEntity.Dirección = txtDireccion.Text;
                pedidoEntity.TelefonoContacto = cbCliente.Text;
                pedidoEntity.Descripción = txtDescripción.Text;
                _pedidoController.GuardarCambios(pedidoEntity);
                LimpiarForm();
            }
        }

        private void PedidosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LeaveForm();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
