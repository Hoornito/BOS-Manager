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

        public List<DetalleEntity> ObtenerDetalle(PedidoEntity pedido)
        {
            
            List<DetalleEntity> DetallePedido = new List<DetalleEntity>();
            List<DetalleModel> detalle = _detalleService.Get(x => x.Id_Pedido == pedido.Id_Pedido, includeProperties: "Producto").ToList();

            foreach (var item in detalle)
            {
                DetalleEntity detalleEntity = new DetalleEntity();
                detalleEntity.Nombre = item.Producto.Nombre;
                detalleEntity.PrecioUnidad = item.Producto.PrecioUnidad;
                detalleEntity.Cantidad = item.Cantidad;
                detalleEntity.SubTotal = detalleEntity.PrecioUnidad * detalleEntity.Cantidad;
                DetallePedido.Add(detalleEntity);
            }          

            return DetallePedido;
        }

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

                        detalleDTO = _detalleService.Get(x => x.Producto.Nombre == detalleEntity.Nombre && x.Id_Pedido == detalleEntity.Id_Pedido).FirstOrDefault();
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

        public DetalleEntity ObtenerDetalleId(int pedidoId, string nombreProducto)
        {
            var detalle = _mapper.Map<DetalleEntity>(_detalleService.Get(x => x.Producto.Nombre == nombreProducto && x.Id_Pedido == pedidoId).FirstOrDefault());
            return detalle;
        }
    }
}
