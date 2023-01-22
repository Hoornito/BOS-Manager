using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class PermisoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string permiso { get; set; }
        public ICollection<Usuario_PermisoModel> Usuario_Permisos { get; set; }
    }
}
