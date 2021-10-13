using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Product
    {
        public Guid ProductId { get; private set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public decimal PriceTag { get; set; }
        public List<ProductItem>? ProductItems { get; set; }

        /// <summary>
        /// On product create/initulization, also create/initulize list of product items
        /// </summary>
        public Product()
        {
            ProductItems = new List<ProductItem>();
        }
        /// <summary>
        /// Set product with pre-built product items
        /// </summary>
        /// <param name="productItems"></param>
        public Product(List<ProductItem> productItems)
        {
            ProductItems = productItems; ;
        }
    }
}
