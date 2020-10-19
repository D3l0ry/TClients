using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TClients.CustomerInteraction
{
    [Serializable]
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int id, string firstName, string midleName, string lastName,string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            MidleName = midleName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastVisit { get; set; }
    }
}