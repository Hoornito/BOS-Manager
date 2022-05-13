using SL.DAL.Repositories.SqlServer;
using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class UsuariosBLL
    {
        UsuariosRepository _usuarios;
        public UsuariosBLL()
        {
            _usuarios = new UsuariosRepository();
        }

        public List<UsuarioEntity> GetAll()
        {
            return _usuarios.GetAll();
        }

        public void GuardarPermisos(UsuarioEntity u)
        {
            _usuarios.GuardarPermisos(u);
        }
    }

}
