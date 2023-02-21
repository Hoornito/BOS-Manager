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
    public class ProductoController : IProductoController
    {
        IProductoService _productoService;
        IMapper _mapper;
        public ProductoController(IProductoService productoService, IMapper mapper)
        {
            _productoService = productoService;
            _mapper = mapper;
        }

        public List<ProductoEntity> GetAll()
        {
            //obtengo una lista de todos los productos
            var listaProductoModel = _productoService.GetAll().ToList();

            var listaProducto = _mapper.Map<List<ProductoEntity>>(listaProductoModel);

            return listaProducto;
        }

        public ProductoEntity GetProducto(string Nombre)
        {
            //obtengo el producto por su nombre
            var producto = _mapper.Map<ProductoEntity>(_productoService.Get(x => x.Nombre == Nombre).FirstOrDefault());
            return producto;
        }
        

        [ViewValidator]
        public void GuardarCambios(ProductoEntity productoEntity)
        {
            //dependiendo del estado - ABM
            try
            {
                //Convierto el objeto de vista al objeto de transporte DTO
                var productoDTO = _mapper.Map<ProductoModel>(productoEntity);

                switch (productoEntity.State)
                {
                    case EntityState.Added:
                        _productoService.AgregarProducto(productoDTO);
                        
                        LoggerManager.Info($"El producto {productoDTO.Nombre} fue añadido. Precio: {productoDTO.PrecioUnidad} Cantidad inicial: {productoDTO.Cantidad}");
                        break;

                    case EntityState.Modified:

                        productoDTO = _productoService.Get(x => x.Nombre == productoDTO.Nombre).FirstOrDefault();
                        //obtengo el id porque el get de entity no me trae el ID - para poder actualizar el objeto correcto
                        productoDTO = _productoService.GetById(productoDTO.Id_Producto);
                        productoDTO.Nombre = productoEntity.Nombre;
                        productoDTO.Descripción = productoEntity.Descripción;
                        productoDTO.Cantidad += productoEntity.Cantidad;
                        productoDTO.PrecioUnidad = productoEntity.PrecioUnidad;
                        _productoService.ActualizarProducto(productoDTO);
                        
                        LoggerManager.Info($"El producto {productoDTO.Nombre} fue actualizado. Precio: ${productoDTO.PrecioUnidad}. Cantidad: {productoDTO.Cantidad}");
                        break;

                    case EntityState.Deleted:

                        productoDTO = _productoService.Get(x => x.Nombre == productoDTO.Nombre).FirstOrDefault();
                        //obtengo el id porque el get de entity no me trae el ID - para poder actualizar el objeto correcto
                        productoDTO = _productoService.GetById(productoDTO.Id_Producto);

                        #region por si deseo hacer solo borrado lógico
                        productoDTO.Nombre = productoEntity.Nombre;
                        productoDTO.Descripción = productoEntity.Descripción;
                        productoDTO.Cantidad = productoEntity.Cantidad;
                        productoDTO.PrecioUnidad = productoEntity.PrecioUnidad;

                        productoDTO.Active = false;
                        _productoService.ActualizarProducto(productoDTO);

                        LoggerManager.Info($"El producto {productoDTO.Nombre} fue eliminado.");
                        #endregion

                        #region por si deseo Eliminar por completo el producto de mi base
                        //_productoService.EliminarProducto(productoDTO);
                        #endregion

                        break;
                }

                productoEntity.State = EntityState.Unchanged;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
