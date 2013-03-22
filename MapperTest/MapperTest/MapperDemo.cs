using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

//          --  Usage  --
//
//  1. Ctrl  + Click             -    Add point to map.
//  2. Scroll Wheel              -    Adjust scale of map.
//  3. Click + Drag              -    Move around the map.
//  2. Shift + Click + Drag      -    Scaled Dragging for moving the map.
//                                      Dragging ignores scale factor.
//                                      Useful when scale gets very large or small.

namespace MapperTest
{
    public partial class MapperDemo : Form
    {
        float oldPosX = 0;
        float oldPosY = 0;
        int prevScaleBumpX = 0,
            prevScaleBumpY = 0;
        int bumpX = 0,
            bumpY = 0;
        int oldBumpX = 0,
            oldBumpY = 0;
        int oldMouseX = 0,
            oldMouseY = 0;
        int gridTickSize = 50,
            gridTickCount = 30,
            gridStartX = -500,          // Start/Stop X and Y are adjusted in Form1_Load
            gridStartY = -500,
            gridStopX = 500,
            gridStopY = 500;
        int pointCount = 1;
        List<Point> listPoints;
        List<Point> listGridPoints;
        Bitmap bmp;
        float scale = 1;
        bool firstPoint = true;
        bool mouseDown = false;
        bool drawNewPoint = false;
        bool scaleDrag = true;

        public MapperDemo()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(pbMap_MouseWheel);
            listPoints = new List<Point>();
            listGridPoints = new List<Point>();
        }
        private void MappingForm_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pbMap.Width, pbMap.Height);

            // Center the grid
            gridStartX = -1 * ((gridTickCount * gridTickSize / 2) - (pbMap.Width / 2));
            gridStartY = -1 * ((gridTickCount * gridTickSize / 2) - (pbMap.Height / 2));
            gridStopX = (gridTickCount * gridTickSize / 2) + (pbMap.Width / 2);
            gridStopY = (gridTickCount * gridTickSize / 2) + (pbMap.Height / 2);

            DrawMap();
        }

        // When new encoder data comes in
        private void pbMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (!firstPoint && drawNewPoint)
            {
                oldPosX = (float)(e.X - (bumpX * scale)) / scale;
                oldPosY = (float)(e.Y - (bumpY * scale)) / scale;
                listPoints.Add(new Point((int)oldPosX, (int)oldPosY));

                oldPosX = e.X;
                oldPosY = e.Y;

                pointCount++;
                tbPointCount.Text = "" + pointCount;

                DrawMap();
            }
            else if (drawNewPoint)
            {
                oldPosX = (float)(e.X - (bumpX * scale)) / scale;
                oldPosY = (float)(e.Y - (bumpY * scale)) / scale;
                listPoints.Add(new Point((int)oldPosX, (int)oldPosY));
                oldPosX = e.X;
                oldPosY = e.Y;
                firstPoint = false;
            }
        }
        private void pbMap_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            oldMouseX = e.X;
            oldMouseY = e.Y;
            // If the shift key is held, we need to adjust the old pos.
            //   Otherwise the map will jump around like an idiot.
            if (scaleDrag)
            {
                oldMouseX = (int)(oldMouseX / scale);
                oldMouseY = (int)(oldMouseY / scale);
            }
            if (!drawNewPoint)
                Cursor = Cursors.SizeAll;
            else if (!firstPoint)
                Cursor = Cursors.Default;
        }
        private void pbMap_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            oldBumpX = bumpX;
            oldBumpY = bumpY;
            Cursor = Cursors.Default;
        }
        private void pbMap_MouseMove(object sender, MouseEventArgs e)
        {
            // Drag map around
            if (mouseDown && !drawNewPoint)
            {
                if (scaleDrag)
                {
                    bumpX = (int)((oldBumpX - (oldMouseX - (e.X / scale))));
                    bumpY = (int)((oldBumpY - (oldMouseY - (e.Y / scale))));
                }
                else
                {
                    bumpX = (oldBumpX - (oldMouseX - e.X));
                    bumpY = (oldBumpY - (oldMouseY - e.Y));
                }
                tbBumpX.Text = "" + bumpX;
                tbBumpY.Text = "" + bumpY;
                DrawMap();
            }
            //else if (drawNewPoint && !firstPoint)     // Drag and Draw
            //{
            //    oldPosX = (float)(e.X - (bumpX * scale)) / scale;
            //    oldPosY = (float)(e.Y - (bumpY * scale)) / scale;
            //    listPoints.Add(new Point((int)oldPosX, (int)oldPosY));
            //    DrawMap();
            //}
            tbPosX.Text = "" + e.X;
            tbPosY.Text = "" + e.Y;
        }
        private void pbMap_MouseWheel(object sender, MouseEventArgs e)
        {
            // Re-centers the map after adjusting the scale
            prevScaleBumpX = (int)(((pbMap.Width / 2) - ((pbMap.Width / 2) / scale)));
            prevScaleBumpY = (int)(((pbMap.Height / 2) - ((pbMap.Height / 2) / scale)));
            if (e.Delta > 0)
            {
                scale *= 1.25F;
                bumpX += (-1 * (int)(((pbMap.Width / 2) - ((pbMap.Width / 2) / scale)))) + prevScaleBumpX;
                bumpY += (-1 * (int)(((pbMap.Height / 2) - ((pbMap.Height / 2) / scale)))) + prevScaleBumpY;
            }
            else
            {
                scale /= 1.25F;
                bumpX -= (int)(((pbMap.Width / 2) - ((pbMap.Width / 2) / scale))) - prevScaleBumpX;
                bumpY -= (int)(((pbMap.Height / 2) - ((pbMap.Height / 2) / scale))) - prevScaleBumpY;
            }

            oldBumpX = bumpX;
            oldBumpY = bumpY;

            tbBumpX.Text = "" + bumpX;
            tbBumpY.Text = "" + bumpY;
            tbScale.Text = "" + scale;
            DrawMap();
        }

        private void MappingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                bumpX += 5;
                tbBumpX.Text = "" + bumpX;
                tbBumpY.Text = "" + bumpY;
                DrawMap();
            }
            else if (e.KeyCode == Keys.Right)
            {
                bumpX -= 5;
                tbBumpX.Text = "" + bumpX;
                tbBumpY.Text = "" + bumpY;
                DrawMap();
            }
            else if (e.KeyCode == Keys.Up)
            {
                bumpY += 5;
                tbBumpX.Text = "" + bumpX;
                tbBumpY.Text = "" + bumpY;
                DrawMap();
            }
            else if (e.KeyCode == Keys.Down)
            {
                bumpY -= 5;
                tbBumpX.Text = "" + bumpX;
                tbBumpY.Text = "" + bumpY;
                DrawMap();
            }
            else if (e.KeyCode == Keys.ControlKey)
                drawNewPoint = true;
            else if (e.KeyCode == Keys.ShiftKey)
                scaleDrag = false;
        }
        private void MappingForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                drawNewPoint = false;
            if (e.KeyCode == Keys.ShiftKey)
                scaleDrag = true;
        }

        private void DrawMap()
        {
            // Draw grid background
            try
            {
                bmp = new Bitmap(pbMap.Width, pbMap.Height);
                scale = (float)Convert.ToDouble(tbScale.Text);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    for (int i = 0; i <= gridTickCount; i++)
                    {
                        g.DrawLine(new Pen(Color.Blue, 1),
                            (gridStartX + (i * gridTickSize) + bumpX) * scale,
                            (gridStartY + 0 + bumpY) * scale,
                            (gridStartX + (i * gridTickSize) + bumpX) * scale,
                            (gridStopY + bumpY) * scale);
                    }
                    for (int i = 0; i <= gridTickCount; i++)
                    {
                        g.DrawLine(new Pen(Color.Blue, 1),
                            (gridStartX + 0 + bumpX) * scale,
                            (gridStartY + (i * gridTickSize) + bumpY) * scale,
                            (gridStopX + bumpX) * scale,
                            (gridStartY + (i * gridTickSize) + bumpY) * scale);
                    }
                }
                pbMap.Image = bmp;
            }
            catch (Exception) { }

            // Draw path/map
            if (listPoints.Count > 0)
            {
                try
                {
                    //bmp = new Bitmap(pbMap.Width, pbMap.Height);
                    scale = (float)Convert.ToDouble(tbScale.Text);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        for (int i = 0; i < (listPoints.Count - 1); i++)
                        {
                            g.DrawLine(new Pen(Color.Black, (int)(5 * scale)),
                                (listPoints[i].X + bumpX) * scale,
                                (listPoints[i].Y + bumpY) * scale,
                                (listPoints[i + 1].X + bumpX) * scale,
                                (listPoints[i + 1].Y + bumpY) * scale);
                        }
                    }
                    pbMap.Image = bmp;
                    oldPosX = (listPoints[listPoints.Count - 1].X + bumpX) * scale;
                    oldPosY = (listPoints[listPoints.Count - 1].Y + bumpY) * scale;
                }
                catch (Exception) { }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bmp.Save("test.bmp");
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            bumpX = -1 * (int)(((pbMap.Width / 2) - ((pbMap.Width / 2) / scale)));
            bumpY = -1 * (int)(((pbMap.Height / 2) - ((pbMap.Height / 2) / scale)));
            oldMouseX = 0;
            oldMouseY = 0;
            DrawMap();
            tbBumpX.Text = "" + bumpX;
            tbBumpY.Text = "" + bumpY;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listPoints.Clear();
            pointCount = 1;
            tbPointCount.Text = "0";
            firstPoint = true;
            DrawMap();
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            bumpX = Convert.ToInt32(tbBumpX.Text);
            bumpY = Convert.ToInt32(tbBumpY.Text);
            DrawMap();
        }
        private void btnScale_Click(object sender, EventArgs e)
        {
            DrawMap();
        }

        private void pbMap_SizeChanged(object sender, EventArgs e)
        {
            DrawMap();
        }
    }
}