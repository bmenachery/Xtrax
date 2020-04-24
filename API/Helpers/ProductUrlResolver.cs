using API.Dtos;
using AutoMapper;
using Core.Entities;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _config;
        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
    }
    public class FirmProductUrlResolver : IValueResolver<FirmProduct, FirmProductToReturnDto, string>
    {
        private readonly IConfiguration _config;
        public FirmProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(FirmProduct source, FirmProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Product.PictureUrl))
            {
                return _config["ApiUrl"] + source.Product.PictureUrl;
            }

            return null;
        }
    }
}