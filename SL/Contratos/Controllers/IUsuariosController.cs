using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Controllers
{
    public interface IUsuariosController
    {
        public void CrearUsuario(UsuarioEntity usuario);
        public bool Login(UsuarioEntity usuario);
    }
}
