using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommoEntities;

namespace DataStore
{
    public class Customers : List<Customer>
    {
        public Customers()
        {
            Add(new Customer() {CustomerId=101,CustomerName="Customer 1",Email="c1@cust.com" });
            Add(new Customer() { CustomerId = 102, CustomerName = "Customer 2", Email = "c2@cust.com" });
            Add(new Customer() { CustomerId = 103, CustomerName = "Customer 3", Email = "c3@cust.com" });
            Add(new Customer() { CustomerId = 104, CustomerName = "Customer 4", Email = "c4@cust.com" });
            Add(new Customer() { CustomerId = 104, CustomerName = "Customer 4", Email = "c4@cust.com" });
        }
    }
}
    