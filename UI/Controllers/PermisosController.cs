using AutoMapper;

using SL.Contratos.Controllers;
using SL.Contratos.Services;
using SL.Domain.Entities;
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

        public ComponenteEntity GuardarComponente(ComponenteEntity componente, bool esfamilia)
        {
            PermisoModel permiso = new PermisoModel();
            permiso.nombre = componente.Nombre;

            if (esfamilia)
                componente.Permiso = null;


            permiso.permiso = componente.Permiso.ToString();
            
            _permisosService.CrearPermiso(permiso);
            
            return componente;
        }

        public void GuardarFamilia(FamiliaEntity familia)
        {
            //borrar de permiso_permiso donde id_permiso_padre = familia.Id y guardar en permiso_permiso
            //_permiso_permisoService.EliminarFamilia(familia.Id);
            List<Permiso_PermisoModel> listaPermisos = new List<Permiso_PermisoModel>();
            foreach (var item in familia.Hijos)
            {
                Permiso_PermisoModel permiso_PermisoModel = new Permiso_PermisoModel();
                permiso_PermisoModel.id_permiso_padre = familia.Id;
                permiso_PermisoModel.id_permiso_hijo = item.Id;

                listaPermisos.Add(permiso_PermisoModel);
            }

            Permiso_PermisoModel familiaModel = _mapper.Map<Permiso_PermisoModel>(familia);
            _permiso_permisoService.GuardarFamilia(familiaModel, listaPermisos);
            if (familia.Hijos.Count == 0)
            {
                throw new Exception("No se puede guardar una familia sin hijos");
            }
                
        }

        public IList<PatenteEntity> GetAllPatentes()
        {
            var permisosModel = _permisosService.Get(tracking : false).ToList();

            var permisoEntity = _mapper.Map<List<PatenteEntity>>(permisosModel);

            return permisoEntity.Where(x => x.Permiso != null).ToList();
        }

        public IList<FamiliaEntity> GetAllFamilias()
        {
            //var permisosModel = _permisosService.GetAll().ToList();
            var permisosModel = _permisosService.Get().ToList();

            var permisoEntity = _mapper.Map<List<PatenteEntity>>(permisosModel);
            var familias = permisoEntity.Where(x => x.Permiso == null).ToList();
            List<FamiliaEntity> familiasEntity = familias.Select(x => new FamiliaEntity() { Id = x.Id, Nombre = x.Nombre, Permiso = x.Permiso}).ToList();
            var familiasEntity2 = _permiso_permisoService.Get().ToList(); //familiasEntity2 = relacion entre familias (padre - hijos)
            foreach (var familia in familiasEntity)
            {
                var family = familiasEntity2.Where(x => x.id_permiso_padre == familia.Id).ToList();
                foreach (var hijo in family)
                {
                    var PermisosFamilia = permisosModel.Where(x => x.id == hijo.id_permiso_hijo && x.permiso != null).ToList();
                    foreach (var permiso in PermisosFamilia)
                    {
                        familia.AgregarHijo(new PatenteEntity() { 
                            Id = permiso.id, Nombre = permiso.nombre,
                            Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permiso.permiso)
                        });
                    }
                }
            }

            return familiasEntity;
        }

        public void GuardarPatente(string patente, string permiso)
        {
            PatenteEntity patenteEntity = new PatenteEntity()
            {
                Nombre = patente,
                Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permiso)
            };
            
            var permisoModel = _mapper.Map<PermisoModel>(patenteEntity);
            _permisosService.CrearPermiso(permisoModel);
        }
    }
}
