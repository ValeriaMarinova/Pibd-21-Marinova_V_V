using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTp
{
    public class Parking<T> where T : class, ITransport
    {

        private Dictionary<int, T> _places;

        private int _maxCount;


        private int PictureWidth { get; set; }

        private int PictureHeight { get; set; }

        private const int _placeSizeWidth = 350;

        private const int _placeSizeHeight = 150;

        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;

        }

        public static int operator +(Parking<T> p, T plane)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, plane);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }



        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T plane = p._places[index];
                p._places.Remove(index);

                return plane;
            }
            return null;

        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawPlane(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 630);
            for (int i = 0; i < _maxCount / 5; i++)
            {
                for (int j = 0; j < 10; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }


        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5
                    * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
            }
        }
    }
}



