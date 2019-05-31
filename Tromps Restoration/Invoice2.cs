using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
        private List<Machine> machines = new List<Machine>();
        private TrompsEntities1 context = new TrompsEntities1();

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

            txtInitialAmount.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ButtonPrintClick();

            con = new SqlConnection(cs);
            con.Open();

            int[] toolNos = new int[5];
            string toolNumbers = "";

            if (comboTool1.Text != "") {
                toolNos[0] = int.Parse(comboTool1.Text);
                toolNumbers = comboTool1.Text;
            }
            if (comboTool2.Text != "") { 
                toolNos[1] = int.Parse(comboTool2.Text);
                toolNumbers = toolNumbers + "," + comboTool2.Text;
            }
            if (comboTool3.Text != "")
            {
                toolNos[2] = int.Parse(comboTool3.Text);
                toolNumbers = toolNumbers + "," + comboTool3.Text;
            }

            context.Invoices.Add(new Invoice { Accessories = "", AccessoriesSubtotal = decimal.Parse(lblSubTotalAcc.Text.Substring(1, lblSubTotalAcc.Text.Length - 3)), AddressWhereUsed = invModel.addressWhereUsed, Collection = decimal.Parse(txtCollection.Text.Substring(1, txtCollection.Text.Length - 3)), Delivery = decimal.Parse(txtDelivery.Text.Substring(1, txtDelivery.Text.Length - 3)), Discount = decimal.Parse(txtDiscount.Text.Substring(1, txtDiscount.Text.Length - 3)), EndOfHire = dateTimeEndHire.Value.Date, EquipmentDueBack = dateTimeDueBack.Value.Date, EquipmentNos = toolNumbers, EquipmentSubtotal = decimal.Parse(lblSubTotal.Text.Substring(1, lblSubTotal.Text.Length - 3)), GrandTotal = decimal.Parse(lblGrandTotal.Text.Substring(1, lblGrandTotal.Text.Length - 3)), HirerAddress = invModel.hirerAddress, HirerCarMakeModel = invModel.hirerCarMakeModel, HirerCarReg = invModel.hirerCarRegNo, HirerIdentityNo = invModel.hirerIdentityNo, HirerName = invModel.hirerName, HirerTelNo = invModel.hirerTelNo, HowDidYouKnowUs = txtGetToKnowUs.Text, InitialPaymentReceived = decimal.Parse(txtInitialAmount.Text.Substring(1, txtInitialAmount.Text.Length - 3)), InvoiceDate = dateTimeInvoice.Value.Date, InvoiceNo = txtInvoiceNo.Text, Other = decimal.Parse(txtOther.Text.Substring(1, txtOther.Text.Length - 3)), SpecialInstructions = invModel.specialInstructions, StartOfHire = dateTimeStart.Value.Date});

            try
            {

                context.SaveChanges();

                var confirmed = MessageBox.Show("Invoice has been added to the database successfully - Add another Invoice?", "Attempt To Add New Invoice", MessageBoxButtons.YesNo);

                var customerId = (from a in context.Customers where a.ID_Number == invModel.hirerIdentityNo select a.CustomerId).First();

                for (int i = 0; i < toolNos.Length; i++)
                {
                    if (i == 0)
                        context.Hire_Orders.Add(new Hire_Order { Customer_ID = customerId, Machine_ID = toolNos[i], Invoice_Number = txtInvoiceNo.Text, Cost_Per_Day = decimal.Parse(lblRate1.Text.Substring(1, lblRate1.Text.Length - 2)), Date_Booked_Out = dateTimeStart.Value, Date_Booked_In = dateTimeDueBack.Value, Total_Cost = decimal.Parse(lblFee1.Text.Substring(1, lblFee1.Text.Length - 2))});

                    if (i == 1)
                        context.Hire_Orders.Add(new Hire_Order { Customer_ID = customerId, Machine_ID = toolNos[i], Invoice_Number = txtInvoiceNo.Text, Cost_Per_Day = decimal.Parse(lblRate2.Text.Substring(1, lblRate2.Text.Length - 2)), Date_Booked_Out = dateTimeStart.Value, Date_Booked_In = dateTimeDueBack.Value, Total_Cost = decimal.Parse(lblFee2.Text.Substring(1, lblFee2.Text.Length - 2)) });

                    if (i == 2)
                        context.Hire_Orders.Add(new Hire_Order { Customer_ID = customerId, Machine_ID = toolNos[i], Invoice_Number = txtInvoiceNo.Text, Cost_Per_Day = decimal.Parse(lblRate3.Text.Substring(1, lblRate3.Text.Length - 2)), Date_Booked_Out = dateTimeStart.Value, Date_Booked_In = dateTimeDueBack.Value, Total_Cost = decimal.Parse(lblFee3.Text.Substring(1, lblFee3.Text.Length - 2)) });
                }

                context.SaveChanges();
                

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
            comboTool1.Items.Clear();

            var toolItems = (from a in machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).ToArray();

            comboTool1.Items.AddRange(toolItems);
            numericUpDownQuantity1.Value = 1;
        }

        private void ComboEquip2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip2.SelectedItem.ToString();
            comboTool2.Items.Clear();

            var toolItems = (from a in machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).ToArray();

            comboTool2.Items.AddRange(toolItems);
            numericUpDownQuantity2.Value = 1;
        }

        private void ComboEquip3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = this.comboEquip3.SelectedItem.ToString();
            comboTool3.Items.Clear();

            var toolItems = (from a in machines where a.Machine_Name == itemSelected select a.Machine_Number.ToString()).ToArray();

            comboTool3.Items.AddRange(toolItems);
            numericUpDownQuantity3.Value = 1;
        }

        private void ComboTool1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = int.Parse(comboTool1.SelectedItem.ToString());
            var item = (from a in machines where a.Machine_Number == selectedItem select a.Daily_Rate).First();

            dailyCost = (decimal)item;

            lblRate1.Text = "R" + item.ToString().Substring(0, item.ToString().Length - 2);

            final = dailyCost * daysHired;
            lblFee1.Text = "R" + final.ToString().Substring(0, final.ToString().Length - 2);
        }

        private void ComboTool2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = int.Parse(comboTool2.SelectedItem.ToString());
            var item = (from a in machines where a.Machine_Number == selectedItem select a.Daily_Rate).First();

            dailyCost = (decimal)item;

            lblRate2.Text = "R" + item.ToString().Substring(0, item.ToString().Length - 2);

            final = dailyCost * daysHired;
            lblFee2.Text = "R" + final.ToString().Substring(0, final.ToString().Length - 2);
        }

        private void ComboTool3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = int.Parse(comboTool3.SelectedItem.ToString());
            var item = (from a in machines where a.Machine_Number == selectedItem select a.Daily_Rate).First();

            dailyCost = (decimal)item;

            lblRate3.Text = "R" + item.ToString().Substring(0, item.ToString().Length - 2);

            final = dailyCost * daysHired;
            lblFee3.Text = "R" + final.ToString().Substring(0, final.ToString().Length - 2);
        }

        private void LblFee1_TextChanged(object sender, EventArgs e)
        {
            bigTotal += final;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
            lblSubTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void LblFee2_TextChanged(object sender, EventArgs e)
        {
            bigTotal += final;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void LblFee3_TextChanged(object sender, EventArgs e)
        {
            bigTotal += final;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void DateTimeEndHire_ValueChanged(object sender, EventArgs e)
        {
            daysHired = (dateTimeEndHire.Value - dateTimeStart.Value).Days;

            numericUpDownDays1.Value = daysHired;
            numericUpDownDays2.Value = daysHired;
            numericUpDownDays3.Value = daysHired;
        }

        // Handler for print call
        private void ButtonPrintClick()
        {
            // Create document
            PrintDocument _document = new PrintDocument();
            // Add print handler
            _document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            // Create the dialog to display results
            PrintPreviewDialog _dlg = new PrintPreviewDialog();
            _dlg.ClientSize = new System.Drawing.Size(Width / 2, Height / 2);
            _dlg.Location = new System.Drawing.Point(Left, Top);
            _dlg.MinimumSize = new System.Drawing.Size(375, 250);
            _dlg.UseAntiAlias = true;
            // Setting up our document
            _dlg.Document = _document;
            // Show it
            _dlg.ShowDialog(this);
            // Dispose document
            _document.Dispose();
        }

        // Print handler
        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create Bitmap according form size
            Bitmap _bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            // Draw from into Bitmap DC
            this.DrawToBitmap(_bitmap, this.DisplayRectangle);
            // Draw Bitmap into Printer DC
            e.Graphics.DrawImage(_bitmap, 0, 0);
            // No longer deeded - dispose it
            _bitmap.Dispose();
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
                return;

            var discountAmount = decimal.Parse(txtDiscount.Text);

            bigTotal -= discountAmount;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void TxtDelivery_TextChanged(object sender, EventArgs e)
        {
            if (txtDelivery.Text == "")
                return;

            var discountAmount = decimal.Parse(txtDelivery.Text);

            bigTotal += discountAmount;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void TxtCollection_TextChanged(object sender, EventArgs e)
        {
            if (txtCollection.Text == "")
                return;

            var discountAmount = decimal.Parse(txtCollection.Text);

            bigTotal += discountAmount;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }

        private void TxtOther_TextChanged(object sender, EventArgs e)
        {
            if (txtOther.Text == "")
                return;

            var discountAmount = decimal.Parse(txtOther.Text);

            bigTotal += discountAmount;
            lblGrandTotal.Text = "R" + bigTotal.ToString().Substring(0, bigTotal.ToString().Length - 2);
        }
    }
}