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
    public class UsuarioController : IUsuariosController
    {
        private readonly IUsuariosService _usuariosService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuariosService usuariosService, IUsuario_PermisoService usuario_PermisoService, IPermisosService permisoService, IPermiso_PermisoService permiso_PermisoService, IMapper mapper)
        {
            _usuariosService = usuariosService;
            _mapper = mapper;
        }
        /// <summary>
        /// crea un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void CrearUsuario(UsuarioEntity usuario)
        {
            var usuarioModel = _mapper.Map<UsuarioModel>(usuario);
            _usuariosService.CrearUsuario(usuarioModel);
            LoggerManager.Info($"Usuario {usuarioModel.usuario} creado correctamente.");
        }
        /// <summary>
        /// verifica la contraseña del usuario y devuelve true si es correcta
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool Login(UsuarioEntity usuario)
        {
            bool b = _usuariosService.Login(usuario.usuario, usuario.pw);
            if (b)
                LoggerManager.Info($"El usuario {usuario.usuario} ingresó correctamente.");
            else
                LoggerManager.Error($"Error en la validación de usuario: {usuario.usuario}");

            return b;
        }
        /// <summary>
        /// cambia el idioma al usuario
        /// </summary>
        /// <param name="idioma"></param>
        /// <param name="usuario"></param>
        public void CambiarIdiomaUsuario(string idioma, string usuario)
        {
            var usuarioId = _usuariosService.Get(x => x.usuario == usuario).FirstOrDefault().id_usuario;
            var usuarioModel = _usuariosService.GetById(usuarioId);
            usuarioModel.idioma = idioma;
            _usuariosService.Actualizar(usuarioModel);
        }
    }
}
