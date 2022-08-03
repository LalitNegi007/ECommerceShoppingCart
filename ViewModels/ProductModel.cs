using ECommerceShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceShoppingCart.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }
        public List<Product> findAll()
        {
            _products = new List<Product>
            {
                new Product()
                {
                    Id = "1",
                    Name = "Flower1",
                    Photo = "thumb1.jpg",
                    Price = 2.80
                },
                new Product()
                {
                    Id = "2",
                    Name = "Flower2",
                    Photo = "thumb2.jpg",
                    Price = 3.80
                },
                new Product()
                {
                    Id = "3",
                    Name = "Flower3",
                    Photo = "thumb3.jpg",
                    Price = 4.80
                }
            };
            return _products;
        }

        public Product find(string id)
        {
            List<Product> products = findAll();
            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;
        }
    }

    }
