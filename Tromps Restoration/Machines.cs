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
    public partial class Machines : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public static string selectedItem = "";
        public Machines()
        {
            InitializeComponent();
        }

        private void Machines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trompsDataSet.Machines' table. You can move, or remove it, as needed.
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from [Machines]", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridMachines.DataSource = dt;
            con.Close();

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

        private void BtnRunReport_Click(object sender, EventArgs e)
        {
            var selectedMachine = dataGridMachines.SelectedCells;
            selectedItem = selectedMachine[0].Value.ToString();
            var reportType = comboReport.SelectedItem;

            switch (reportType)
            {
                case "Hire":
                    MachineHires machineHires = new MachineHires();
                    machineHires.Show();
                    break;
                case "Service":
                    MachineServices machineServices = new MachineServices();
                    machineServices.Show();
                    break;
                case "Dual":
                    
                    break;
            }

            

            
        }
    }
}
