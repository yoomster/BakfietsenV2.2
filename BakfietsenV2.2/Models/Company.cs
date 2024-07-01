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


        //instead of this, add to DB!
        //public Company()
        //{
        //    AllAccessoires.Add(new Accessoire{ Name = "Telefoonhouder", Price = 5 });
        //    AllAccessoires.Add(new Accessoire{ Name = "Helm", Price = 10 });
        //    AllAccessoires.Add(new Accessoire{ Name = "Regenhoes", Price = 15 });
        //    AllAccessoires.Add(new Accessoire{ Name = "Babystoel", Price = 20 });


        //    AllBikes.Add(new Bike { Name = "Urban Arrow 4 pers", Price = 20, Available = true });
        //    AllBikes.Add(new Bike { Name = "Urban Arrow 6 pers", Price = 30, Available = true });
        //    AllBikes.Add(new Bike { Name = "Urban Arrow 4 pers. E-Bike", Price = 40 , Available = true });
        //    AllBikes.Add(new Bike { Name = "Urban Arrow 6 pers. E-Bike", Price = 60 , Available = true });
        //}

        public void AddToDB()
        {

        }
    }
}
