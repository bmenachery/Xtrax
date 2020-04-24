using System.Linq;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
             .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
             .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
             .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());

            CreateMap<FirmProduct, FirmProductToReturnDto>()
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.ProductDescription, o => o.MapFrom(s => s.Product.Description))
                .ForMember(d => d.ProductPrice, o => o.MapFrom(s => s.Product.Price))
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.Product.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.Product.ProductType.Name))
                .ForMember(d => d.ProductUrl, o => o.MapFrom<FirmProductUrlResolver>());






        }
    }
}