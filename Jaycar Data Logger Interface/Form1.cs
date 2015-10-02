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
            lblWatts.Text =   string.Format("Watts   : {0:000.00}W", logger.Current.Watts);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPorts.Items.Clear();
            foreach (var p in SerialPort.GetPortNames())
                cbPorts.Items.Add(p);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            logger.requestDump();//send the request for a datadump
        }
    }
}
