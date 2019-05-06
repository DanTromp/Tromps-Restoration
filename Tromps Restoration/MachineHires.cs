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
        public static string valuePassed = "";

        public MachineHires()
        {
            InitializeComponent();
        }

        private void MachineHires_Load(object sender, EventArgs e)
        {
            valuePassed = Machines.selectedItem;
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from [Hire Orders] where [Machine ID] = '" + valuePassed + "'", con);
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

        private void MachineHires_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trompsDataSet.Hire_Orders' table. You can move, or remove it, as needed.
            this.hire_OrdersTableAdapter.Fill(this.trompsDataSet.Hire_Orders);

        }
    }
}
