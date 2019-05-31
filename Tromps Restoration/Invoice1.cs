using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tromps_Restoration
{
    public partial class Invoice1 : Form
    {
        public static string InvoiceNo = "";
        public static InvoiceModel invoiceModel = new InvoiceModel();

        public Invoice1()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Tromps\InvoiceNumber.txt"))
            {
                if (File.ReadAllText(@"C:\Tromps\InvoiceNumber.txt") == null)
                    InvoiceNo = "INV-1560";
                else
                {
                    line = File.ReadAllText(@"C:\Tromps\InvoiceNumber.txt");
                    line = line.Substring(0, line.Length - 2);
                    var splitString = line.Split('-');
                    int numberSeries = int.Parse(splitString[1]) + 1;

                    InvoiceNo = splitString[0] + '-' + numberSeries.ToString();
                }
            }

            using (StreamWriter sw = new StreamWriter(@"C:\Tromps\InvoiceNumber.txt"))
            {
                sw.WriteLine(InvoiceNo);
            }

            txtInvoiceNo.Text = InvoiceNo;

            txtName.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            invoiceModel.hirerName = txtName.Text;
            invoiceModel.hirerAddress = txtAddress.Text;
            invoiceModel.hirerTelNo = txtTelNo.Text;
            invoiceModel.hirerIdentityNo = txtIdNo.Text;
            invoiceModel.hirerCarRegNo = txtCarReg.Text;
            invoiceModel.hirerCarMakeModel = txtMakeModel.Text;
            invoiceModel.addressWhereUsed = txtAddressWhereUsed.Text;
            invoiceModel.specialInstructions = txtSpecialInstructions.Text ?? "";

            var splitName = txtName.Text.Split(' ');

            TrompsEntities1 context = new TrompsEntities1();
            var existsAlready = (from a in context.Customers where a.ID_Number == txtIdNo.Text select a).FirstOrDefault();

            if (existsAlready == null)
                context.Customers.Add(new Customer { First_Name = splitName[0], Last_Name = splitName[1], Address = txtAddress.Text, ID_Number = txtIdNo.Text, Telphone_Number = txtTelNo.Text });

            context.SaveChanges();

            Invoice2 invoice2 = new Invoice2();
            this.Close();
            invoice2.Show();
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