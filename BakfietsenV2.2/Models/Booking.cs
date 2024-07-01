using BakfietsenV2._2.DataAccess;
using BakfietsenV2._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakfietsenV2._2.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BikeId { get; set; }
        public Bike Bike { get; set; }
        public List<Accessoire> Accessoires { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        public int RentDayCount { get; set; } = 0;
        public bool ValidDate { get; set; } = false;
        public double CostAccessoires { get; set; }
        public double CostBike { get; set; } = 20; 
        public double TotalRentalCost { get; set; }

        public void CalculateTotalNumberOfRentDays(DateTime start, DateTime end)
        {
            DateTime startDate = start;
            DateTime returnDate = end;

            TimeSpan difference = returnDate - startDate;

            RentDayCount = (int)Math.Ceiling(difference.TotalDays);

            if (RentDayCount <= 0)
            {
                MessageBox.Show("Error, foutieve invoer");
                ValidDate = false;
            }
            else
            {
                ValidDate = true;
            }
        }

        public void CalculateCostsBike() 
        {
            CostBike *= RentDayCount;
        }

        public void CalculateCostsAccessoires() 
        {
            CostAccessoires*= RentDayCount;
        }

        public void CalculateTotalCost()
        {
            CalculateCostsBike();
            CalculateCostsAccessoires();

            TotalRentalCost = CostAccessoires + CostBike;
        }


        public void CreateNewBike()
        {
            var b = new Bike
            {
                Name = "Urban Arrow 4 pers.",
                Price = 20,
                Available = true
            };
            var b2 = new Bike
            {
                Name = "Urban Arrow 6 pers.",
                Price = 30,
                Available = true
            };
            var b3 = new Bike
            {
                Name = "Urban Arrow 4 pers. E-Bike",
                Price = 40,
                Available = true
            };
            var b4 = new Bike
            {
                Name = "Urban Arrow 6 pers. E-Bike",
                Price = 60,
                Available = true
            };


            using (var db = new RentalContext())
            {
                db.Bikes.Add(b);
                db.Bikes.Add(b2);
                db.Bikes.Add(b3);
                db.Bikes.Add(b4);


                db.SaveChanges();
            }
        }


        public void CreateNewAccessoire()
        {
            var a = new Accessoire
            {
                Name = "Telefoonhouder",
                Price = 5,
            }; 
            var a2 = new Accessoire
            {
                Name = "Helm",
                Price = 10,
            }; 
            var a3 = new Accessoire
            {
                Name = "Regenhoes",
                Price = 15,
            };
            var a4 = new Accessoire
            {
                Name = "Kinderstoeltje",
                Price = 20,
            };

            using (var db = new RentalContext())
            {
                db.Accessoires.Add(a);
                db.Accessoires.Add(a2);
                db.Accessoires.Add(a3);
                db.Accessoires.Add(a4);

                db.SaveChanges();
            }
        }
    }
}
