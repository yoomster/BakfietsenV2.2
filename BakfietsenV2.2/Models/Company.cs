using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakfietsenV2._2.Models
{
    public class Company
    {
        public List<Booking> AllBookings { get; set; } = new();
        public List<Customer> AllCustomers { get; set; } = new();
        public List<Accessoire> AllAccessoires { get; set; } = new();
        public List<Bike> AllBikes { get; set; } = new();
        public List<Employee> AllEmployees { get; set; } = new();

    }
}
