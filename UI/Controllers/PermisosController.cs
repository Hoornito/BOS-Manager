using AutoMapper;

using SL.Contratos.Controllers;
using SL.Contratos.Services;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class PermisosController : IPermisosController
    {
        IPermisosService _permisosService;
        IPermiso_PermisoService _permiso_permisoService;
        IMapper _mapper;

        public PermisosController(IPermisosService permisosService, IPermiso_PermisoService permiso_PermisoService, IMapper mapper)
        {
            _permisosService = permisosService;
            _permiso_permisoService = permiso_PermisoService;
            _mapper = mapper;
        }

        public void ActualizarPermiso(PatenteModel permiso)
        {
            throw new NotImplementedException();
        }

        public PatenteModel CrearPermiso(PatenteModel permiso, bool esfamilia)
        {
            if (esfamilia)
                permiso.Nombre = null;

            _permisosService.CrearPermiso(permiso);
            
            return permiso;
        }

        public void EliminarFamilia(int familia_Id)
        {
            _permiso_permisoService.EliminarFamilia(familia_Id);
        }

        public void EliminarPermiso(PatenteModel permiso)
        {
            throw new NotImplementedException();
        }

        public void GuardarFamilia(FamiliaModel familia)
        {
            //borrar de permiso_permiso donde id_permiso_padre = familia.Id
            _permiso_permisoService.EliminarFamilia(familia.Id);
            Permiso_PermisoModel permiso_PermisoModel = new Permiso_PermisoModel();
            foreach (var item in familia.Hijos)
            {
                permiso_PermisoModel.id_permiso_padre = familia.Id;
                permiso_PermisoModel.id_permiso_hijo = item.Id;

                _permiso_permisoService.GuardarFamilia(permiso_PermisoModel);
            }
        }
    }
}
