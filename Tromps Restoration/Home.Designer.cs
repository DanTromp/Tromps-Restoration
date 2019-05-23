namespace Tromps_Restoration
{
    partial class Home
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
            this.menuMainPage = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMachine = new System.Windows.Forms.Button();
            this.btnHiresAndServices = new System.Windows.Forms.Button();
            this.menuMainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainPage
            // 
            this.menuMainPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMainPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.menuMainPage.Location = new System.Drawing.Point(0, 0);
            this.menuMainPage.Name = "menuMainPage";
            this.menuMainPage.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuMainPage.Size = new System.Drawing.Size(376, 31);
            this.menuMainPage.TabIndex = 0;
            this.menuMainPage.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.machineHireToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // machineHireToolStripMenuItem
            // 
            this.machineHireToolStripMenuItem.Name = "machineHireToolStripMenuItem";
            this.machineHireToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.machineHireToolStripMenuItem.Text = "Machines";
            this.machineHireToolStripMenuItem.Click += new System.EventHandler(this.MachineHireToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(128, 27);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthSafteyToolStripMenuItem
            // 
            this.healthSafteyToolStripMenuItem.Name = "healthSafteyToolStripMenuItem";
            this.healthSafteyToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.healthSafteyToolStripMenuItem.Text = "Health and Saftey";
            this.healthSafteyToolStripMenuItem.Click += new System.EventHandler(this.HealthSafteyToolStripMenuItem_Click);
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomers.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(12, 75);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(352, 50);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customer Manageament";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // btnMachine
            // 
            this.btnMachine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMachine.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachine.Location = new System.Drawing.Point(12, 142);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(352, 50);
            this.btnMachine.TabIndex = 2;
            this.btnMachine.Text = "Machine Manageament";
            this.btnMachine.UseVisualStyleBackColor = true;
            this.btnMachine.Click += new System.EventHandler(this.MachineHireToolStripMenuItem_Click);
            // 
            // btnHiresAndServices
            // 
            this.btnHiresAndServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHiresAndServices.Enabled = false;
            this.btnHiresAndServices.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHiresAndServices.Location = new System.Drawing.Point(12, 210);
            this.btnHiresAndServices.Name = "btnHiresAndServices";
            this.btnHiresAndServices.Size = new System.Drawing.Size(352, 50);
            this.btnHiresAndServices.TabIndex = 3;
            this.btnHiresAndServices.Text = "Hires and Services";
            this.btnHiresAndServices.UseVisualStyleBackColor = true;
            this.btnHiresAndServices.Click += new System.EventHandler(this.BtnHiresAndServices_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 293);
            this.Controls.Add(this.btnHiresAndServices);
            this.Controls.Add(this.btnMachine);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.menuMainPage);
            this.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.MainMenuStrip = this.menuMainPage;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuMainPage.ResumeLayout(false);
            this.menuMainPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainPage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineHireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthSafteyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineSpecificToolStripMenuItem;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMachine;
        private System.Windows.Forms.Button btnHiresAndServices;
    }
}