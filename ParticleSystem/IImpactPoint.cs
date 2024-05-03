using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public abstract class IImpactPoint
    {
        public float X; 
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.White),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; 

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2) 
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.White),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.White),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class Teleport : IImpactPoint
    {
        public int R, X2, Y2,direction;
        public override void Render(Graphics g)
        {
            //вход
            g.DrawEllipse(new Pen(Color.Pink, 4), X - R / 2, Y - R / 2, R, R);
            //выход
            g.DrawEllipse(new Pen(Color.DeepPink, 4), X2 - R / 2, Y2 - R / 2, R, R);
            Point[] points =
             {
                 new Point((int)(X),(int)(Y)),
                 new Point((int)(X2),(int)(Y2)),
             };
        }

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            var points = new[] { new PointF(gX, gY), new PointF(particle.SpeedX, particle.SpeedY) };

            if (r + particle.Radius < R / 2) 
            {
                particle.X = X2 - points[0].X;
                particle.Y = Y2 - points[0].Y;

                var m = new Matrix();
                m.Rotate(direction);
                m.TransformPoints(points);

                particle.SpeedX = points[1].X;
                particle.SpeedY = points[1].Y;
            }


        }
    }

    public class ColorCirlce : IImpactPoint
    {
        public int R;
        public Color pen;
        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(pen, 4), X - R / 2, Y - R / 2, R, R);
        }

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            var colorParticle = (ParticleColorful)particle;

            if (r + particle.Radius < R / 2) 
            {
                colorParticle.FromColor = pen;
                colorParticle.ToColor = Color.FromArgb(0, Color.DeepPink);
            }
        }
    }

    public class Radar : IImpactPoint
    {
        public int R, cnt = 0;
        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Aquamarine, 4), X - R / 2, Y - R / 2, R, R);
            var stringFormat = new StringFormat(); 
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center; 

            g.DrawString($"{cnt}", new Font("Verdana", 20), new SolidBrush(Color.DeepPink), X, Y, stringFormat);
        }
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            Color a;
            Color b;

            var colorParticle = (ParticleColorful)particle;
            if(colorParticle.FromColor != Color.Aquamarine && colorParticle.ToColor != Color.Aquamarine)
            {
                a = colorParticle.FromColor;
                b = colorParticle.ToColor;
            }
            else
            {
                a = Color.Indigo;
                b = Color.DeepPink;
            }
            colorParticle.FromColor = a;
            colorParticle.ToColor = b;

            if (r + particle.Radius < R / 2)           
            { 
                cnt++;

                colorParticle.FromColor = Color.Aquamarine;
                colorParticle.ToColor = Color.FromArgb(0, Color.Aquamarine);
            }


        }
    }
}
