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
    public partial class VisualizarPedidosForm : Form
    {
        IPedidoController _pedidoController;
        IDetalleController _detalleController;
        public VisualizarPedidosForm(IPedidoController pedidoController, IDetalleController detalleController)
        {
            _detalleController = detalleController;
            _pedidoController = pedidoController;
            InitializeComponent();
            LlenarGrillaPedido();
            TranducirForm.Current.TraducirFormulario(this);
        }

        private void LlenarGrillaPedido()
        {
            dataGridViewPedidoId.AutoGenerateColumns = true;

            //UTILIZANDO LINQ
            var listaPedido = _pedidoController.ObtenerPedidos().Select
                (x => new
                {
                    Pedido = x.Id_Pedido,                    
                });
            dataGridViewPedidoId.DataSource = listaPedido.ToList();
        }
        private void LlenarGrillaDetalle(int id)
        {
            PedidoEntity pedido = new PedidoEntity();
            pedido.Id_Pedido = Convert.ToInt32(id);

            dataGridViewPedidoDetalle.AutoGenerateColumns = true;

            //UTILIZANDO LINQ
            var listaDetalle = _detalleController.ObtenerDetalle(pedido).Select
            (x => new
            {
                Producto = x.Nombre,
                //Precio = x.PrecioUnidad,
                Cantidad = x.Cantidad,
                //SubTotal = x.SubTotal,
            });

            dataGridViewPedidoDetalle.DataSource = listaDetalle.ToList();
        }

        private void dataGridViewPedidoId_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //PedidoEntity pedido = new PedidoEntity();
            //pedido.Id_Pedido = (int)dataGridViewPedidoId.SelectedCells[0].Value;
            LlenarGrillaDetalle((int)dataGridViewPedidoId.SelectedCells[0].Value);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            PedidoEntity pedidoEntity = new PedidoEntity(EntityState.Modified);

            pedidoEntity.Estado = "Finalizado";
            pedidoEntity.Id_Pedido = (int)dataGridViewPedidoId.SelectedCells[0].Value;
            _pedidoController.GuardarCambios(pedidoEntity);
            LlenarGrillaPedido();
            dataGridViewPedidoDetalle.DataSource = null;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LlenarGrillaPedido();
        }

    }
}
