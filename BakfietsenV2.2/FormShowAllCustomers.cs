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
        private readonly Company _vanDerBrinckes;

        public FormShowAllCustomers(Company vanDerBinckes)
        {
            _vanDerBrinckes = vanDerBinckes;
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

                dataGridViewCustomers.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewCustomers.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewCustomers.Columns["Id"].Visible = false;
                dataGridViewCustomers.Columns["Zipcode"].Visible = false;
                dataGridViewCustomers.Columns["City"].Visible = false;
            }
        }


    }
}
