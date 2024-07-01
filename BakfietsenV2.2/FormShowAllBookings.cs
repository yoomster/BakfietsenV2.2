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
    public partial class FormShowAllBookings : Form
    {
        private readonly Company _vanDerBrinckes;

        public FormShowAllBookings(Company VanDerBrinckes)
        {
            VanDerBrinckes = _vanDerBrinckes;
            InitializeComponent();
        }

        private void FormShowAllBookings_Load(object sender, EventArgs e)
        {
            ReadAll();
        }

        private void ReadAll()
        {
            using (var db = new RentalContext())
            {
                var records = db.Bookings.ToList();

                dataGridBookings.DataSource = records;

                dataGridBookings.Columns["RentDayCount"].HeaderText = "Aantal huur dagen";
                dataGridBookings.Columns["TotalRentalCost"].HeaderText = "Totale kosten";

                dataGridBookings.Columns["ValidDate"].Visible = false;
                dataGridBookings.Columns["CostAccessoires"].Visible = false;
                dataGridBookings.Columns["CostBike"].Visible = false;
            }
        }
    }
}
