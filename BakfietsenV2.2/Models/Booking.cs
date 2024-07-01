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
    }
}
