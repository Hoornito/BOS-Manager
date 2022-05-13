using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SL.Tools
{
    public class TicketPrint
    {
        #region singleton

        private readonly static TicketPrint _instance = new TicketPrint();

        public static TicketPrint Current
        {
            get
            {
                return _instance;
            }
        }

        private TicketPrint()
        {
            //Implent here the initialization of your singleton
        }

        #endregion

        public void imprimir(PrintPageEventArgs e, int Id_Factura, string nombreCliente, string dirección, string teléfono)
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
        }
    }
}
