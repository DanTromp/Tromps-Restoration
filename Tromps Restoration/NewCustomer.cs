using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tromps_Restoration
{
    public partial class NewCustomer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand com = new SqlCommand();
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool passed = true;

            if (txtFirstName.Text == "")
            {
                txtFirstName.BackColor = Color.Red;
                passed = false;
            }
            if (txtLastName.Text == "")
            {
                txtLastName.BackColor = Color.Red;
                passed = false;
            }
            if (txtIdNo.Text == "" || txtIdNo.Text.Length != 13)
            {
                txtIdNo.BackColor = Color.Red;
                passed = false;
            }
            if (txtTelephone.Text == "")
            {
                txtTelephone.BackColor = Color.Red;
                passed = false;
            }
            if (txtAddress.Text == "")
            {
                txtAddress.BackColor = Color.Red;
                passed = false;
            }
            if (!reg.IsMatch(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Red;
                passed = false;
            }

            if (!passed)
            {
                MessageBox.Show("Please fix all fields in red!", "Customer Details");
                return;
            }
            else
            {
                con = new SqlConnection(cs);
                con.Open();

                string CommandText = (@"INSERT INTO [dbo].[Customers] ([First Name],[Last Name],[ID Number],[Telphone Number],[Email Address],[Address]) VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtIdNo.Text + "','" + txtTelephone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')");

                com = new SqlCommand(CommandText, con);

                try
                {
                    com.ExecuteNonQuery();
                    var confirmed = MessageBox.Show("Customer has been added to the database successfully - Add another Customer?", "Attempt To Add New Customer", MessageBoxButtons.YesNo);

                    if (confirmed == DialogResult.Yes)
                    {
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtIdNo.Text = "";
                        txtTelephone.Text = "";
                        txtAddress.Text = "";
                        lblEmail.Text = "";
                    }
                    else
                    {
                        Customers.ActiveForm.Refresh();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Attempt To Add New Customer", MessageBoxButtons.OK);
                    this.Close();
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
