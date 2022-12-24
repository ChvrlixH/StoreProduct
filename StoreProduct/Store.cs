using StoreProduct.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct
{
    internal class Store
    {
        private Product[] _products = new Product[0];
        public Product[] Products
        {
            get
            {
                return _products;
            }
        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public void RemoveProductByNo(int no)
        {
            Product[] newPro = new Product[0];
            foreach (var item in _products)
            {
                if (item.No != no)
                {
                    Array.Resize(ref newPro, newPro.Length + 1);
                    newPro[newPro.Length - 1] = item;
                }
            }
            _products = newPro;
        }


        public Product[] FilterProductsByType(ProductType type)
        {
            Product[] filteredType = new Product[0];
            foreach (var item in _products)
            {

                if (item.Type == type)
                {
                    Array.Resize(ref filteredType, filteredType.Length + 1);
                    filteredType[filteredType.Length - 1] = item;
                }
            }
            return filteredType;
        }

        public Product[] FilterProductByName(string name)
        {
            Product[] filteredName = new Product[0];
            foreach (var item in _products)
            {

                if (item.Name == name)
                {
                    Array.Resize(ref filteredName, filteredName.Length + 1);
                    filteredName[filteredName.Length - 1] = item;
                }
            }
            return filteredName;
        }

        public void GetInfo()
        {
            foreach (var item in _products)
            {
                Console.WriteLine($"Adi - {item.Name}  Qiymeti - {item.Price} manat  Nomresi - {item.No}  Type {item.Type}");
            }
        }
    }
}
