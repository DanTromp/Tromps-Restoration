namespace Tromps_Restoration
{
    partial class HiresAndServices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabHires = new System.Windows.Forms.TabControl();
            this.Hires = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.comboMachine = new System.Windows.Forms.ComboBox();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIn = new System.Windows.Forms.DateTimePicker();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtDailyCost = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabHires.SuspendLayout();
            this.Hires.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHires
            // 
            this.tabHires.Controls.Add(this.Hires);
            this.tabHires.Controls.Add(this.tabPage2);
            this.tabHires.Font = new System.Drawing.Font("Bookman Old Style", 15.75F);
            this.tabHires.Location = new System.Drawing.Point(0, 0);
            this.tabHires.Name = "tabHires";
            this.tabHires.SelectedIndex = 0;
            this.tabHires.Size = new System.Drawing.Size(511, 498);
            this.tabHires.TabIndex = 0;
            // 
            // Hires
            // 
            this.Hires.Controls.Add(this.tableLayoutPanel1);
            this.Hires.Font = new System.Drawing.Font("Bookman Old Style", 15.75F);
            this.Hires.Location = new System.Drawing.Point(4, 33);
            this.Hires.Name = "Hires";
            this.Hires.Padding = new System.Windows.Forms.Padding(3);
            this.Hires.Size = new System.Drawing.Size(503, 461);
            this.Hires.TabIndex = 0;
            this.Hires.Text = "Hires";
            this.Hires.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAccept, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboCustomer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboMachine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeOut, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtInvoiceNo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDailyCost, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Machine Number:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Booked Out:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Booked In:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice Number:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cost Per Day:";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.Location = new System.Drawing.Point(64, 388);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(113, 45);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(297, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboCustomer
            // 
            this.comboCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(269, 15);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(189, 32);
            this.comboCustomer.TabIndex = 8;
            // 
            // comboMachine
            // 
            this.comboMachine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboMachine.FormattingEnabled = true;
            this.comboMachine.Location = new System.Drawing.Point(266, 78);
            this.comboMachine.Name = "comboMachine";
            this.comboMachine.Size = new System.Drawing.Size(195, 32);
            this.comboMachine.TabIndex = 9;
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeOut.Location = new System.Drawing.Point(263, 141);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(200, 32);
            this.dateTimeOut.TabIndex = 10;
            // 
            // dateTimeIn
            // 
            this.dateTimeIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeIn.Location = new System.Drawing.Point(263, 204);
            this.dateTimeIn.Name = "dateTimeIn";
            this.dateTimeIn.Size = new System.Drawing.Size(200, 32);
            this.dateTimeIn.TabIndex = 11;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceNo.Location = new System.Drawing.Point(266, 267);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(195, 32);
            this.txtInvoiceNo.TabIndex = 12;
            // 
            // txtDailyCost
            // 
            this.txtDailyCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDailyCost.Location = new System.Drawing.Point(266, 330);
            this.txtDailyCost.Name = "txtDailyCost";
            this.txtDailyCost.Size = new System.Drawing.Size(195, 32);
            this.txtDailyCost.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // HiresAndServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 496);
            this.Controls.Add(this.tabHires);
            this.Name = "HiresAndServices";
            this.Text = "HiresAndServices";
            this.Load += new System.EventHandler(this.HiresAndServices_Load);
            this.tabHires.ResumeLayout(false);
            this.Hires.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHires;
        private System.Windows.Forms.TabPage Hires;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.ComboBox comboMachine;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.DateTimePicker dateTimeIn;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.MaskedTextBox txtDailyCost;
    }
}