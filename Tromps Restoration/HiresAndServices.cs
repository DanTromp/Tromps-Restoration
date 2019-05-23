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
    public partial class HiresAndServices : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter adapt;
        DataTable dt;

        public HiresAndServices()
        {
            InitializeComponent();
        }

        private void HiresAndServices_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);

            adapt = new SqlDataAdapter("SELECT [Customer ID], [First Name] + ' ' + [Last Name] AS [Full Name] FROM [Customers]", con);
            dt = new DataTable();
            adapt.Fill(dt);

            DataView view = new DataView(dt);

            comboCustomer.Items.Add("");
            comboMachine.Items.Add("");

            foreach (DataRowView row in view)
            {
                comboCustomer.Items.Add(row["Full Name"].ToString());
            }

            adapt = new SqlDataAdapter("SELECT [Machine Number] FROM [Machines] ORDER BY 1 desc", con);
            dt = new DataTable();
            adapt.Fill(dt);

            DataView view2 = new DataView(dt);

            foreach (DataRowView row in view2)
            {
                comboMachine.Items.Add(row["Machine Number"].ToString());
            }

            comboCustomer.Refresh();
            comboMachine.Refresh();


        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            bool valuesFilled = true;

            if (comboCustomer.SelectedText == "")
            {
                comboCustomer.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (comboMachine.SelectedText == "")
            { 
                comboMachine.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (txtInvoiceNo.Text == "")
            {
                txtInvoiceNo.BackColor = Color.Red;
                valuesFilled = false;
            }
            if (txtDailyCost.Text == "")
            {
                txtDailyCost.BackColor = Color.Red;
                valuesFilled = false;
            }

            if (!valuesFilled)
            {
                MessageBox.Show("Please complete all the red fields.");
                return;
            }
            else
            {

            }
        }
    }
}
