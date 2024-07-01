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
        public double TotalCostAccessoires { get; set; }
        public double PriceAccessoires { get; set; }
        public double CostBike { get; set; } = 20; 
        public double TotalRentalCost { get; set; }
    }
}
