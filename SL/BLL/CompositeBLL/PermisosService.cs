using SL.Contratos;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.Domain.Entities;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class PermisosService : GenericService<PermisoModel>, IPermisosService
    {
        public PermisosService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IPermisosRepository>())
        {

        }

        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(TipoPermiso));
        }
        
        public void ActualizarPermiso(PermisoModel permiso)
        {
            throw new NotImplementedException();
        }

        public PermisoModel CrearPermiso(PermisoModel permiso)
        {
            try
            {
                if (permiso.nombre == null || permiso.nombre == "")
                {
                    throw new Exception("El nombre del permiso no puede estar vacio");
                }
                
                Insertar(permiso);

                _unitOfWork.Save();

                return permiso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPermiso(PermisoModel permiso)
        {
            Eliminar(permiso);
        }

        public bool BuscarPermiso(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso)
        {
            List<PatenteEntity> patentes = new List<PatenteEntity>();
            List<FamiliaEntity> familias = new List<FamiliaEntity>();
            patentes = permisos.OfType<PatenteEntity>().ToList();
            familias = permisos.OfType<FamiliaEntity>().ToList();
            bool Result = false;
            Result = RecorrerPatentes(patentes, tipoPermiso);
            if (!Result)
                Result = RecorrerFamilias(familias, tipoPermiso);
            return Result;
        }
        
        public bool ValidarPermisosRepetidos(FamiliaEntity familiaActual, FamiliaEntity familiaAgregar)
        {
            try
            {
                bool EstaRepetido = false;
                foreach (var componente in familiaAgregar.Hijos)
                {
                    if (componente is FamiliaEntity)
                        EstaRepetido = SepararFamilia(componente, familiaActual.Hijos.ToList());
                    else
                        EstaRepetido = BuscarPermiso(familiaActual.Hijos.ToList(), componente.Permiso);
                    if (EstaRepetido)
                        return true;
                }

                return EstaRepetido;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private bool SepararFamilia(ComponenteEntity c, List<ComponenteEntity> Permisos)
        {
            bool EstaRepetido = false;
            foreach (var patente in c.Hijos)
            {
                EstaRepetido = BuscarPermiso(Permisos, patente.Permiso);
                if (EstaRepetido)
                    return true;
            }
            return false;
        }

        private bool RecorrerFamilias(List<FamiliaEntity> Listafamilias, TipoPermiso? tipoPermiso)
        {
            bool Result = false;
            foreach (var Familias in Listafamilias)
            {
                foreach (var componente in Familias.Hijos)
                {
                    if (componente is PatenteEntity)
                        Result = RecorrerPatentes(new List<PatenteEntity>() { (PatenteEntity)componente }, tipoPermiso);
                    else
                        RecorrerFamilias(new List<FamiliaEntity>() { (FamiliaEntity)componente }, tipoPermiso);
                }
            }
            return Result;
        }

        private bool RecorrerPatentes(List<PatenteEntity> patentes, TipoPermiso? tipoPermiso)
        {
            foreach (PatenteEntity patente in patentes)
            {
                if (patente.Permiso == tipoPermiso)
                    return true;
            }
            return false;
        }
    }
}
