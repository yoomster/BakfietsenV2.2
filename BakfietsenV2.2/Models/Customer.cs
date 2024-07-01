using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakfietsenV2._2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; } //INT?
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string? Comments { get; set; }
    }
}
