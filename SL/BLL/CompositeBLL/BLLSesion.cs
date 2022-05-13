using SL.DAL.Repositories.SqlServer;
using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class BLLSesion
    {
        public void Login(UsuarioEntity u)
        {

            (new PermisosRepository()).FillUserComponents(u);
            //SimuladorSesion.GetInstance.Login(u);

        }

        public void Logout()
        {
            //SimuladorSesion.GetInstance.Logout();
        }
    }
}
