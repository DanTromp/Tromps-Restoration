using System;
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
    public partial class MachineServices : Form
    {
        public MachineServices()
        {
            InitializeComponent();
        }

        private void MachinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machines machines = new Machines();
            this.Hide();
            machines.Show();
        }

        private void MachineHiresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MachineHires machineHires = new MachineHires();
            this.Hide();
            machineHires.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            this.Hide();
            customers.Show();
        }
    }
}
