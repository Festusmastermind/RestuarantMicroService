using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        //this is used to Map the Dtos to the Model...I still don't know if its necessary though ..
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>(); //we can also use .reverseMap but instead its implemeted in two lines
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig; 
        }
    }
}
