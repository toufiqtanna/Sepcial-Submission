using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Special_Submission.Controllers;
using Special_Submission.Models;

namespace Special_Submission
{
    public partial class Aeroplane : Form
    {
        public Aeroplane()
        {
            InitializeComponent();
            dataGridView1.DataSource=AeroplaneControllers.GetAllUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var aeroplanedetail = new
            {
                PlaneID = tBPlaneID.Text,
                PlaneName = tBPlaneName.Text,
                FlightNumber = tBFlightNumber.Text,
                Source = tBSource.Text,
                Destination = tBDestination.Text };

            bool r = AeroplaneControllers.AddUser(aeroplanedetail);
            if (r)
            {
                tBPlaneID.Text = "";
                tBPlaneName.Text = "";
                tBFlightNumber.Text = "";
                tBFlightNumber.Text = "";
                tBSource.Text = "";
                tBDestination.Text = "";

                MessageBox.Show("Aeroplanedetail Added");
                dataGridView1.DataSource = AeroplaneControllers.GetAllUsers();
            }
            else
            {
                MessageBox.Show("Aeroplanedetail not Added");
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
