using Domain.Entities;

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
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            TranducirForm.Current.TraducirFormulario(this);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        public void imprimir(object sender, PrintPageEventArgs e, int Id_Factura, string nombreCliente, string dirección, string teléfono, List<DetalleEntity> detallePedidoList)
        {
            Font font = new Font("Arial", 14);
            int ancho = 350;
            int y = 20;

            e.Graphics.DrawString("--- Punto de Venta ---", font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Factura #: " + Id_Factura, font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + nombreCliente, font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Dirección: " + dirección, font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Teléfono: " + teléfono, font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Productos ---", font, Brushes.Black, new Rectangle(0, y += 30, ancho, 20));

            e.Graphics.DrawString("--- Punto de Venta ---", font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Punto de Venta ---", font, Brushes.Black, new Rectangle(0, y += 20, ancho, 20));

            foreach (var item in detallePedidoList)
            {

            }
        }
    }
}
