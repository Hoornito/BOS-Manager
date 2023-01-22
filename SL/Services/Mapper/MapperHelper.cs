using AutoMapper;

using Domain.Entities;
using Domain.Models;

using SL.Domain.Entities;
using SL.Domain.Models;

using System;

namespace SL.Services.Mapper
{
    public class MapperHelper : Profile
    {
        public MapperHelper()
        {
            CreateMap<ClienteEntity, ClienteModel>().ReverseMap();
            CreateMap<PedidoEntity, PedidoModel>().ReverseMap()
                .ForMember(dest => dest.NombreCliente, opts => opts.MapFrom(src => src.Cliente.Nombre));
            /*                .ForMember(dest => dest.Id_Cliente, opts => opts.Ignore())*/
            CreateMap<ProductoEntity, ProductoModel>().ReverseMap();
            CreateMap<DetalleEntity, DetalleModel>().ReverseMap();
            CreateMap<FacturaEntity, FacturaModel>().ReverseMap();
            CreateMap<Permiso_PermisoEntity, Permiso_PermisoModel>().ReverseMap();
            CreateMap<PatenteEntity, PermisoModel>().ReverseMap();
            CreateMap<Permiso_PermisoModel, FamiliaEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id_permiso_padre))
                .ReverseMap(); 
        }
        
    }
}
