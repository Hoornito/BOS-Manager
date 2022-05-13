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
    public class PedidoController : IPedidoController
    {

        IPedidoService _pedidoService;
        IClienteService _clienteService;
        IMapper _mapper;

        public PedidoController(IPedidoService pedidoService, IClienteService clienteService, IMapper mapper)
        {
            _pedidoService = pedidoService;
            _clienteService = clienteService;
            _mapper = mapper;
        }

        [ViewValidator]
        public void GuardarCambios(PedidoEntity pedidoEntity)
        {
            try
            {
                //Convierto el objeto de vista al objeto de transporte DTO
                var pedidoDTO = _mapper.Map<PedidoModel>(pedidoEntity);

                switch (pedidoEntity.State)
                {
                    case EntityState.Added:
                        _pedidoService.CrearPedido(pedidoDTO);
                        break;

                    case EntityState.Modified:

                        //pedidoDTO.Id_Cliente = _pedidoService.Get(x => x.Id_Pedido == pedidoDTO.Id_Pedido).FirstOrDefault().Id_Cliente;
                        //obtengo el id porque el get de entity no me trae el ID - para poder actualizar el objeto correcto
                        pedidoDTO = _pedidoService.GetById(pedidoDTO.Id_Pedido);
                        if(pedidoEntity.Estado == "Finalizado")
                        {
                            pedidoDTO.Estado = pedidoEntity.Estado;
                            _pedidoService.ActualizarPedido(pedidoDTO);
                        }
                        else if(pedidoEntity.Estado == "Cancelado")
                        {
                            
                            pedidoDTO.TelefonoContacto = pedidoEntity.TelefonoContacto;
                            pedidoDTO.Retiro = pedidoEntity.Retiro;
                            pedidoDTO.Dirección = pedidoEntity.Dirección;
                            pedidoDTO.Total = pedidoEntity.Total;
                            pedidoDTO.Estado = pedidoEntity.Estado;
                            pedidoDTO.Descripción = pedidoEntity.Descripción;
                            _pedidoService.ActualizarPedido(pedidoDTO);
                        }
                        else
                        {
                            pedidoDTO.Id_Cliente = _clienteService.Get(x => x.Teléfono == pedidoEntity.TelefonoContacto).FirstOrDefault().Id_Cliente;
                            pedidoDTO.TelefonoContacto = pedidoEntity.TelefonoContacto;
                            pedidoDTO.Retiro = pedidoEntity.Retiro;
                            pedidoDTO.Dirección = pedidoEntity.Dirección;
                            pedidoDTO.Total = pedidoEntity.Total;
                            pedidoDTO.Estado = pedidoEntity.Estado;
                            pedidoDTO.Descripción = pedidoEntity.Descripción;
                            _pedidoService.ActualizarPedido(pedidoDTO);
                        }
                        break;

                    case EntityState.Deleted:

                        //clienteDTO = _clienteService.Get(x => x.Teléfono == clienteDTO.Teléfono).FirstOrDefault();
                        //clienteDTO = _clienteService.GetById(clienteDTO.Id_Cliente);
                        ////clienteDTO.Nombre = clienteEntity.Nombre;
                        ////clienteDTO.MailContacto = clienteEntity.MailContacto;
                        ////clienteDTO.Dirección = clienteEntity.Dirección;
                        ////clienteDTO.DNI = clienteEntity.DNI;
                        //clienteDTO.Active = false;
                        //_clienteService.ActualizarCliente(clienteDTO);
                        ////CustomerService.Current.Remove(customerDTO.IdCustomer);
                        break;
                }

                pedidoEntity.State = EntityState.Unchanged;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PedidoEntity> ObtenerPedidos()
        {
            var listaPedidoModel = _pedidoService.Get(x => x.Estado == "En preparación").ToList();

            var listaPedido = _mapper.Map<List<PedidoEntity>>(listaPedidoModel);

            return listaPedido;
        }
        public List<PedidoEntity> ObtenerPedidosParaFacturar()
        {
            var listaPedidoModel = _pedidoService.Get(x => x.Estado == "Finalizado").ToList();

            var listaPedido = _mapper.Map<List<PedidoEntity>>(listaPedidoModel);

            return listaPedido;
        }

        public PedidoEntity ObtenerUltimoPedido()
        {
            var pedido = _mapper.Map<PedidoEntity>(_pedidoService.Get().Last());

            return pedido;
        }

        public PedidoEntity ObtenerPedido(int id)
        {
            var pedido = _mapper.Map<PedidoEntity>(_pedidoService.Get(x => x.Id_Pedido == id, includeProperties: "Cliente").FirstOrDefault());
            
            return pedido;
        }
    }
}
