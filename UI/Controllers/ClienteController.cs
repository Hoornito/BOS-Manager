using AutoMapper;

using Contratos.Controllers;
using Contratos.Services;

using Domain.Entities;
using Domain.Models;

using Microsoft.EntityFrameworkCore;

using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;

using UI.Validators;

namespace UI.Controllers
{
    public class ClienteController : IClienteController
    {
        IClienteService _clienteService;
        IMapper _mapper;
        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        /// <summary>
        /// recupera una lista de todos los clientes desde una capa de servicio, convierte los modelos de clientes resultantes en entidades de clientes utilizando AutoMapper y devuelve la lista de entidades de clientes.
        /// </summary>
        /// <returns></returns>
        public List<ClienteEntity> GetAll()
        {
            var listaClienteModel = _clienteService.GetAll().ToList();

            var listaCliente = _mapper.Map<List<ClienteEntity>>(listaClienteModel);

            return listaCliente;
        }

        /// <summary>
        /// recupera un cliente por número de teléfono desde una capa de servicio, convierte el modelo de cliente resultante en una entidad de cliente utilizando AutoMapper y devuelve la entidad de cliente.
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public ClienteEntity GetCliente(string telefono)
        {
            //obtengo el cliente por numero de telefono
            var cliente = _mapper.Map<ClienteEntity>(_clienteService.Get(x => x.Teléfono == telefono).FirstOrDefault());
            return cliente;
        }

        /// <summary>
        /// está decorado con un atributo personalizado "ViewValidator", que presumiblemente valida los parámetros de entrada antes de ejecutar el método. Este método toma una entidad de cliente como entrada y realiza una operación de creación, actualización o eliminación según el estado de la entidad de cliente. El método también registra las operaciones realizadas en un archivo de registro y establece el estado de la entidad de cliente en "Unchanged" al final de la operación.
        /// </summary>
        /// <param name="clienteEntity"></param>
        [ViewValidator]
        public void GuardarCambios(ClienteEntity clienteEntity)
        {
            try
            {
                //Convierto el objeto de vista al objeto de transporte DTO
                var clienteDTO = _mapper.Map<ClienteModel>(clienteEntity);

                switch (clienteEntity.State)
                {
                    case EntityState.Added:
                        _clienteService.CrearCliente(clienteDTO);
                        LoggerManager.Info($"El cliente {clienteDTO.Nombre} fue creado correctamente.");
                        break;

                    case EntityState.Modified:

                        clienteDTO.Id_Cliente = _clienteService.Get(x => x.Teléfono == clienteDTO.Teléfono).FirstOrDefault().Id_Cliente;
                        //obtengo el id porque el get de entity no me trae el ID - para poder actualizar el objeto correcto
                        clienteDTO = _clienteService.GetById(clienteDTO.Id_Cliente);
                        clienteDTO.Nombre = clienteEntity.Nombre;
                        clienteDTO.MailContacto = clienteEntity.MailContacto;
                        clienteDTO.Dirección = clienteEntity.Dirección;
                        clienteDTO.DNI = clienteEntity.DNI;
                        _clienteService.ActualizarCliente(clienteDTO);
                        LoggerManager.Info($"El cliente {clienteDTO.Nombre} fue actualizado correctamente.");
                        break;

                    case EntityState.Deleted:

                        clienteDTO = _clienteService.Get(x => x.Teléfono == clienteDTO.Teléfono).FirstOrDefault();
                        clienteDTO = _clienteService.GetById(clienteDTO.Id_Cliente);
                        //clienteDTO.Nombre = clienteEntity.Nombre;
                        //clienteDTO.MailContacto = clienteEntity.MailContacto;
                        //clienteDTO.Dirección = clienteEntity.Dirección;
                        //clienteDTO.DNI = clienteEntity.DNI;
                        clienteDTO.Active = false;
                        _clienteService.ActualizarCliente(clienteDTO);
                        LoggerManager.Info($"El cliente {clienteDTO.Nombre} fue eliminado correctamente.");
                        //CustomerService.Current.Remove(customerDTO.IdCustomer);
                        break;
                }

                clienteEntity.State = EntityState.Unchanged;
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}
