using SL.Domain.Entities;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Services
{
    public interface IUsuariosService : IGenericService<UsuarioModel>
    {
        public void GuardarPermisos(Usuario_PermisoModel u, List<Usuario_PermisoModel> permisos);
        public void CrearUsuario(UsuarioModel usuario);
        public bool Login(string usuario, string password);
    }
}
