using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        public virtual CartHeaderDto CartHeader { get; set; }
        public int ProductId { get; set; }
        public virtual ProductDto Product { get; set; }
        public int Count { get; set; }


        //N:B the way I relate the tables here is obsolete..but I leave it intentionally to see the behaviour..
        //1:M / M:1 relationship...
    }
}
