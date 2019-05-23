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
    public partial class NewMachine : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand com = new SqlCommand();

        public NewMachine()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            bool valuesFilled = true;
            con = new SqlConnection(cs);
            con.Open();            

            if (txtMachineNo.Text == "")
            {
                txtMachineNo.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (txtMachineName.Text == "")
            {
                txtMachineName.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (txtClassification.Text == "")
            {
                txtClassification.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (txtSerial.Text == "")
            {
                txtSerial.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (!valuesFilled)
            {
                MessageBox.Show("Please complete all the red fields.");
                return;
            }
            else
            {
                string CommandText = (@"INSERT INTO [Machines] ([Machine Number], [Machine Name], [Machine Classification], [Machine Serial Number]) VALUES ('" + txtMachineNo.Text + "','" + txtMachineName.Text + "','" + txtClassification.Text + "','" + txtSerial.Text + "')");

                com = new SqlCommand(CommandText, con);

                try
                {
                    com.ExecuteNonQuery();
                    var confirmed = MessageBox.Show("Machine has been added to the database successfully - Add another machine?", "Attempt To Add New Machine", MessageBoxButtons.YesNo);

                    if (confirmed == DialogResult.Yes)
                    {
                        txtMachineNo.Text = "";
                        txtMachineName.Text = "";
                        txtClassification.Text = "";
                        txtSerial.Text = "";
                    }
                    else
                    {
                        Machines.ActiveForm.Refresh();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Attempt To Add New Machine", MessageBoxButtons.OK);
                    this.Close();
                }
                finally
                {
                    con.Close();
                }
            }
            }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
