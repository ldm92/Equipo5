﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Equipo5.Entities.Models
{
    public class Category : IdentityBase
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}