using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        private decimal dailyCost;
        private decimal final;
        private decimal bigTotal;
        List<Machine> machines = new List<Machine>();

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
                machines = (from a in context.Machines select a).ToList();
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

            var toolItems = (from a in machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).ToArray();

                comboTool1.Items.AddRange(toolItems);
            
        }

        private void ComboEquip2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip2.SelectedItem.ToString();

            var toolItems = (from a in machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).ToArray();

            comboTool2.Items.AddRange(toolItems);
            
        }

        private void ComboEquip3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip3.SelectedItem.ToString();

            var toolItems = (from a in machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).ToArray();

            comboTool3.Items.AddRange(toolItems);
            
        }

        private void ComboTool1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = int.Parse(comboTool1.SelectedItem.ToString());
            var item = (from a in machines where a.Machine_Number == selectedItem select a.Daily_Rate).First();

            dailyCost = (decimal)item;

                lblRate1.Text = "R" + item.ToString().Substring(0, item.ToString().Length - 2);


            numericUpDownDays1.Value = daysHired;
        }

        private void ComboTool2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = int.Parse(comboTool1.SelectedItem.ToString());
            var item = (from a in machines where a.Machine_Number == selectedItem select a.Daily_Rate).First();

            dailyCost = (decimal)item;

            lblRate2.Text = "R" + item.ToString().Substring(0, item.ToString().Length - 2);


            numericUpDownDays2.Value = daysHired;
        }

        private void ComboTool3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = int.Parse(comboTool1.SelectedItem.ToString());
            var item = (from a in machines where a.Machine_Number == selectedItem select a.Daily_Rate).First();

            dailyCost = (decimal)item;

            lblRate3.Text = "R" + item.ToString().Substring(0, item.ToString().Length - 2);


            numericUpDownDays3.Value = daysHired;
        }

        private void NumericUpDownDays1_ValueChanged(object sender, EventArgs e)
        {
            final = dailyCost * daysHired;

            lblFee1.Text = "R" + final.ToString().Substring(0, final.ToString().Length - 2);
        }

        private void NumericUpDownDays2_ValueChanged(object sender, EventArgs e)
        {

            final = dailyCost * daysHired;

            lblFee2.Text = "R" + final.ToString().Substring(0, final.ToString().Length - 2);
        }

        private void NumericUpDownDays3_ValueChanged(object sender, EventArgs e)
        {

            final = dailyCost * daysHired;

            lblFee3.Text = "R" + final.ToString().Substring(0, final.ToString().Length - 2);
        }

        private void LblFee1_TextChanged(object sender, EventArgs e)
        {
            bigTotal += final;

            lblSubTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void LblFee2_TextChanged(object sender, EventArgs e)
        {
            bigTotal += final;
            lblSubTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void LblFee3_TextChanged(object sender, EventArgs e)
        {
            bigTotal += final;

            lblSubTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void DateTimeEndHire_ValueChanged(object sender, EventArgs e)
        {
            daysHired = (dateTimeEndHire.Value - dateTimeStart.Value).Days;
        }
    }
}