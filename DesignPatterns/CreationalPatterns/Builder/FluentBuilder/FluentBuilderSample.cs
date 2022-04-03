using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.FluentBuilder
{
    internal class FluentBuilderSample
    {
        public void Run()
        {
            Customer customer = new Customer(1, "Michael");
            Product product = new Product("お菓子", 280);

            Order order = new OrderBuilder()
                .SetCustomer(customer)
                .SetProduct(product)
                .SetQuantity(3)
                .Build();

            Console.WriteLine($"FluentBuilderSample: Customer:{order.Customer.CustomerName} Product:{order.Product.ProductName}, Invoice:{order.Sum}");
        }
    }

}
