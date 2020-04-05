using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Product : IEntity
    {
        
        public string Name { get; set; }
        public string Descroption { get; set; }
        public decimal Price { get; set; }
        //public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}