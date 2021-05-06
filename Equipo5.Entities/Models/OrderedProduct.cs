namespace Equipo5.Entities.Models
{
    public class OrderedProduct : IdentityBase
    {
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual CustomerOrder CustomerOrder { get; set; }


    }
}