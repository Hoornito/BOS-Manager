﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class UsuarioModel
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string pw { get; set; }
        public ICollection<Usuario_PermisoModel> Usuario_Permisos { get; set; }
    }
}
