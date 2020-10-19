using System.Collections.Generic;

namespace TClients.CustomerInteraction
{
    internal sealed class CustomerManager
    {
        public static List<Customer> Customers = new List<Customer>();
        public static List<CustomerService> CustomerServices = new List<CustomerService>();
    }
}