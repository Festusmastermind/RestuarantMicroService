﻿using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService: IBaseService
    {
        //using the Generic Respository Approach ...and T is a polymorphic object..
        Task<T> GetAllProductAsync<T>(string token);
        Task<T> GetProductByIdAsync<T>(int id, string token);

        Task<T> CreateProductAsync<T>(ProductDto productDto, string token);

        Task<T> UpdateProductAsync<T>(ProductDto productDto, string token);

        Task<T> DeleteProductAsync<T>(int id, string token);
    }
}
