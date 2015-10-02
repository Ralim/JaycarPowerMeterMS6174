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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDataSet = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtDataInfo = new System.Windows.Forms.TextBox();
            this.SampleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConnectionInfo.SuspendLayout();
            this.gbCurrentStatus.SuspendLayout();
            this.gbData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.gbCurrentStatus.Size = new System.Drawing.Size(444, 148);
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
            this.gbData.Controls.Add(this.groupBox1);
            this.gbData.Controls.Add(this.dataGridView);
            this.gbData.Controls.Add(this.btnDownload);
            this.gbData.Location = new System.Drawing.Point(12, 175);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(563, 399);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDataSet);
            this.groupBox1.Location = new System.Drawing.Point(6, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Set";
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
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleNum,
            this.Volt,
            this.Current,
            this.Power});
            this.dataGridView.Location = new System.Drawing.Point(154, 48);
            this.dataGridView.Name = "dataGridView";
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
            this.txtDataInfo.Location = new System.Drawing.Point(6, 87);
            this.txtDataInfo.Multiline = true;
            this.txtDataInfo.Name = "txtDataInfo";
            this.txtDataInfo.ReadOnly = true;
            this.txtDataInfo.Size = new System.Drawing.Size(121, 252);
            this.txtDataInfo.TabIndex = 2;
            // 
            // SampleNum
            // 
            this.SampleNum.HeaderText = "Sample No";
            this.SampleNum.Name = "SampleNum";
            // 
            // Volt
            // 
            this.Volt.HeaderText = "Volts";
            this.Volt.Name = "Volt";
            // 
            // Current
            // 
            this.Current.HeaderText = "Current";
            this.Current.Name = "Current";
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 586);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtDataInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
    }
}

