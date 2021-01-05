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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var aeroplanedetail = new
            {
                PlaneName = tBPlaneName.Text,
            FlightNumber = tBFlightNumber.Text,
            Source = tBSource.Text,
            Destination = tBDestination.Text };

            bool r = AeroplaneControllers.AddUser(aeroplanedetail);
            if (r)
            {
                MessageBox.Show("Aeroplanedetail Added");
            }
            else
            {
                MessageBox.Show("Aeroplanedetail not Added");
            }
        }
    
    }
}
