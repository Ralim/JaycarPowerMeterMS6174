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
            this.btnDownload = new System.Windows.Forms.Button();
            this.gbConnectionInfo.SuspendLayout();
            this.gbCurrentStatus.SuspendLayout();
            this.gbData.SuspendLayout();
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
            this.gbCurrentStatus.Size = new System.Drawing.Size(439, 148);
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
            this.gbData.Controls.Add(this.btnDownload);
            this.gbData.Location = new System.Drawing.Point(12, 175);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(558, 399);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(6, 19);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 586);
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
    }
}

