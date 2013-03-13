using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace CompassDemo
{
    public partial class CompassDemo : Form
    {
        string PORT = "6";
        int BAUD = 115200;
        double cX = 250,
            cY = 250;
        double pX = 100,
            pY = 100;
        double deg = 0;
        double mag = 200;
        SerialPort sPort;

        public CompassDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startup startDiaglog = new Startup();
            startDiaglog.ShowDialog();
            PORT = startDiaglog.port;
            BAUD = Convert.ToInt32(startDiaglog.baud);
            try
            {
                sPort = new SerialPort();
                sPort.PortName = "COM" + PORT;
                sPort.BaudRate = BAUD;
                sPort.Parity = Parity.None;
                sPort.StopBits = StopBits.One;
                sPort.DataBits = 8;
                sPort.Handshake = Handshake.None;
                sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);
                sPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Failed to open COM port " + PORT);
            }
        }

        private void sPort_DataReceived(object sender, EventArgs e)
        {
            string tmpData = "";
            try
            {
                tmpData = sPort.ReadLine();
                this.Invoke(new MethodInvoker(delegate
                    {
                        deg = Convert.ToDouble(tmpData);
                        pX = (mag * Math.Cos(deg * Math.PI / 180)) + cY;
                        pY = (-1 * mag * Math.Sin(deg * Math.PI / 180)) + cY;
                        Bitmap bmp = new Bitmap(pbCompass.Width, pbCompass.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.DrawLine(new Pen(Color.Red, 8), (float)cX, (float)cY, (float)pX, (float)pY);
                        }
                        pbCompass.Image = bmp;
                    }));
            }
            catch (Exception)
            { }
        }
    }
}
