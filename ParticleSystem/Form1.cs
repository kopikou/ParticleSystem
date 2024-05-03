using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        Teleport teleport;
        ColorCirlce colorCircle1;
        ColorCirlce colorCircle2;
        ColorCirlce colorCircle3;
        Radar radar;

        GravityPoint point1;
        AntiGravityPoint point2;

        public Form1()
        {
            InitializeComponent();
            picDisplay.MouseWheel += picDisplay_MouseWheel;

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter 
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Indigo,
                ColorTo = Color.FromArgb(0, Color.DeepPink),
                ParticlesPerTick = 10,
                X = 0,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);

            teleport = new Teleport
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                R = 75,
                X2 = picDisplay.Width / 2,
                Y2 = picDisplay.Height * 7 / 10,
                direction = 0,
            };
            emitter.impactPoints.Add(teleport);

            colorCircle1 = new ColorCirlce
            {
                X = picDisplay.Width - picDisplay.Width / 3,
                Y = picDisplay.Height - picDisplay.Height / 5,
                R = 100,
                pen = Color.White,
            };
            emitter.impactPoints.Add(colorCircle1);

            colorCircle2 = new ColorCirlce
            {
                X = picDisplay.Width - picDisplay.Width / 3,
                Y = picDisplay.Height / 2,
                R = 100,
                pen = Color.DimGray,
            };
            emitter.impactPoints.Add(colorCircle2);

            colorCircle3 = new ColorCirlce
            {
                X = picDisplay.Width - picDisplay.Width / 3,
                Y = picDisplay.Height / 5,
                R = 100,
                pen = Color.DeepSkyBlue,
            };
            emitter.impactPoints.Add(colorCircle3);

            radar = new Radar
            {
                X = picDisplay.Width + 200,
                Y = picDisplay.Height + 200,
                R = 75,
            };
            emitter.impactPoints.Add(radar);

            /*point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };*/
            point2 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

           // emitter.impactPoints.Add(point1);
            //emitter.impactPoints.Add(point2);
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            radar.cnt = 0;
            //emitter.UpdateState();

            emitter.UpdateState();
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();

            
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            /*foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            point2.X = e.X;
            point2.Y = e.Y;*/
            radar.X = e.X;
            radar.Y = e.Y;
        }
        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                radar.R = radar.R + 5;
            }
            else
            {
                if (radar.R > 30)
                {
                    radar.R = radar.R - 5;
                }
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            lblSpreading.Text = $"{tbSpreading.Value}°";
        }

        private void tbTeleportR_Scroll(object sender, EventArgs e)
        {;
            teleport.R = tbTeleportR.Value;
            lbTeleportR.Text = $"{tbTeleportR.Value}";
        }

        private void tbTeleportDirection_Scroll(object sender, EventArgs e)
        {
            teleport.direction = tbTeleportDirection.Value;
            lbTeleportDirection.Text = $"{tbTeleportDirection.Value}°";
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                teleport.X = e.X;
                teleport.Y = e.Y;
            }
            if (e.Button == MouseButtons.Right)
            {
                teleport.X2 = e.X;
                teleport.Y2 = e.Y;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbColorCirclePosition_Scroll(object sender, EventArgs e)
        {
            colorCircle1.X = tbColorCirclePosition.Value;
            colorCircle2.X = tbColorCirclePosition.Value;
            colorCircle3.X = tbColorCirclePosition.Value;
        }
    }
}
