using AutoMapper;

using Domain.Entities;
using Domain.Models;

using SL.Domain.Entities;
using SL.Domain.Models;

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
            CreateMap<PermisoEntity, PermisoModel>().ReverseMap();
        }
    }
}
