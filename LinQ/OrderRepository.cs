using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public static class OrderRepository
    {
        public static List<Customer> GetCustomers()
        {
            return new List<Customer> 
            {
                new Customer { Id = 1, Name = "John Doe" },
                new Customer { Id = 2, Name = "Jane Smith" },
                new Customer { Id = 3, Name = "Samuel Jackson" }
            };
        }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, ProductName = "Apple gift", Total = 54.24M },
                new Order { OrderId = 2, CustomerId = 2, ProductName = "Apple Light Connector", Total = 10.25M },
                new Order { OrderId = 3, CustomerId = 3, ProductName = "USB Cable", Total = 5.25M },
                new Order { OrderId = 4, CustomerId = 1, ProductName = "IPhone 13", Total = 520.25M },
                new Order { OrderId = 5, CustomerId = 2, ProductName = "Macbook Air Pro", Total = 1520.25M },
                new Order { OrderId = 6, CustomerId = 3, ProductName = "Macbook Pro", Total = 2520.25M },
            };
        }
    }
}
