using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder.FluentBuilder
{
    internal class Customer
    {
        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public int CustomerId { get;  }
        public string CustomerName { get;  } 

    }
}
