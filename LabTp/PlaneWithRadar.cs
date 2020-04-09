using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTp
{
    public class PlaneWithRadar : Plane, IComparable<PlaneWithRadar>, IEquatable<PlaneWithRadar>
    {
        public Color DopColor { private set; get; }

        public bool Radar { private set; get; }

        public bool Kol { private set; get; }

        public bool OsnOpane { private set; get; }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        private int _countLines;
        public int CountLines
        {
            set
            {
                if (value > 0 && value < 4) _countLines = value;
            }
            get { return _countLines; }
        }

        public PlaneWithRadar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool radar, bool kol, bool osnPlane) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Radar = radar;
            Kol = kol;
            OsnOpane = osnPlane;


        }

        public PlaneWithRadar(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Radar = Convert.ToBoolean(strs[4]);
                OsnOpane = Convert.ToBoolean(strs[5]);
                Kol = Convert.ToBoolean(strs[6]);
            }
        }


        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);

            g.DrawLine(pen, _startPosX + 70, _startPosY + 55, _startPosX + 70, _startPosY + 30);
            g.DrawEllipse(pen, _startPosX + 27, _startPosY, 70, 30);
            g.DrawLine(pen, _startPosX + 35, _startPosY + 105, _startPosX, _startPosY + 50);
            g.DrawLine(pen, _startPosX + 60, _startPosY + 95, _startPosX, _startPosY + 50);

            Brush radar = new SolidBrush(DopColor);
            g.FillEllipse(radar, _startPosX + 20, _startPosY, 90, 30);

            g.DrawEllipse(pen, _startPosX, _startPosY + 55, 110, 50);
            Brush korpus = new SolidBrush(MainColor);
            g.FillEllipse(korpus, _startPosX, _startPosY + 55, 110, 50);

            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 116, 20, 20);
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 116, 20, 20);
            g.DrawLine(pen, _startPosX + 75, _startPosY + 135, _startPosX + 70, _startPosY + 106);
            g.DrawLine(pen, _startPosX + 35, _startPosY + 135, _startPosX + 40, _startPosY + 106);
            Brush kol = new SolidBrush(MainColor);
            g.FillEllipse(kol, _startPosX + 70, _startPosY + 116, 20, 20);
            g.FillEllipse(kol, _startPosX + 20, _startPosY + 116, 20, 20);
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Radar + ";" +
           OsnOpane + ";" + Kol;
        }

        public int CompareTo(PlaneWithRadar other)
        {
            var res = (this is Plane).CompareTo(other is Plane);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Radar != other.Radar)
            {
                return Radar.CompareTo(other.Radar);
            }
            if (Kol != other.Kol)
            {
                return Kol.CompareTo(other.Kol);
            }
            if (OsnOpane != other.OsnOpane)
            {
                return OsnOpane.CompareTo(other.OsnOpane);
            }
            return 0;
        }

        public bool Equals(PlaneWithRadar other)
        {
            var res = (this as Plane).Equals(other as Plane);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Radar != other.Radar)
            {
                return false;
            }

            if (Kol != other.Kol)
            {
                return false;
            }
            if (OsnOpane != other.OsnOpane)
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
            if (!(obj is PlaneWithRadar carObj))
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


