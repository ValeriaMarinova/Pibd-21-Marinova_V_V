using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTp
{
    
    public class Plane
    {

        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private const int planeWidth = 110;

        private const int planeHeight = 185;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Radar { private set; get; }

        public bool Kol { private set; get; }


        public bool OsnPl { private set; get; }

        public Plane(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool radar, bool kol, bool osnPl)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Radar = radar;
            Kol = kol;
            OsnPl = osnPl;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if (Radar)
            {
                g.DrawLine(pen, _startPosX + 70, _startPosY + 75, _startPosX + 70, _startPosY + 30);
                g.DrawEllipse(pen, _startPosX + 27, _startPosY, 90, 30);
                g.DrawLine(pen, _startPosX + 35, _startPosY + 105, _startPosX, _startPosY + 50);
                g.DrawLine(pen, _startPosX + 60, _startPosY + 95, _startPosX, _startPosY + 50);

                Brush radar = new SolidBrush(DopColor);
                g.FillEllipse(radar, _startPosX + 27, _startPosY, 90, 30);

            }
            if (OsnPl)
            {
                g.DrawEllipse(pen, _startPosX, _startPosY + 75, 110, 50);
                Brush korpus = new SolidBrush(DopColor);
                g.FillEllipse(korpus, _startPosX, _startPosY + 75, 110, 50);

            }
            if (Kol)

            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 165, 20, 20);
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 165, 20, 20);
            g.DrawLine(pen, _startPosX + 75, _startPosY + 165, _startPosX + 70, _startPosY + 125);
            g.DrawLine(pen, _startPosX + 35, _startPosY + 165, _startPosX + 40, _startPosY + 125);
            Brush kol = new SolidBrush(MainColor);
            g.FillEllipse(kol, _startPosX + 70, _startPosY + 165, 20, 20);
            g.FillEllipse(kol, _startPosX + 20, _startPosY + 165, 20, 20);


        }


    }
}


   
