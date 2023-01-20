namespace Mango.Services.ShoppingCartAPI.Models
{
    public class Cart
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetails> CartDetails { get; set; }

        //This will not be an entity model ...plus is more like a container for our cart system..
    }
}
