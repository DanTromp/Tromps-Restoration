using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tromps_Restoration
{
    public partial class MachineHires : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public MachineHires()
        {
            InitializeComponent();
        }

        private void MachineHires_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from [Hire Orders]", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridHires.DataSource = dt;
            con.Close();
        }

        private void txtMachineName_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from tbl_Employee where [Machine Name] like '" + txtMachineName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridHires.DataSource = dt;
            con.Close();
        }

        private void MachinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machines machines = new Machines();
            this.Hide();
            machines.Show();
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
    }
}
