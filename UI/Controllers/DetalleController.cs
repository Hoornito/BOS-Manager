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
    public class DetalleController : IDetalleController
    {
        IDetalleService _detalleService;
        IProductoService _productoService;
        IMapper _mapper;
        public DetalleController(IDetalleService detalleService, IMapper mapper, IProductoService productoService)
        {
            _productoService = productoService;
            _detalleService = detalleService;
            _mapper = mapper;
        }

        /// <summary>
        /// recibe un objeto de entidad de pedido y devuelve una lista de detalles de pedido correspondientes. Utiliza el servicio de detalle para obtener detalles de pedido a través de una consulta que filtra por Id_Pedido y carga las propiedades de producto relacionadas. Luego, convierte los detalles de modelo a detalles de entidad y los agrega a una lista que se devuelve al final.
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public List<DetalleEntity> ObtenerDetalle(PedidoEntity pedido)
        {
            
            List<DetalleEntity> DetallePedido = new List<DetalleEntity>();
            List<DetalleModel> detalle = _detalleService.Get(x => x.Id_Pedido == pedido.Id_Pedido, includeProperties: "Producto").ToList();

            foreach (var item in detalle)
            {
                DetalleEntity detalleEntity = new DetalleEntity();
                detalleEntity.Tipo = item.Tipo;
                detalleEntity.Nombre = item.Producto.Nombre;
                detalleEntity.PrecioUnidad = item.Producto.PrecioUnidad;
                detalleEntity.Cantidad = item.Cantidad;
                detalleEntity.SubTotal = detalleEntity.PrecioUnidad * detalleEntity.Cantidad;
                DetallePedido.Add(detalleEntity);
            }          

            return DetallePedido;
        }

        /// <summary>
        /// tiene un atributo "ViewValidator" y recibe un objeto de entidad de detalle. Este método realiza diferentes acciones según el estado del objeto de entidad. Si está en "Agregado", busca el producto correspondiente a través de su nombre y agrega un nuevo detalle a través del servicio de detalle, con un registro de log que indica los detalles agregados. Si está en "Modificado", actualiza el detalle correspondiente a través del servicio de detalle. Si está en "Eliminado", busca el detalle correspondiente por nombre de producto, Id_Pedido y Tipo, lo elimina a través del servicio de detalle y registra los detalles eliminados en un registro de log.
        /// </summary>
        /// <param name="detalleEntity"></param>
        [ViewValidator]
        public void GuardarCambios(DetalleEntity detalleEntity)
        {
            try
            {
                //Convierto el objeto de vista al objeto de transporte DTO
                var detalleDTO = _mapper.Map<DetalleModel>(detalleEntity);

                switch (detalleEntity.State)
                {
                    case EntityState.Added:
                        var producto = _productoService.Get(x => x.Nombre == detalleEntity.Nombre).FirstOrDefault();
                        detalleDTO.Id_Producto = producto.Id_Producto;
                        _detalleService.AgergarADetalle(detalleDTO);
                        LoggerManager.Info($"Se agregó {detalleDTO.Cantidad} x {detalleDTO.Producto} al pedido {detalleDTO.Id_Pedido}");
                        break;

                    case EntityState.Modified:
                        _detalleService.ActualizarDetalle(detalleDTO);
                        break;

                    case EntityState.Deleted:

                        detalleDTO = _detalleService.Get(x => x.Producto.Nombre == detalleEntity.Nombre && x.Id_Pedido == detalleEntity.Id_Pedido && x.Tipo == detalleEntity.Tipo).FirstOrDefault();
                        detalleDTO = _detalleService.GetById(detalleDTO.Id_Detalle);
                        
                        //clienteDTO.Nombre = clienteEntity.Nombre;
                        //clienteDTO.MailContacto = clienteEntity.MailContacto;
                        //clienteDTO.Dirección = clienteEntity.Dirección;
                        //clienteDTO.DNI = clienteEntity.DNI;
                        //detalleDTO.Active = false;
                        _detalleService.EliminarDeDetalle(detalleDTO);
                        //CustomerService.Current.Remove(customerDTO.IdCustomer);
                        LoggerManager.Info($"Se eliminó {detalleDTO.Cantidad} x {detalleDTO.Producto} del pedido {detalleDTO.Id_Pedido}");
                        break;
                }

                detalleEntity.State = EntityState.Unchanged;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// recibe el Id del pedido y el nombre del producto y devuelve un objeto de entidad de detalle correspondiente. Utiliza el servicio de detalle para obtener detalles de pedido a través de una consulta que filtra por nombre de producto e Id_Pedido, convierte el detalle de modelo en detalle de entidad y lo devuelve.
        /// </summary>
        /// <param name="pedidoId"></param>
        /// <param name="nombreProducto"></param>
        /// <returns></returns>
        public DetalleEntity ObtenerDetalleId(int pedidoId, string nombreProducto)
        {
            var detalle = _mapper.Map<DetalleEntity>(_detalleService.Get(x => x.Producto.Nombre == nombreProducto && x.Id_Pedido == pedidoId).FirstOrDefault());
            return detalle;
        }
    }
}
