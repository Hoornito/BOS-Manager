using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class Permiso_PermisoModel
    {
        public int id_permiso_padre { get; set; }
        public int id_permiso_hijo { get; set; }
    }
}
