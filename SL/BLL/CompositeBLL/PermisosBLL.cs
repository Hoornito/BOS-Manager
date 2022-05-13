using SL.Contratos;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.DAL.Repositories.SqlServer;
using SL.Domain.Entities;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class PermisosBLL : GenericService<PermisoModel>
    {
        PermisosRepository _permisos;
        public PermisosBLL(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IPermisosRepository>())
        {

        }

        //public PermisosBLL()
        //{
        //    _permisos = new PermisosRepository();
        //}

        public bool Existe(ComponenteEntity c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }


        public Array GetAllPermission()
        {
            return _permisos.GetAllPermission();
        }


        public ComponenteEntity GuardarComponente(ComponenteEntity p, bool esfamilia)
        {
            return _permisos.GuardarComponente(p, esfamilia);
        }


        public void GuardarFamilia(FamiliaEntity c)
        {
            _permisos.GuardarFamilia(c);
        }

        public IList<PatenteEntity> GetAllPatentes()
        {
            return _permisos.GetAllPatentes();
        }

        public IList<FamiliaEntity> GetAllFamilias()
        {
            return _permisos.GetAllFamilias();
        }

        public IList<ComponenteEntity> GetAll(string familia)
        {
            return _permisos.GetAll(familia);

        }

        public void FillUserComponents(UsuarioEntity u)
        {
            _permisos.FillUserComponents(u);

        }

        public void FillFamilyComponents(FamiliaEntity familia)
        {
            _permisos.FillFamilyComponents(familia);
        }

        public PermisoModel CrearPermiso(PermisoModel permiso)
        {
            throw new NotImplementedException();
        }

        public void ActualizarPermiso(PermisoModel permiso)
        {
            throw new NotImplementedException();
        }

        public void EliminarPermiso(PermisoModel permiso)
        {
            throw new NotImplementedException();
        }
    }
}
