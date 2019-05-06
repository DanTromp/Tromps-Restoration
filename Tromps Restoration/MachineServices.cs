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
    public partial class MachineServices : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public static string valuePassed = "";

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

        private void MachineServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trompsDataSet.Machine_Services' table. You can move, or remove it, as needed.
            valuePassed = Machines.selectedItem;
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from [Machine Services] where [Machine ID] = '" + valuePassed + "'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridServices.DataSource = dt;
            con.Close();
        }
    }
}
