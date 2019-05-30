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
        private InvoiceModel invModel = new InvoiceModel();
        private string cs = ConfigurationManager.ConnectionStrings["Tromps_Restoration.Properties.Settings.TrompsConnectionString"].ConnectionString;
        private SqlConnection con;
        private SqlCommand com = new SqlCommand();
        private int daysHired;

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
                var equipList = (from a in context.Machines select a.Machine_Name).Distinct().ToArray();

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

        private void ComboEquip1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip1.SelectedItem.ToString();

            using (var context = new TrompsEntities1())
            {
                var tools = (from a in context.Machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).Distinct().ToArray();

                comboTool1.Items.AddRange(tools);
            }
        }

        private void ComboEquip2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip2.SelectedItem.ToString();

            using (var context = new TrompsEntities1())
            {
                var tools = (from a in context.Machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).Distinct().ToArray();

                comboTool2.Items.AddRange(tools);
            }
        }

        private void ComboEquip3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip3.SelectedItem.ToString();

            using (var context = new TrompsEntities1())
            {
                var tools = (from a in context.Machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).Distinct().ToArray();

                comboTool3.Items.AddRange(tools);
            }
        }

        private void ComboTool1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new TrompsEntities1())
            {
                var tool = from a in context.Machines where a.Machine_Number == int.Parse(this.comboTool1.SelectedItem.ToString()) select a.Daily_Rate;

                lblRate1.Text = "R" + tool.ToString() + ".00";

                lblRate1.Refresh();
            }

            numericUpDownDays1.Value = daysHired;
        }

        private void ComboTool2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new TrompsEntities1())
            {
                var tools = (from a in context.Machines where a.Machine_Number == int.Parse(this.comboTool2.SelectedItem.ToString()) select a.Daily_Rate.ToString());

                lblRate2.Text = "R" + tools.ToString() + ".00";
            }

            numericUpDownDays2.Value = daysHired;
        }

        private void ComboTool3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new TrompsEntities1())
            {
                var tools = (from a in context.Machines where a.Machine_Number == int.Parse(this.comboTool3.SelectedItem.ToString()) select a.Daily_Rate.ToString());

                lblRate3.Text = "R" + tools.ToString() + ".00";
            }

            numericUpDownDays3.Value = daysHired;
        }

        private void NumericUpDownDays1_ValueChanged(object sender, EventArgs e)
        {
            lblFee1.Text = "R" + (decimal.Parse(lblRate1.Text.Substring(1, lblRate1.Text.Length)) * (decimal)this.numericUpDownDays1.Value).ToString();
        }

        private void NumericUpDownDays2_ValueChanged(object sender, EventArgs e)
        {
            lblFee2.Text = "R" + (decimal.Parse(lblRate2.Text.Substring(1, lblRate2.Text.Length)) * (decimal)this.numericUpDownDays2.Value).ToString();
        }

        private void NumericUpDownDays3_ValueChanged(object sender, EventArgs e)
        {
            lblFee3.Text = "R" + (decimal.Parse(lblRate3.Text.Substring(1, lblRate3.Text.Length)) * (decimal)this.numericUpDownDays3.Value).ToString();
        }

        private void LblFee1_TextChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = "R" + (decimal.Parse(lblFee1.Text) + decimal.Parse(lblFee2.Text) + decimal.Parse(lblFee3.Text)).ToString();
        }

        private void LblFee2_TextChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = "R" + (decimal.Parse(lblFee1.Text) + decimal.Parse(lblFee2.Text) + decimal.Parse(lblFee3.Text)).ToString();
        }

        private void LblFee3_TextChanged(object sender, EventArgs e)
        {
            lblSubTotal.Text = "R" + (decimal.Parse(lblFee1.Text) + decimal.Parse(lblFee2.Text) + decimal.Parse(lblFee3.Text)).ToString();
        }

        private void DateTimeEndHire_ValueChanged(object sender, EventArgs e)
        {
            daysHired = (dateTimeEndHire.Value - dateTimeStart.Value).Days;
        }
    }
}