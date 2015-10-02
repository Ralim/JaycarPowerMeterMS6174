namespace Jaycar_Data_Logger_Interface
{
    partial class Form1
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
            this.gbConnectionInfo = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.timerUpdateView = new System.Windows.Forms.Timer(this.components);
            this.gbCurrentStatus = new System.Windows.Forms.GroupBox();
            this.lblWatts = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbDataSet = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDataSet = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtDataInfo = new System.Windows.Forms.TextBox();
            this.SampleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbConnectionInfo.SuspendLayout();
            this.gbCurrentStatus.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbDataSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnectionInfo
            // 
            this.gbConnectionInfo.Controls.Add(this.btnOpen);
            this.gbConnectionInfo.Controls.Add(this.label1);
            this.gbConnectionInfo.Controls.Add(this.cbPorts);
            this.gbConnectionInfo.Location = new System.Drawing.Point(12, 12);
            this.gbConnectionInfo.Name = "gbConnectionInfo";
            this.gbConnectionInfo.Size = new System.Drawing.Size(113, 148);
            this.gbConnectionInfo.TabIndex = 0;
            this.gbConnectionInfo.TabStop = false;
            this.gbConnectionInfo.Text = "Connection";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 63);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(6, 36);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(101, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // timerUpdateView
            // 
            this.timerUpdateView.Interval = 500;
            this.timerUpdateView.Tick += new System.EventHandler(this.timerUpdateView_Tick);
            // 
            // gbCurrentStatus
            // 
            this.gbCurrentStatus.Controls.Add(this.lblWatts);
            this.gbCurrentStatus.Controls.Add(this.lblCurrent);
            this.gbCurrentStatus.Controls.Add(this.lblVoltage);
            this.gbCurrentStatus.Location = new System.Drawing.Point(131, 12);
            this.gbCurrentStatus.Name = "gbCurrentStatus";
            this.gbCurrentStatus.Size = new System.Drawing.Size(310, 148);
            this.gbCurrentStatus.TabIndex = 1;
            this.gbCurrentStatus.TabStop = false;
            this.gbCurrentStatus.Text = "Current Status";
            // 
            // lblWatts
            // 
            this.lblWatts.AutoSize = true;
            this.lblWatts.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatts.Location = new System.Drawing.Point(6, 100);
            this.lblWatts.Name = "lblWatts";
            this.lblWatts.Size = new System.Drawing.Size(110, 22);
            this.lblWatts.TabIndex = 2;
            this.lblWatts.Text = "Watts   : ";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(6, 60);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(110, 22);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Current : ";
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltage.Location = new System.Drawing.Point(6, 20);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(110, 22);
            this.lblVoltage.TabIndex = 0;
            this.lblVoltage.Text = "Voltage : ";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.gbDataSet);
            this.gbData.Controls.Add(this.dataGridView);
            this.gbData.Controls.Add(this.btnDownload);
            this.gbData.Enabled = false;
            this.gbData.Location = new System.Drawing.Point(12, 175);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(563, 399);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // gbDataSet
            // 
            this.gbDataSet.Controls.Add(this.btnExportData);
            this.gbDataSet.Controls.Add(this.txtDataInfo);
            this.gbDataSet.Controls.Add(this.label2);
            this.gbDataSet.Controls.Add(this.cbDataSet);
            this.gbDataSet.Enabled = false;
            this.gbDataSet.Location = new System.Drawing.Point(6, 48);
            this.gbDataSet.Name = "gbDataSet";
            this.gbDataSet.Size = new System.Drawing.Size(142, 345);
            this.gbDataSet.TabIndex = 2;
            this.gbDataSet.TabStop = false;
            this.gbDataSet.Text = "Data Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Data Set";
            // 
            // cbDataSet
            // 
            this.cbDataSet.FormattingEnabled = true;
            this.cbDataSet.Location = new System.Drawing.Point(6, 43);
            this.cbDataSet.Name = "cbDataSet";
            this.cbDataSet.Size = new System.Drawing.Size(121, 21);
            this.cbDataSet.TabIndex = 0;
            this.cbDataSet.SelectedIndexChanged += new System.EventHandler(this.cbDataSet_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleNum,
            this.Volt,
            this.Current,
            this.Power});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(154, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(398, 345);
            this.dataGridView.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(6, 19);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(90, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtDataInfo
            // 
            this.txtDataInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInfo.Location = new System.Drawing.Point(6, 87);
            this.txtDataInfo.Multiline = true;
            this.txtDataInfo.Name = "txtDataInfo";
            this.txtDataInfo.ReadOnly = true;
            this.txtDataInfo.Size = new System.Drawing.Size(121, 140);
            this.txtDataInfo.TabIndex = 2;
            // 
            // SampleNum
            // 
            this.SampleNum.HeaderText = "Sample No";
            this.SampleNum.Name = "SampleNum";
            this.SampleNum.ReadOnly = true;
            // 
            // Volt
            // 
            this.Volt.HeaderText = "Volts";
            this.Volt.Name = "Volt";
            this.Volt.ReadOnly = true;
            // 
            // Current
            // 
            this.Current.HeaderText = "Current";
            this.Current.Name = "Current";
            this.Current.ReadOnly = true;
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(6, 316);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(90, 23);
            this.btnExportData.TabIndex = 3;
            this.btnExportData.Text = "Export";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "1. Select Com Port\r\n2. Connect\r\n3. Download Logs\r\n4. Select Data Set\r\n5. Save Dat" +
    "a Set\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(10, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ben V. Brown - 2015";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbCurrentStatus);
            this.Controls.Add(this.gbConnectionInfo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POWERTECH Data Adapter Interface (MS6174)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConnectionInfo.ResumeLayout(false);
            this.gbConnectionInfo.PerformLayout();
            this.gbCurrentStatus.ResumeLayout(false);
            this.gbCurrentStatus.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbDataSet.ResumeLayout(false);
            this.gbDataSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnectionInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer timerUpdateView;
        private System.Windows.Forms.GroupBox gbCurrentStatus;
        private System.Windows.Forms.Label lblWatts;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox gbDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtDataInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}

