using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    /// <summary>
    /// Product items represents the acutal piece of a thing, => Exp:: Chicken, flower, fries..
    /// Fries may even come with weigh (lb).
    /// </summary>
    public class ProductItem
    {
        [Key]
        public int ProductItemId { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public DateTime ExperationDate { get; set; }
        
        public List<Product>? ProductReferances { get; set; }

    }
}
