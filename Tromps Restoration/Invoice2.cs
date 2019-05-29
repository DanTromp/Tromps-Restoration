using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tromps_Restoration
{
    public partial class Invoice2 : Form
    {
        InvoiceModel invModel = new InvoiceModel();
        string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand com = new SqlCommand();
        public Invoice2()
        {
            InitializeComponent();
        }

        private void Invoice2_Load(object sender, EventArgs e)
        {
            txtInvoiceNo.Text = Invoice1.InvoiceNo.ToString();
            invModel = Invoice1.invoiceModel;


            using (var context = new TrompsEntities1())
            {
                var equipList = (from a in context.Machines select a.Machine_Name).ToArray();

                comboEquip1.Items.AddRange(equipList);
                comboEquip2.Items.AddRange(equipList);
                comboEquip3.Items.AddRange(equipList);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();

            

            string CommandText = (@"INSERT INTO [dbo].[Invoices]([InvoiceNo],[HirerName],[HirerAddress],[HirerTelNo],[HirerIdentityNo],[HirerCarReg],[HirerCarMakeModel],[AddressWhereUsed],[SpecialInstructions],[InitialPaymentReceived],[StartOfHire],[EquipmentDueBack],[EndOfHire],[EquipmentNos],[EquipmentSubtotal],[Accessories],[AccessoriesSubtotal],[Discount],[Delivery],[Collection],[Other],[GrandTotal],[HowDidYouKnowUs],[InvoiceDate])VALUES(" + txtInvoiceNo.Text + "," + invModel.hirerName + "," + invModel.hirerAddress + "," + invModel.hirerTelNo + "," + invModel.hirerIdentityNo + "," + invModel.hirerCarRegNo + "," + invModel.hirerCarMakeModel + "," + invModel.addressWhereUsed + "," + invModel.specialInstructions + "," + txtInitialAmount.Text + "," + dateTimeStart.Value + "," + dateTimeDueBack.Value + "," + dateTimeEndHire.Value + "," + "Equipment Nos" + "," + lblSubTotal.Text.Substring(1, lblSubTotal.Text.Length) + "," + "Accessories" + "," + lblSubTotalAcc.Text.Substring(1, lblSubTotalAcc.Text.Length) + "," + txtDiscount.Text + "," + txtDelivery.Text + "," + txtCollection.Text + "," + txtOther.Text + "," + lblGrandTotal.Text.Substring(1, lblGrandTotal.Text.Length) + "," + txtGetToKnowUs.Text + "," + dateTimeInvoice.Value + "'");


            com = new SqlCommand(CommandText, con);

            try
            {
                com.ExecuteNonQuery();
                var confirmed = MessageBox.Show("Invoice has been added to the database successfully - Add another Invoice?", "Attempt To Add New Invoice", MessageBoxButtons.YesNo);

                if (confirmed == DialogResult.Yes)
                {
                    Invoice1 invoice = new Invoice1();
                    this.Close();
                    invoice.Show();
                }
                else
                {
                    Home home = new Home();
                    this.Close();
                    home.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Attempt To Add New Invoice", MessageBoxButtons.OK);
                this.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var confirmed = MessageBox.Show("Are you sure you want to cancel?", "Cancel New Invoice", MessageBoxButtons.YesNo);

            if (confirmed == DialogResult.Yes)
            {
                this.Close();
                Home hme = new Home();
                hme.Show();
            }
            else
                return;

        }
    }
}
