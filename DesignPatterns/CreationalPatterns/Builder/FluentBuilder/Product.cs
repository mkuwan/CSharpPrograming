using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.FluentBuilder
{
    internal class Product
    {
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get;  }
        public decimal Price { get;  }
    }
}
