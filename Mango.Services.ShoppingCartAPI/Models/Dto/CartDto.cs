namespace Mango.Services.ShoppingCartAPI.Models.Dto

{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; }
        public IEnumerable<CartDetailsDto> CartDetails { get; set; }

        //This will not be an entity model ...plus is more like a container for our cart system..
    }
}
