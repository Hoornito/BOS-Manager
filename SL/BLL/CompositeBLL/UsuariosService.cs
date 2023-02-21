using AutoMapper;

using SL.Contratos;
using SL.Contratos.Controllers;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.DAL.Repositories.SqlServer;
using SL.Domain.Entities;
using SL.Domain.Models;
using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class UsuariosService :GenericService<UsuarioModel>, IUsuariosService
    {
        private readonly IUsuario_PermisoService _usuario_PermisoService;
        
        public UsuariosService(IUnitOfWork unitOfWork, IUsuario_PermisoService usuario_PermisoService) 
            : base(unitOfWork, unitOfWork.GetRepository<IUsuariosRepository>())
        {
            _usuario_PermisoService = usuario_PermisoService;
        }

        public void CrearUsuario(UsuarioModel usuario)
        {
            var password = HashPassword(usuario.pw);
            usuario.pw = password;
            _repository.Insert(usuario);
            _unitOfWork.Save();
        }

        public void GuardarPermisos(Usuario_PermisoModel u, List<Usuario_PermisoModel> permisos)
        {
            try
            {
                var permisosDeUsuario = _usuario_PermisoService.Get(x => x.id_usuario == u.id_usuario, tracking: true).ToList();
                _usuario_PermisoService.Eliminar(permisosDeUsuario);
                
                foreach (var permiso in permisos)
                {
                    _usuario_PermisoService.Insertar(permiso);
                }
                _unitOfWork.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = new Rfc2898DeriveBytes(password, salt, 10000).GetBytes(32);

            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            return Convert.ToBase64String(hashBytes);
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(32);

            for (int i = 0; i < 32; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool Login(string usuario, string password)
        {
            //afytodo - 1 - log that user is trying to login
            LoggerManager.Info("Intento de ingreso para usuario: " + usuario);
            var usuarioModel = _repository.Get(x => x.usuario == usuario).FirstOrDefault();
            if (usuarioModel != null && VerifyPassword(password, usuarioModel.pw))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
