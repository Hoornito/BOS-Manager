using Contratos.Controllers;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Tools.LanguageManager;

namespace UI.ChildForms
{
    public partial class FacturacionForm : Form
    {

        private readonly IDetalleController _detalleController;
        private readonly IPedidoController _pedidoController;
        private readonly IFacturaController _facturaController;

        public FacturacionForm(IDetalleController detalleController, IPedidoController pedidoController, IFacturaController facturaController)
        {
            _detalleController = detalleController;
            _pedidoController = pedidoController;
            _facturaController = facturaController;
            InitializeComponent();
            LlenarGrillaPedido();
            TranducirForm.Current.TraducirFormulario(this);
        }

        #region Metodos
        private void LlenarGrillaPedido()
        {
            dataGridViewPedidoId.AutoGenerateColumns = true;

            //UTILIZANDO LINQ
            var listaPedido = _pedidoController.ObtenerPedidosParaFacturar().Select
                (x => new
                {
                    Pedido = x.Id_Pedido,
                });
            dataGridViewPedidoId.DataSource = listaPedido.ToList();
        }

        private void PrintList(int id)
        {
            PedidoEntity pedido = new PedidoEntity();
            pedido.Id_Pedido = Convert.ToInt32(id);
            pedido = _pedidoController.ObtenerPedido(id);
            var listaDetalle = _detalleController.ObtenerDetalle(pedido);

            listBox1.Items.Add("--- Punto de Venta ---");
            listBox1.Items.Add("Factura #: " /*+ Id_Factura*/);
            listBox1.Items.Add("Pedido #: " + id);
            listBox1.Items.Add("Cliente: " + pedido.NombreCliente/*+ nombreCliente*/);
            listBox1.Items.Add("Dirección: " + pedido.Dirección/*+ dirección*/);
            listBox1.Items.Add("Teléfono: " + pedido.TelefonoContacto/*+ teléfono*/);
            listBox1.Items.Add("--- Productos ---");

            foreach (var item in listaDetalle)
            {
                listBox1.Items.Add($"-> {item.Cantidad} x {item.Nombre} = {item.SubTotal}");
            }

            listBox1.Items.Add("--- Total: $" + pedido.Total);
            listBox1.Items.Add("--- Que lo disfrute ---");
        }

        #endregion



        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FacturaEntity facturaEntity = new FacturaEntity(EntityState.Added);

            facturaEntity.Id_Pedido = (int)dataGridViewPedidoId.SelectedCells[0].Value;
            facturaEntity.IVA = decimal.Parse(txtIVA.Text);

            _facturaController.GuardarCambios(facturaEntity);

            LlenarGrillaPedido();
            listBox1.Items.Clear();

        }

        private void dataGridViewPedidoId_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBox1.Items.Clear();
            PrintList((int)dataGridViewPedidoId.SelectedCells[0].Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtIVA.ReadOnly = !checkBox1.Checked;
        }
    }
}
