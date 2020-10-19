using System;

namespace TClients.CustomerInteraction
{
    public class CustomerService
    {
        public CustomerService()
        {
        }

        public CustomerService(int customerId, string title, int price, DateTime date, string status)
        {
            CustomerId = customerId;
            Title = title;
            Price = price;
            Date = date;
            Status = status;
        }

        public int CustomerId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}