using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class UsuarioModel
    {
        public UsuarioModel() 
        {
            Usuario_Permisos = new List<Usuario_PermisoModel>();
        }
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string pw { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? email { get; set; }
        public string? telefono { get; set; }
        public string? dni { get; set; }
        public ICollection<Usuario_PermisoModel> Usuario_Permisos { get; set; }
    }
}
