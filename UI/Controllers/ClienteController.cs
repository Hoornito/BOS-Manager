using AutoMapper;

using Contratos.Controllers;
using Contratos.Services;

using Domain.Entities;
using Domain.Models;

using Microsoft.EntityFrameworkCore;

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

        public List<ClienteEntity> GetAll()
        {
            var listaClienteModel = _clienteService.GetAll().ToList();

            var listaCliente = _mapper.Map<List<ClienteEntity>>(listaClienteModel);

            return listaCliente;
        }


        public ClienteEntity GetCliente(string telefono)
        {
            //obtengo el cliente por numero de telefono
            var cliente = _mapper.Map<ClienteEntity>(_clienteService.Get(x => x.Teléfono == telefono).FirstOrDefault());
            return cliente;
        }


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
