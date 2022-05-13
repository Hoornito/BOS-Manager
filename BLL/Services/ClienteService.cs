using Contratos.Repositories;
using Contratos.Services;

using Domain.Models;

using System;
using System.Linq;

namespace BLL.Services
{
    /// <summary>
    ///  Clase para gestionar cliente
    /// </summary>
    public class ClienteService : GenericService<ClienteModel>, IClienteService
    {
        
        public ClienteService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IClienteRepository>())
        {

        }

        public void ActualizarCliente(ClienteModel clienteModel)
        {
            Actualizar(clienteModel);

            _unitOfWork.Save();
        }

        /// <summary>
        ///  Metodo para crear cliente
        /// </summary>
        public void CrearCliente(ClienteModel clienteModel)
        {
            try
            {
                var helper = Get(x => x.Teléfono == clienteModel.Teléfono).FirstOrDefault();

                if (helper == null)
                {
                    Insertar(clienteModel);

                    _unitOfWork.Save();
                }
                else
                {
                    throw new Exception("El cliente ya existe.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarCliente(ClienteModel clienteModel)
        {
            Eliminar(clienteModel);

            _unitOfWork.Save();
        }

    }
}
