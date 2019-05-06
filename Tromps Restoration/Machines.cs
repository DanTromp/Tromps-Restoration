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
    public partial class Machines : Form
    {
        public Machines()
        {
            InitializeComponent();
        }

        private void MachineHire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trompsDataSet.Machines' table. You can move, or remove it, as needed.
            this.machinesTableAdapter.Fill(this.trompsDataSet.Machines);

        }

        private void MachineServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MachineServices machineServices = new MachineServices();
            this.Hide();
            machineServices.Show();
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

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
