using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SlimDX.DirectInput;
using System.Threading;

namespace JoystickTest
{
    public partial class Form1 : Form
    {
        private Joystick jS;
        public Thread joystickThread;
        public int x = 0, y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleJoystick();
            button1.Enabled = false;
            joystickThread = new Thread(new ThreadStart(this.UpdateJoystick));
            joystickThread.Start();
        }

        public JoystickState State
        {
            get
            {
 
                if (jS.Acquire().IsFailure)
                    throw new Exception("Joystick failure");
 
                if (jS.Poll().IsFailure)
                    throw new Exception("Joystick failure");
 
                return jS.GetCurrentState();
            }
        }
 
        /// 
        /// Construct, attach the joystick
        /// 
        public void SimpleJoystick()
        {
            DirectInput dinput = new DirectInput();
 
            // Search for device
            foreach (DeviceInstance device in dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                // Create device
                try
                {
                    jS = new Joystick(dinput, device.InstanceGuid);
                    break;
                }
                catch (DirectInputException)
                {
                }
            }
 
            if (jS == null)
                throw new Exception("No joystick found");
 
            foreach (DeviceObjectInstance deviceObject in jS.GetObjects())
            {
                if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                    jS.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
            }
 
            // Acquire sdevice
            jS.Acquire();
            label1.Text = "Joystick Acquired!";
        }
 
        /// 
        /// Release joystick
        /// 
        public void Release()
        {
            if (jS != null)
            {
                jS.Unacquire();
                jS.Dispose();
            }
 
            jS = null;
        }

        private void UpdateJoystick()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(1);
                    this.Invoke((MethodInvoker)delegate
                    {
                        tbVelocityX.Text = State.X.ToString();
                        tbVelocityY.Text = State.Y.ToString();
                        if (State.IsPressed(0))
                        {
                            label1.Text = "Pressed";

                            if (pbDrawing.Image == null)
                            {
                                Bitmap bmp = new Bitmap(pbDrawing.Width, pbDrawing.Height);
                                using (Graphics g = Graphics.FromImage(bmp))
                                {
                                    g.Clear(Color.White);
                                }
                                pbDrawing.Image = bmp;
                            }
                            using (Graphics g = Graphics.FromImage(pbDrawing.Image))
                            {
                                g.FillEllipse(Brushes.Black, 100 - (State.X * -1), 100 - (State.Y * -1), 5, 5);
                                tbDrawingX.Text = "" + (100 - (State.X * -1));
                                tbDrawingY.Text = "" + (100 - (State.Y * -1));
                            }
                            pbDrawing.Invalidate();
                        }
                        else if (State.IsReleased(0))
                        {
                            label1.Text = "Released";
                        }
                    });
                }
            }
            catch (ThreadAbortException)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                joystickThread.Abort();
            }
            catch (Exception)
            { }
        }
    }
}
