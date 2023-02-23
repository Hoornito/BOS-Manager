using AutoMapper;

using SL.BLL.CompositeBLL;
using SL.Contratos.Controllers;
using SL.Contratos.Services;
using SL.Domain.Entities;
using SL.Domain.Models;
using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class PermisosController : IPermisosController
    {
        private readonly IPermisosService _permisosService;
        private readonly IPermiso_PermisoService _permiso_permisoService;
        private readonly IUsuario_PermisoService _usuario_permisoService;
        private readonly IUsuariosService _usuariosService;
        private readonly IMapper _mapper;

        public PermisosController(IPermisosService permisosService, IUsuario_PermisoService usuario_PermisoService, IUsuariosService usuariosService, IPermiso_PermisoService permiso_PermisoService, IMapper mapper)
        {
            _permisosService = permisosService;
            _permiso_permisoService = permiso_PermisoService;
            _usuario_permisoService = usuario_PermisoService;
            _usuariosService = usuariosService;
            _mapper = mapper;
        }

        public ComponenteEntity GuardarComponente(ComponenteEntity componente, bool esfamilia)
        {
            PermisoModel permiso = new PermisoModel();
            permiso.nombre = componente.Nombre;

            permiso.permiso = componente.Permiso.ToString();

            if (esfamilia)
                permiso.permiso = null;

            var help = _permisosService.CrearPermiso(permiso);
            LoggerManager.Info($"Permiso: {permiso.nombre} creado correctamente.");
            componente.Id = help.id;
            return componente;
        }

        public void GuardarFamilia(FamiliaEntity familia)
        {
            List<Permiso_PermisoModel> listaPermisos = new List<Permiso_PermisoModel>();
            foreach (var item in familia.Hijos)
            {
                Permiso_PermisoModel permiso_PermisoModel = new Permiso_PermisoModel();
                permiso_PermisoModel.id_permiso_padre = familia.Id;
                permiso_PermisoModel.id_permiso_hijo = item.Id;

                listaPermisos.Add(permiso_PermisoModel);
                LoggerManager.Info($"Permiso: {item.Nombre} agregado a la familia: {familia.Nombre} correctamente.");
            }
            Permiso_PermisoModel familiaModel = _mapper.Map<Permiso_PermisoModel>(familia);
            _permiso_permisoService.GuardarFamilia(familiaModel, listaPermisos);
            LoggerManager.Info($"Familia: {familia.Nombre} guardada correctamente.");
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

            
            foreach (var item in familiasEntity2)
            {
                var FamiliaHijaDto = permisosModel.Where(x => x.id == item.id_permiso_hijo && x.permiso == null).FirstOrDefault();
                if (FamiliaHijaDto == null)
                    continue;
                foreach (var FamiliaPadre in familiasEntity.Where(x => x.Id == item.id_permiso_padre))
                {
                    if (familiasEntity2.Where(x => x.id_permiso_padre == FamiliaPadre.Id).Any()) 
                    {
                        var FamiliaHija2 = familiasEntity.Where(x => x.Id == FamiliaHijaDto.id).FirstOrDefault();
                        FamiliaPadre.AgregarHijo(FamiliaHija2);
                        break;
                    }
                    var FamiliaHija = familiasEntity.Where(x => x.Id == FamiliaHijaDto.id).FirstOrDefault();
                    FamiliaPadre.AgregarHijo(FamiliaHija);
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
            LoggerManager.Info($"Permiso: {patente} creado correctamente.");
        }
        
        public bool ValidarExistencia(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso) => _permisosService.BuscarPermiso(permisos, tipoPermiso);

        public bool ValidarFamilias(FamiliaEntity familiaActual, FamiliaEntity familiaAgregar) => _permisosService.ValidarPermisosRepetidos(familiaActual, familiaAgregar);

        public IList<UsuarioEntity> ObtenerUsuarios() /*=> _mapper.Map<List<Usuario>>(_usuarioService.Get().ToList());*/
        {
            var UsuariosCompletosDto = _usuariosService.Get().ToList();
            List<UsuarioEntity> listaUsuarios = new List<UsuarioEntity>();
            listaUsuarios.AddRange(_mapper.Map<List<UsuarioEntity>>(UsuariosCompletosDto));
            return listaUsuarios;
        }

        public List<UsuarioEntity> GetAllUsuariosCompletos()
        {
            var Familias = GetAllFamilias();
            var Usuarios = ObtenerUsuarios();
            var UsuariosConPermiso = UsuariosConPermisos(Usuarios.ToList());
            var Usuarioscompletos = UsuariosCompletos(UsuariosConPermiso, Familias.ToList());

            return Usuarioscompletos;
        }
        
        private List<UsuarioEntity> UsuariosConPermisos(List<UsuarioEntity> Usuarios)
        {
            var UsuariosPermisos = _usuario_permisoService.Get(includeProperties: "PermisoModel").ToList();

            Usuarios.ForEach(x =>
            {
                var Permisos = UsuariosPermisos.Where(z => z.id_usuario == x.Id).ToList();
                x?.Permisos?.AddRange(Permisos.Where(x => x.PermisoModel.permiso != null).Select(x => new PatenteEntity
                {
                    Id = x.PermisoModel.id,
                    Nombre = x.PermisoModel.nombre,
                    Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), x.PermisoModel.permiso)
                }));
            });
            return Usuarios;
        }

        private List<UsuarioEntity> UsuariosCompletos(List<UsuarioEntity> usuarios, List<FamiliaEntity> familias)
        {
            var PermisosDto = _usuario_permisoService.Get().ToList();

            usuarios.ForEach(x =>
            {
                familias.ForEach(z =>
                {
                    var Permisos = PermisosDto.Where(y => y.id_permiso == z.Id && y.id_usuario == x.Id).FirstOrDefault();
                    if (Permisos != null)
                    {
                        FamiliaEntity family = familias.Where(x => x.Id == Permisos.id_permiso).FirstOrDefault();
                        x.Permisos.RemoveAll(x => x.Id == family.Id);
                        x.Permisos.Add(family);
                    }
                });
            });
            return usuarios;
        }
        
        public void GuardarPermisos(UsuarioEntity u)
        {
            try
            {
                var permisoPadre = _mapper.Map<Usuario_PermisoModel>(u);
                List<Usuario_PermisoModel> h = new List<Usuario_PermisoModel>();
                foreach (var item in u.Permisos)
                {
                    Usuario_PermisoModel permisopermiso = new Usuario_PermisoModel();
                    permisopermiso.id_usuario = u.Id;
                    permisopermiso.id_permiso = item.Id;
                    h.Add(permisopermiso);
                    LoggerManager.Info($"Permiso: {item.Nombre} agregado al usuario: {u.usuario}.");
                }
                _usuariosService.GuardarPermisos(permisoPadre, h);
                LoggerManager.Info($"Permisos guardados correctamente para el usuario {u.usuario}.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UsuarioEntity GetUsuario(string nombre)
        {
            return GetUsuarioCompleto(nombre);
        }

        public UsuarioEntity GetUsuarioCompleto(string nombre)
        {
            var usuarioDto = _usuariosService.Get(x => x.usuario == nombre, tracking: false).FirstOrDefault();
            var usuario = _mapper.Map<UsuarioEntity>(usuarioDto);

            var familias = GetAllFamilias();
            var usuarioConPermisos = ObtenerPermisosDeUsuario(usuario);
            usuario = UsuariosCompletos(usuarioConPermisos, familias.ToList()).FirstOrDefault();
            return usuario;
        }
        
        public List<UsuarioEntity> ObtenerPermisosDeUsuario(UsuarioEntity usuario)
        {
            try
            {
                List<UsuarioEntity> usuarios = new List<UsuarioEntity>();
                usuarios.Add(usuario);
                return UsuariosConPermisos(usuarios);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
