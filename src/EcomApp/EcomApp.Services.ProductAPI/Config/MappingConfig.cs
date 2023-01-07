using AutoMapper;
using EcomApp.Services.ProductAPI.Dtos;
using EcomApp.Services.ProductAPI.Models;

namespace EcomApp.Services.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
