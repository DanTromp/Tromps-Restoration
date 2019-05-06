﻿namespace Tromps_Restoration
{
    partial class MachineHires
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineHiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthAndSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.dataGridHires = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHires)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(540, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.machinesToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Checked = true;
            this.machinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineHiresToolStripMenuItem,
            this.machineServicesToolStripMenuItem});
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // machineHiresToolStripMenuItem
            // 
            this.machineHiresToolStripMenuItem.Checked = true;
            this.machineHiresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machineHiresToolStripMenuItem.Enabled = false;
            this.machineHiresToolStripMenuItem.Name = "machineHiresToolStripMenuItem";
            this.machineHiresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.machineHiresToolStripMenuItem.Text = "Machine Hires";
            // 
            // machineServicesToolStripMenuItem
            // 
            this.machineServicesToolStripMenuItem.Name = "machineServicesToolStripMenuItem";
            this.machineServicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.machineServicesToolStripMenuItem.Text = "Machine Services";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthAndSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthAndSafteyToolStripMenuItem
            // 
            this.healthAndSafteyToolStripMenuItem.Name = "healthAndSafteyToolStripMenuItem";
            this.healthAndSafteyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.healthAndSafteyToolStripMenuItem.Text = "Health and Saftey";
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Machine Name:";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(279, 42);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(222, 23);
            this.txtMachineName.TabIndex = 4;
            // 
            // dataGridHires
            // 
            this.dataGridHires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHires.Location = new System.Drawing.Point(0, 71);
            this.dataGridHires.Name = "dataGridHires";
            this.dataGridHires.Size = new System.Drawing.Size(540, 415);
            this.dataGridHires.TabIndex = 5;
            // 
            // MachineHires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 482);
            this.Controls.Add(this.dataGridHires);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.Name = "MachineHires";
            this.Text = "Machine Hires";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineHiresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthAndSafteyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineSpecificToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.DataGridView dataGridHires;
    }
}