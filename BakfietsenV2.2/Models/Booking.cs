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
    }
}
