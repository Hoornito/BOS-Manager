using SL.Contratos;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.Domain.Entities;
using SL.Domain.Models;
using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class PermisosService : GenericService<PermisoModel>, IPermisosService
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public PermisosService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IPermisosRepository>())
        {

        }
        /// <summary>
        /// Obtiene todos los permisos
        /// </summary>
        /// <returns></returns>
        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(TipoPermiso));
        }
        
        public void ActualizarPermiso(PermisoModel permiso)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crea un permiso
        /// </summary>
        /// <param name="permiso"></param>
        /// <returns></returns>
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
                LoggerManager.GenerateLog(ex);
                throw;
            }
        }

        /// <summary>
        /// Elimina un permiso
        /// </summary>
        /// <param name="permiso"></param>
        public void EliminarPermiso(PermisoModel permiso)
        {
            Eliminar(permiso);
        }

        /// <summary>
        /// Obtiene todos los permisos
        /// </summary>
        /// <param name="permisos"></param>
        /// <param name="tipoPermiso"></param>
        /// <returns></returns>
        public bool BuscarPermiso(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso)
        {
            try
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
            catch (Exception ex)
            {
                LoggerManager.GenerateLog(ex);
                throw;
            }
        }
        
        /// <summary>
        /// Valida que no se repitan los permisos
        /// </summary>
        /// <param name="familiaActual"></param>
        /// <param name="familiaAgregar"></param>
        /// <returns></returns>
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
            catch (Exception ex)
            {
                LoggerManager.GenerateLog(ex);
                throw;
            }
        }
        
        /// <summary>
        /// Separa las familias
        /// </summary>
        /// <param name="c"></param>
        /// <param name="Permisos"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Recorre las familias
        /// </summary>
        /// <param name="Listafamilias"></param>
        /// <param name="tipoPermiso"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Recorre las patentes
        /// </summary>
        /// <param name="patentes"></param>
        /// <param name="tipoPermiso"></param>
        /// <returns></returns>
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
