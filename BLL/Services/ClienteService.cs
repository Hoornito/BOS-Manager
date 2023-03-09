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
        /// <summary>
        /// El constructor "ClienteService" crea una instancia de la clase "ClienteService" y toma un objeto "IUnitOfWork" como parámetro. Este constructor llama al constructor base de la clase y obtiene un repositorio específico. No devuelve ningún valor.
        /// </summary>
        /// <param name="unitOfWork"></param>
        public ClienteService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IClienteRepository>())
        {

        }

        /// <summary>
        /// El método "ActualizarCliente" actualiza la información de un cliente existente y toma un objeto "ClienteModel" como parámetro. Este método llama a un método de la clase base para actualizar el cliente y luego llama al método "Save" del objeto "IUnitOfWork" para guardar los cambios realizados.
        /// </summary>
        /// <param name="clienteModel"></param>
        public void ActualizarCliente(ClienteModel clienteModel)
        {
            Actualizar(clienteModel);

            _unitOfWork.Save();
        }

        /// <summary>
        /// El método "CrearCliente" crea un nuevo cliente y toma un objeto "ClienteModel" como parámetro. Este método primero verifica si ya existe un cliente con el mismo número de teléfono y, en caso de que no exista, llama a un método de la clase base para insertar el nuevo cliente y luego llama al método "Save" del objeto "IUnitOfWork" para guardar los cambios realizados. Si el cliente ya existe, se lanza una excepción.
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

        /// <summary>
        /// El método "EliminarCliente" elimina un cliente existente y toma un objeto "ClienteModel" como parámetro. Este método llama a un método de la clase base para eliminar el cliente y luego llama al método "Save" del objeto "IUnitOfWork" para guardar los cambios realizados.
        /// </summary>
        /// <param name="clienteModel"></param>
        public void EliminarCliente(ClienteModel clienteModel)
        {
            Eliminar(clienteModel);

            _unitOfWork.Save();
        }

    }
}
