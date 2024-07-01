using BakfietsenV2._2.DataAccess;
using BakfietsenV2._2.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakfietsenV2._2
{
    public partial class FormAddNewBooking : Form
    {
        private readonly Company _vanDerBrinckes;
        private readonly Booking _booking;

        public FormAddNewBooking(Company vanDerBinckes, Booking booking)
        {
            _vanDerBrinckes = vanDerBinckes;
            _booking = booking;

            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            CreateNewBooking();
        }

        private void CreateNewBooking()
        {
            throw new NotImplementedException();

            var b = new Booking
            {

            };

            using (var db = new RentalContext())
            {
                db.Bookings.Add(b);
                db.SaveChanges();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;
            ReturnDatePicker.MinDate = StartDatePicker.Value.AddDays(1);

            _booking.CalculateTotalNumberOfRentDays(StartDatePicker.Value, ReturnDatePicker.Value);

            if (_booking.ValidDate == true)
            {
                totalDaysLabel.Text = $"Totaal aantal dagen is {_booking.RentDayCount}";
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }
        }

        private void ReturnDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _booking.CalculateTotalNumberOfRentDays(StartDatePicker.Value, ReturnDatePicker.Value);

            if (_booking.ValidDate == true)
            {
                totalDaysLabel.Text = $"Totaal aantal dagen is {_booking.RentDayCount}";
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }
        }

        private void ChoiceOfBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected bike needs to be put inside the booking.Bike

            string bikeChoice = ChoiceOfBikes.Text;

            //get selected bike
            //get price from select
            //add price to the booking

            if (bikeChoice == "Urban Arrow 4 pers. € 20")
                _booking.CostBike = 20;
            else if (bikeChoice == "Urban Arrow 6 pers. € 30")
                _booking.CostBike = 30;
            else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
                _booking.CostBike = 40;
            else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
                _booking.CostBike = 60;
        }

        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            var FormAllCustomers = new FormShowAllCustomers(_vanDerBrinckes, _booking);
            FormAllCustomers.Show();
        }
    }
}

