namespace Tromps_Restoration
{
    partial class Machines
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthAndSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridMachines = new System.Windows.Forms.DataGridView();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trompsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trompsDataSet = new Tromps_Restoration.TrompsDataSet();
            this.trompsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.machinesTableAdapter = new Tromps_Restoration.TrompsDataSetTableAdapters.MachinesTableAdapter();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboReport = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(345, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.machinesToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Checked = true;
            this.machinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machinesToolStripMenuItem.Enabled = false;
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthAndSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthAndSafteyToolStripMenuItem
            // 
            this.healthAndSafteyToolStripMenuItem.Name = "healthAndSafteyToolStripMenuItem";
            this.healthAndSafteyToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.healthAndSafteyToolStripMenuItem.Text = "Health and Saftey";
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // dataGridMachines
            // 
            this.dataGridMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMachines.Location = new System.Drawing.Point(0, 32);
            this.dataGridMachines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridMachines.Name = "dataGridMachines";
            this.dataGridMachines.Size = new System.Drawing.Size(344, 173);
            this.dataGridMachines.TabIndex = 3;
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.trompsDataSetBindingSource;
            // 
            // trompsDataSetBindingSource
            // 
            this.trompsDataSetBindingSource.DataSource = this.trompsDataSet;
            this.trompsDataSetBindingSource.Position = 0;
            // 
            // trompsDataSet
            // 
            this.trompsDataSet.DataSetName = "TrompsDataSet";
            this.trompsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trompsDataSetBindingSource1
            // 
            this.trompsDataSetBindingSource1.DataSource = this.trompsDataSet;
            this.trompsDataSetBindingSource1.Position = 0;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(243, 227);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(90, 23);
            this.btnRunReport.TabIndex = 4;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.BtnRunReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Report Type:";
            // 
            // comboReport
            // 
            this.comboReport.FormattingEnabled = true;
            this.comboReport.Items.AddRange(new object[] {
            "Dual",
            "Hire",
            "Service"});
            this.comboReport.Location = new System.Drawing.Point(96, 228);
            this.comboReport.Name = "comboReport";
            this.comboReport.Size = new System.Drawing.Size(121, 23);
            this.comboReport.Sorted = true;
            this.comboReport.TabIndex = 6;
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 257);
            this.Controls.Add(this.comboReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.dataGridMachines);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Machines";
            this.Text = "Machines";
            this.Load += new System.EventHandler(this.Machines_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthAndSafteyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineSpecificToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridMachines;
        private System.Windows.Forms.BindingSource trompsDataSetBindingSource;
        private TrompsDataSet trompsDataSet;
        private System.Windows.Forms.BindingSource trompsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private TrompsDataSetTableAdapters.MachinesTableAdapter machinesTableAdapter;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboReport;
    }
}