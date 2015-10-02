using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Threading;
namespace Jaycar_Data_Logger_Interface
{
    class DataLogger
    {
        SerialPort _port = new SerialPort();
        public currentStatus Current = new currentStatus();
        Thread dataUpdater;
        List<dataLogg> dataLoggReadings = new List<dataLogg> { };
        public event DownloadDoneHandler DownloadDone;
        public delegate void DownloadDoneHandler();

        public bool isOpen()
        {
            return _port.IsOpen;
        }
        public void close()
        {
            lock (_port)
            {
                _port.Close();
            }
        }
        public DataLogger()
        {
        }
        /// <summary>
        /// Creates a new object and connects via serial
        /// </summary>
        /// <param name="comPort">Com Port to use</param>
        public DataLogger(string comPort)
        {
            _port = new SerialPort(comPort.Trim());
            _port.BaudRate = 9600;
            //8N1 comms
            _port.Handshake = Handshake.None;
            _port.DataBits = 8;
            _port.StopBits = StopBits.One;
            _port.DataReceived += _port_DataReceived;
            _port.Open();
            dataUpdater = new Thread(new ThreadStart(updaterThreadTask));
            requestCurrentStatus();
            dataUpdater.Start();
        }
        void updaterThreadTask()
        {
            while (_port.IsOpen)
            {
                lock (_port)
                {
                    requestCurrentStatus();
                }
                System.Threading.Thread.Sleep(300);
            }
        }
        /// <summary>
        /// Sends the request to view the screen data
        /// </summary>
        void requestCurrentStatus()
        {
            byte[] buffer = new byte[] { 0x47, 0x56, 0x43, 0x57, 0x0D };
            _port.Write(buffer, 0, buffer.Length);//send the request
        }
        public void requestDump()
        {
            dataLoggReadings.Clear();
            byte[] buffer = new byte[] { 0x47, 0x44, 0x41, 0x54, 0x30, 0x30, 0x30, 0x30, 0x0D };
            _port.Write(buffer, 0, buffer.Length);//send the request
        }
        void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //here we need to handle the incoming data
            while (_port.BytesToRead > 2)
            {
                string m = _port.ReadTo("" + (char)0x0D);
                processMessage(m);//send it off to be stored
            }
        }

        void processMessage(string message)
        {
            if (message.StartsWith("  "))//status starts with 0x20 0x20
            {
                if (message.EndsWith("V"))
                {//voltage
                    Current.Voltage = float.Parse(message.Replace("V", "").Trim());
                }
                else if (message.EndsWith("W"))
                {//voltage
                    Current.Watts = float.Parse(message.Replace("W", "").Trim());
                }
                else if (message.EndsWith("A"))
                {//voltage
                    Current.Current = float.Parse(message.Replace("A", "").Trim());
                }
            }
            else
            {
                //This is part of a datadump
                //so we add it to the list until we hit an end segmet
                if (message.Contains("OK"))
                {//end of transmission, could mean that we need to check the lists
                    if (dataLoggReadings.Count > 0)
                        if (dataLoggReadings[dataLoggReadings.Count - 1].readings.Count == 0)
                        {
                            dataLoggReadings.RemoveAt(dataLoggReadings.Count - 1);
                            //we hit here when we have finished a download
                            if (DownloadDone != null)
                                DownloadDone();
                            //fired off event if it is subscribed to
                        }
                }
                else if (message.Contains("Vp"))
                {
                    //This is the end of the section
                    //store the final values at the end
                    int i = dataLoggReadings.Count - 1;
                    dataLoggReadings[i].VoltMax = float.Parse(message.Substring(0, message.IndexOf("Vp")));
                    message = message.Substring(message.IndexOf("Vp") + 2);
                    dataLoggReadings[i].AmpMax = float.Parse(message.Substring(0, message.IndexOf("Ap")));
                    message = message.Substring(message.IndexOf("Ap") + 2);
                    dataLoggReadings[i].VoltMin = float.Parse(message.Substring(0, message.IndexOf("Vm")));
                    message = message.Substring(message.IndexOf("Vm") + 2);
                    dataLoggReadings[i].AmpMin = float.Parse(message.Substring(0, message.IndexOf("Am")));
                    message = message.Substring(message.IndexOf("Am") + 2);
                    dataLoggReadings[i].WattPeak = float.Parse(message.Substring(0, message.IndexOf("Wp")));
                    message = message.Substring(message.IndexOf("Wp") + 2);
                    dataLoggReadings[i].TimeBase = int.Parse(message.Substring(0, message.IndexOf("s")));
                }
                else if (message.Contains("START"))
                {
                    //make room for next one
                    dataLoggReadings.Add(new dataLogg());
                    dataLoggReadings[dataLoggReadings.Count - 1].readings = new List<reading>();

                }
                else if (message.Contains("V"))
                {
                    if (dataLoggReadings.Count == 0)
                    {
                        dataLoggReadings.Add(new dataLogg());
                        dataLoggReadings[dataLoggReadings.Count - 1].readings = new List<reading>();

                    }
                    reading r = new reading();
                    r.Voltage = float.Parse(message.Substring(0, message.IndexOf("V")));
                    message = message.Substring(message.IndexOf("V") + 1);
                    r.Current = float.Parse(message.Substring(0, message.IndexOf("A")));
                    dataLoggReadings[dataLoggReadings.Count - 1].readings.Add(r);//store the reading


                }
            }
        }
    }
    class currentStatus
    {
        public float Current, Voltage, Watts;
    }
    class dataLogg
    {
        public List<reading> readings;
        public float VoltMax, AmpMax, VoltMin, AmpMin, WattPeak;
        public int TimeBase;
    }
    class reading
    {
        public float Voltage, Current;
    }
}
