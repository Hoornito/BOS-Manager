using Contratos.Controllers;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using UI.Tools.LanguageManager;

namespace UI.ChildForms
{
    public partial class ClientesForm : Form
    {

        private readonly IClienteController _clienteController;
        public ClientesForm(IClienteController clienteController)
        {
            _clienteController = clienteController;
            InitializeComponent();

            LlenarGrilla();
            TranducirForm.Current.TraducirFormulario(this);
        }




        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity(EntityState.Added);
                //CargarDatos(cliente);

                cliente.Nombre = txtNombre.Text;
                cliente.DNI = txtDNI.Text;
                cliente.Dirección = txtDireccion.Text;
                cliente.MailContacto = txtmail.Text;
                cliente.Teléfono = txtTelefono.Text;

                _clienteController.GuardarCambios(cliente);

                LlenarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #region Métodos
        //private void CargarDatos(ClienteEntity cliente)
        //{
        //    cliente.Nombre = txtNombre.Text;
        //    cliente.DNI = txtDNI.Text;
        //    cliente.Dirección = txtDireccion.Text;
        //    cliente.MailContacto = txtmail.Text;
        //    cliente.Teléfono = txtTelefono.Text;
        //}
        private void LlenarGrilla()
        {
            dataGridView1.AutoGenerateColumns = true;

            //UTILIZANDO LINQ
            var listaDetalle = _clienteController.GetAll().Select
                (x => new
                {
                    Teléfono = x.Teléfono,
                    Nombre = x.Nombre,
                    Dirección = x.Dirección,
                    Mail = x.MailContacto,
                    DNI = x.DNI,
                    Estado = x.Active
                });

            dataGridView1.DataSource = listaDetalle.ToList();
        }
        #endregion

        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity(EntityState.Modified);

                //_clienteController.GetCliente(cliente.Teléfono);
                //CargarDatos(cliente);

                cliente.Nombre = txtNombre.Text;
                cliente.DNI = txtDNI.Text;
                cliente.Dirección = txtDireccion.Text;
                cliente.MailContacto = txtmail.Text;
                cliente.Teléfono = txtTelefono.Text;

                _clienteController.GuardarCambios(cliente);

                LlenarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClienteEntity cliente = new ClienteEntity();
            cliente.Teléfono = (string)dataGridView1.SelectedCells[0].Value;
            cliente = _clienteController.GetCliente(cliente.Teléfono);
            txtDireccion.Text = cliente.Dirección;
            txtNombre.Text = cliente.Nombre;
            txtDNI.Text = cliente.DNI;
            txtmail.Text = cliente.MailContacto;
            txtTelefono.Text = cliente.Teléfono;
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity(EntityState.Deleted);

                cliente.Nombre = txtNombre.Text;
                cliente.DNI = txtDNI.Text;
                cliente.Dirección = txtDireccion.Text;
                cliente.MailContacto = txtmail.Text;
                cliente.Teléfono = txtTelefono.Text;

                _clienteController.GuardarCambios(cliente);

                LlenarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
