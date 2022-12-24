using StoreProduct.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct
{
    internal class Product
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }
        public Product()
        {
            _no++;
            No = _no;
        }
    }
}
