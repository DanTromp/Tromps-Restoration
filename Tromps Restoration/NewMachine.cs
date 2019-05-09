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
            con = new SqlConnection(cs);
            con.Open();            

            com.Connection = con;
            com.CommandText = (@"INSERT INTO [Machines] ([Machine Name], [Machine Classification], [Machine Serial Number] VALUES ('" + txtMachineName.Text + "','" + txtClassification.Text + "','" + txtSerial.Text + "'");
            
            try { 
            com.ExecuteNonQuery();
                var confirmed = MessageBox.Show("Machine has been added to the database successfully - Add another machine?", "Attempt To Add New Machine", MessageBoxButtons.YesNo);

                if (confirmed == DialogResult.Yes)
                {
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
            }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
