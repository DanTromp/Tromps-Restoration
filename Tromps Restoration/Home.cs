﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tromps_Restoration
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void HealthSafteyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the new form for editing and viewing
            Customers customers = new Customers();
            this.Hide();
            customers.Show();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MachineHireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machines machines = new Machines();
            this.Hide();
            machines.Show();
        }

        private void BtnHiresAndServices_Click(object sender, EventArgs e)
        {

        }
    }
}
