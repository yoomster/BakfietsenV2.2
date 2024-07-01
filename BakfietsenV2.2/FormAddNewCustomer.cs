using BakfietsenV2._2.DataAccess;
using BakfietsenV2._2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakfietsenV2._2
{
    public partial class FormAddNewCustomer : Form
    {
        private readonly Company _vanDerBrinckes;

        public FormAddNewCustomer(Company vanDerBinckes)
        {
                _vanDerBrinckes = vanDerBinckes;

                InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CreateNewCustomer();

            this.Close();
        }

        private void CreateNewCustomer()
        {
            var c = new Customer
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Address = textBoxAddress.Text,
                HouseNumber = textBoxHouseNumber.Text,
                Zipcode = textBoxHouseNumber.Text,
                City = textBoxCity.Text,
                Comments = textBoxComments.Text
            };

            using (var db = new RentalContext())
            {
                db.Customers.Add(c);
                db.SaveChanges();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
