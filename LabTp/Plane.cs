using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTp
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Plane : Vehicle, IComparable<Plane>, IEquatable<Plane>
    {


        private const int planeWidth = 110;

        private const int planeHeight = 185;
        
        public bool Kol { protected set; get; }

        public bool OsnPl { private set; get; }

        public Plane(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool radar, bool kol, bool osnPl)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

            Kol = kol;
            OsnPl = osnPl;
        }

        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }



        public Plane(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }



        public override void MoveTransport(Direction direction)
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

        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawEllipse(pen, _startPosX, _startPosY + 65, 110, 50);

            Brush korpus = new SolidBrush(MainColor);
            g.FillEllipse(korpus, _startPosX, _startPosY + 65, 110, 50);

            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 132, 20, 20);
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 132, 20, 20);
            g.DrawLine(pen, _startPosX + 75, _startPosY + 145, _startPosX + 70, _startPosY + 115);
            g.DrawLine(pen, _startPosX + 35, _startPosY + 145, _startPosX + 40, _startPosY + 115);
            Brush kol = new SolidBrush(MainColor);
            g.FillEllipse(kol, _startPosX + 70, _startPosY + 132, 20, 20);
            g.FillEllipse(kol, _startPosX + 20, _startPosY + 132, 20, 20);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(Plane other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Plane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)

            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Plane carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
