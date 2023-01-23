using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")] //if not the name of the controller is used by default which is ProductAPI
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private readonly IProductRespository _productRespository;

        //Inject Dependencies into the Controller for access..
        public ProductAPIController(IProductRespository productRespository)
        {
            _productRespository = productRespository;
            this._response = new ResponseDto();   //instantiate new object of the ResponseDto class..
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _productRespository.GetProducts();
                _response.IsSuccess = true;
                _response.Result = productDtos; 
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]  // /api/ProductAPI/1
        
        public async Task<object> Get(int id)
        {

            try
            {
                ProductDto productDto = await _productRespository.GetProductById(id);
                _response.IsSuccess = true;
                _response.Result = productDto;
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response; 
        }

        [HttpPost]
        [Authorize]
        public async Task<object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto model = await _productRespository.CreateUpdateProduct(productDto);
                _response.IsSuccess = true;
                _response.Result = model;
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false; 
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response; 
        }

        [HttpPut]
        [Authorize]
        public async Task<object> Put([FromBody] ProductDto productDto)
        {
            //var accessToken = await HttpContext.GetTokenAsync("access_token");
            try
            {
                ProductDto model = await _productRespository.CreateUpdateProduct(productDto);
                _response.IsSuccess = true;
                _response.Result = model;
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false; 
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response; 
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        [Route("{id}")]
        
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _productRespository.DeleteProduct(id);
                _response.IsSuccess = true;
                _response.Result = isSuccess;   //Result here will be boolean value ...
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }







    }
}
