using System.Collections.Generic;

namespace Equipo5.Entities.Models
{
    public class Category : IdentityBase
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}