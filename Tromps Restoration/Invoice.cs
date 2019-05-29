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
    public partial class Invoice : Form
    {
        public static string InvoiceNo = "";
        public static InvoiceModel invoiceModel = new InvoiceModel();
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {            
            
            string line = "";
            using (StreamReader sr = new StreamReader("InvoiceNumber.txt"))
            {
                if (sr.ReadLine() == null)
                    InvoiceNo = "INV-1560";
                else
                {
                    line = sr.ReadLine();
                    var splitString = line.Split('-');
                    int numberSeries = int.Parse(splitString[1]) + 1;

                    InvoiceNo = splitString[0] + '-' + numberSeries.ToString();                    
                }
            }

            using (StreamWriter sw = new StreamWriter("InvoiceNumber.txt"))
            {

                sw.WriteLine(InvoiceNo);
            }

            txtInvoiceNo.Text = InvoiceNo;
            txtInvoiceNo.Refresh();
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

            Invoice2 invoice2 = new Invoice2();
            this.Close();
            invoice2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
