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

        /// <summary>
        /// guarda los cambios del pedido
        /// </summary>
        /// <param name="pedidoEntity"></param>
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
                        LoggerManager.Info($"El pedido {pedidoDTO.Id_Pedido} es iniciado.");
                        break;

                    case EntityState.Modified:

                        //pedidoDTO.Id_Cliente = _pedidoService.Get(x => x.Id_Pedido == pedidoDTO.Id_Pedido).FirstOrDefault().Id_Cliente;
                        //obtengo el id porque el get de entity no me trae el ID - para poder actualizar el objeto correcto
                        pedidoDTO = _pedidoService.GetById(pedidoDTO.Id_Pedido);
                        //pedidoDTO = _pedidoService.Get(x => x.Id_Pedido == pedidoEntity.Id_Pedido, includeProperties: "Cliente").FirstOrDefault();
                        if (pedidoEntity.Estado == "Finalizado")
                        {
                            pedidoDTO.Estado = pedidoEntity.Estado;
                            _pedidoService.ActualizarPedido(pedidoDTO);
                            LoggerManager.Info($"El pedido {pedidoDTO.Id_Pedido} fue creado. Cliente: {pedidoDTO.TelefonoContacto}. Total: ${pedidoDTO.Total}.");
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
                            LoggerManager.Info($"El pedido {pedidoDTO.Id_Pedido} fue cancelado.");
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

        /// <summary>
        /// Este método obtiene una lista de todos los pedidos que están actualmente "En preparación". Utiliza el servicio de pedidos para recuperar los datos y luego mapea los modelos de pedidos a las entidades de pedidos correspondientes antes de devolver la lista.
        /// </summary>
        /// <returns></returns>
        public List<PedidoEntity> ObtenerPedidos()
        {
            var listaPedidoModel = _pedidoService.Get(x => x.Estado == "En preparación").ToList();

            var listaPedido = _mapper.Map<List<PedidoEntity>>(listaPedidoModel);

            return listaPedido;
        }
        /// <summary>
        /// Este método obtiene una lista de todos los pedidos que han sido "Finalizados" y, por lo tanto, están listos para ser facturados. Utiliza el servicio de pedidos para recuperar los datos y luego mapea los modelos de pedidos a las entidades de pedidos correspondientes antes de devolver la lista.
        /// </summary>
        /// <returns></returns>
        public List<PedidoEntity> ObtenerPedidosParaFacturar()
        {
            var listaPedidoModel = _pedidoService.Get(x => x.Estado == "Finalizado").ToList();

            var listaPedido = _mapper.Map<List<PedidoEntity>>(listaPedidoModel);

            return listaPedido;
        }

        /// <summary>
        ///  Este método obtiene el último pedido que se ha creado en el sistema. Utiliza el servicio de pedidos para recuperar todos los pedidos, los ordena por fecha de creación y luego mapea el modelo de pedido correspondiente a una entidad de pedido antes de devolverlo.
        /// </summary>
        /// <returns></returns>
        public PedidoEntity ObtenerUltimoPedido()
        {
            if (_pedidoService.Get().FirstOrDefault() == null)
            {
                return null;
            }
            else
            {
                var pedido = _mapper.Map<PedidoEntity>(_pedidoService.Get().Last());

                return pedido;
            }
            
        }
        /// <summary>
        /// Este método obtiene un pedido específico según el ID proporcionado. Utiliza el servicio de pedidos para recuperar el pedido correspondiente y mapea el modelo de pedido a una entidad de pedido antes de devolverlo. También incluye datos del cliente asociado con el pedido a través de la propiedad de navegación "Cliente".
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PedidoEntity ObtenerPedido(int id)
        {
            var pedido = _mapper.Map<PedidoEntity>(_pedidoService.Get(x => x.Id_Pedido == id).FirstOrDefault());
            var cliente = _clienteService.Get(x => x.Id_Cliente == pedido.Id_Cliente).FirstOrDefault();
            pedido.NombreCliente = cliente.Nombre;
            return pedido;
        }
    }
}
