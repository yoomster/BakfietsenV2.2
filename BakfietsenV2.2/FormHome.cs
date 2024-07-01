using BakfietsenV2._2.Models;
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
    public partial class FormHome : Form
    {
        private Company _vanDerBrinckes = new Company();
        private Booking _booking = new Booking();


        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            var FormNewCustomer = new FormAddNewCustomer(_vanDerBrinckes);
            FormNewCustomer.Show();
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            var FormNewBooking = new FormAddNewBooking(_vanDerBrinckes, _booking);
            FormNewBooking.Show();
        }



        private void buttonAllCustomers_Click(object sender, EventArgs e)
        {
            var FormAllCustomers = new FormShowAllCustomers(_vanDerBrinckes, _booking);
            FormAllCustomers.Show();
        }

        private void buttonAllBookings_Click(object sender, EventArgs e)
        {
            var FormAllBookings = new FormShowAllBookings(_vanDerBrinckes);
            FormAllBookings.Show();
        }
    }
}
