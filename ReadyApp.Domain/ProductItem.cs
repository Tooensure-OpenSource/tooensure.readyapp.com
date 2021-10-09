using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class ProductItem
    {
        [Key]
        public int ProductItemId { get; set; }
        public string? Name { get; set; }
    }
}
