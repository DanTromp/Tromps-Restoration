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
    public partial class Customers : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;        
        SqlCommand com;

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trompsDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.trompsDataSet.Customers);

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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);

            string CommandText = (@"DELETE FROM [Customers] WHERE [ID Number] = '" + dataGridCustomers.SelectedCells[2].Value.ToString() + "'");

            com = new SqlCommand(CommandText, con);

            var confirmResult = MessageBox.Show("Are you sure to delete this customer ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    Customers.ActiveForm.Refresh();
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Error: " + exx.Message, "Attempt To Remove Customer");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }

            dataGridCustomers.Refresh();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();

            dataGridCustomers.Refresh();
        }
    }
}
