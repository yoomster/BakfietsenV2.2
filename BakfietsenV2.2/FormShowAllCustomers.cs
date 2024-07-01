using BakfietsenV2._2.DataAccess;
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
    public partial class FormShowAllCustomers : Form
    {
        private readonly Booking _booking;
        private readonly Company _vanDerBrinckes;


        public FormShowAllCustomers(Company vanDerBrinckes, Booking booking)
        {
            _booking = booking;
            _vanDerBrinckes = vanDerBrinckes;

            InitializeComponent();
        }

        private void FormShowAllCustomers_Load(object sender, EventArgs e)
        {
            ReadAll();
        }

        private void ReadAll()
        {
            using (var db = new RentalContext())
            {
                var records = db.Customers.ToList();

                dataGridViewCustomers.DataSource = records;

                dataGridViewCustomers.Columns["FirstName"].HeaderText = "Voornaam";
                dataGridViewCustomers.Columns["LastName"].HeaderText = "Achternaam";
                dataGridViewCustomers.Columns["Id"].Visible = false;
                dataGridViewCustomers.Columns["Zipcode"].Visible = false;
                dataGridViewCustomers.Columns["City"].Visible = false;
            }
        }

        private void SelectCustomer()
        {
            var selectedRow = dataGridViewCustomers.SelectedRows[0];
            var selectedCustomer = selectedRow.DataBoundItem as Customer;

            _booking.Customer = selectedCustomer;
            this.Close();
        }

        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                SelectCustomer();
                this.Close();
            }
            else
                MessageBox.Show("Geen klant geselecteerd.");
        }
    }
}
