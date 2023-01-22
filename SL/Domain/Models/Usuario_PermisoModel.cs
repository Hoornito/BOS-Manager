using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class Usuario_PermisoModel
    {
        public int id_usuario { get; set; }
        public int id_permiso { get; set; }

        public UsuarioModel UsuarioModel { get; set; }
        public PermisoModel PermisoModel { get; set; }
    }
}
