using System.Collections.Generic;

namespace Domain.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {
            this.Pedido = new HashSet<PedidoModel>();
        }

        public int Id_Cliente { get; set; }
        public string Dirección { get; set; }
        public string DNI { get; set; }
        public bool Active { get; set; }
        public string MailContacto { get; set; }
        public string Nombre { get; set; }
        public string Teléfono { get; set; }


        public virtual ICollection<PedidoModel> Pedido { get; set; }
    }
}
