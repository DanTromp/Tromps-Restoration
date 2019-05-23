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
    public partial class MachineReports : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public static string valuePassed = "";

        public MachineReports()
        {
            InitializeComponent();
        }

        private void MachineHires_Load(object sender, EventArgs e)
        {
            valuePassed = Machines.selectedItem;
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select [Date Booked Out],[Date Booked In],[Invoice Number],[Cost Per Day],[Total Cost] from [Hire Orders] where [Machine Number] = " + int.Parse(valuePassed), con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridHires.DataSource = dt;

            DataView view = new DataView(dt);

            con.Close();

            decimal totalMade = 0;

            foreach (DataRowView row in view)
            {
                totalMade += decimal.Parse(row["Total Cost"].ToString());
            }

            valuePassed = Machines.selectedItem;
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select [Day Booked Out],[Day Booked In],[Cost of Service] from [Machine Services] where [Machine Number] = '" + int.Parse(valuePassed) + "'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridServices.DataSource = dt;
            view = new DataView(dt);
            con.Close();

            foreach (DataRowView row in view)
            {
                totalMade -= decimal.Parse(row["Cost of Service"].ToString());
            }

            lblTotalEarned.Text = "R " + String.Format("{0:.00}", totalMade);
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
    }
}
