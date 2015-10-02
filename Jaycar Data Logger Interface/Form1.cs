using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaycar_Data_Logger_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataLogger logger = new DataLogger();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (logger.isOpen())
            {
                logger.close();
                btnOpen.Text = "Open";
            }
            else
                if (cbPorts.Text.Length > 3)
                {

                    try
                    {
                        //open the port
                        logger = new DataLogger(cbPorts.Text);
                        logger.DownloadDone += logger_DownloadDone;
                        gbData.Enabled = true;
                    }
                    catch { }
                    finally
                    {
                        if (logger.isOpen())
                        {
                            btnOpen.Text = "Close";
                            timerUpdateView.Start();
                        }
                    }
                }
        }




        private void timerUpdateView_Tick(object sender, EventArgs e)
        {
            //We need to update the view
            lblCurrent.Text = string.Format("Current : {0:000.00}A", logger.Current.Current);
            lblVoltage.Text = string.Format("Voltage : {0:000.00}V", logger.Current.Voltage);
            lblWatts.Text = string.Format("Watts   : {0:000.00}W", logger.Current.Watts);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPorts.Items.Clear();
            foreach (var p in SerialPort.GetPortNames())
                cbPorts.Items.Add(p);
            this.FormClosing += Form1_FormClosing;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            logger.requestDump();//send the request for a datadump
            btnDownload.Text = "Downloading";
        }
        void logger_DownloadDone()
        {

            //The unit has downloaded all of its data so we should display it
            //enumeratre the cb
            if (this.InvokeRequired)
            {
                MethodInvoker mI = new MethodInvoker(logger_DownloadDone);
                this.Invoke(mI);
            }
            else
            {
                btnDownload.Text = "Download";
                cbDataSet.Items.Clear();
                for (int i = 0; i < logger.dataLoggReadings.Count; i++)
                    cbDataSet.Items.Add("Item " + (i + 1).ToString());
                if (logger.dataLoggReadings.Count > 0)
                    cbDataSet.SelectedIndex = 0;
                gbDataSet.Enabled = true;
                dataGridView.Enabled = true;
                //auto select the first one
            }
        }
        private void cbDataSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //they have chosen a data set
            if (cbDataSet.SelectedIndex >= 0)
            {//we have a valid entry id
                reDrawDataGrid(cbDataSet.SelectedIndex);//fill the grid
                //now we need to fill out the text box
                txtDataInfo.Text = "";
                txtDataInfo.Text += string.Format("V Peak : {0:0000.00} V\r\n", logger.dataLoggReadings[cbDataSet.SelectedIndex].VoltMax);
                txtDataInfo.Text += string.Format("V Min  : {0:0000.00} V\r\n", logger.dataLoggReadings[cbDataSet.SelectedIndex].VoltMin);
                txtDataInfo.Text += string.Format("A Peak : {0:0000.00} A\r\n", logger.dataLoggReadings[cbDataSet.SelectedIndex].AmpMax);
                txtDataInfo.Text += string.Format("A Min  : {0:0000.00} A\r\n", logger.dataLoggReadings[cbDataSet.SelectedIndex].AmpMin);
                txtDataInfo.Text += string.Format("W Peak : {0:0000.00} W\r\n", logger.dataLoggReadings[cbDataSet.SelectedIndex].WattPeak);
                txtDataInfo.Text += string.Format("Sample : {0} S", logger.dataLoggReadings[cbDataSet.SelectedIndex].TimeBase);

            }
        }
        private void reDrawDataGrid(int index)
        {
            dataGridView.Rows.Clear();
            int count = 0;
            foreach (var r in logger.dataLoggReadings[index].readings)
            {
                dataGridView.Rows.Add(count.ToString(), r.Voltage.ToString("000.00") + " V", r.Current.ToString("000.00") + " A" , (r.Current * r.Voltage).ToString("0000.00") + "W");
                count++;
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            if (cbDataSet.SelectedIndex >= 0)
            {
                //we have our data to export
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = false;
                dlg.DefaultExt = "";
                dlg.Title = "Save Data As";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //they have chosen a location
                    string baseFile = dlg.FileName;
                    using (var sw = new System.IO.StreamWriter(baseFile + ".csv"))
                    {
                        sw.Write(logger.dataLoggReadings[cbDataSet.SelectedIndex].toCSVReadings());
                    }
                    using (var sw = new System.IO.StreamWriter(baseFile + ".meta.csv"))
                    {
                        sw.Write(logger.dataLoggReadings[cbDataSet.SelectedIndex].toCSVMeta());
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ralim/JaycarPowerMeterMS6174");
        }
    }
}
