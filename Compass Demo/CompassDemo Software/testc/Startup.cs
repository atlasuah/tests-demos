using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace CompassDemo
{
    public partial class Startup : Form
    {
        public string port = "6";
        public string baud = "115200";
        public Startup()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            port = tbPort.Text;
            baud = tbBaud.Text;
            var portNames = SerialPort.GetPortNames();

            foreach (var p in portNames)
            {
                if (p == ("COM" + port))
                    Close();
            }
        }
    }
}
