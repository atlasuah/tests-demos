using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace XBeeTester
{
    public partial class Form1 : Form
    {
        private SerialPort sPort;
        private int expected = 0, rec = 0, total = 0;
        double percent = 0.0;

        public Form1()
        {
            InitializeComponent();
            sPort = new SerialPort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sPort.PortName = "COM7";
            sPort.BaudRate = Convert.ToInt32(57600);
            sPort.Parity = Parity.None;
            sPort.StopBits = StopBits.One;
            sPort.DataBits = 8;
            sPort.Handshake = Handshake.None;
            sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);
        }

        // This event gets fired on a seperate thread.
        private void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int data = Convert.ToInt32(sPort.ReadLine());
            if (data != expected)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                    {
                        rtbError.AppendText("expected: " + expected + "   read: " + data + "\r\n");
                        rec += (data - expected);
                        total = data;
                        tbTotal.Text = total.ToString();
                        tbRecieved.Text = rec.ToString();
                        tbPercent.Text = ((double)((double)rec / (double)total)*100).ToString();
                        expected = ++data;
                    }));
            }
            else
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                    {
                        rtbOutput.AppendText("" + data + "\r\n");
                        expected++;
                    }));
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            sPort.Open();
            rtbOutput.AppendText("  **  Connected to  " + sPort.PortName + "  **\r\n");
        }
    }
}
