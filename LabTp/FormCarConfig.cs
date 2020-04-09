using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTp
{
    public partial class FormPlaneConfig : Form
    {
        ITransport plane = null;
        private event planeDelegate eventAddPlane;

        public FormPlaneConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelVinous.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(0, 0, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawPlane(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        public void AddEvent(planeDelegate ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new planeDelegate(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void LablePlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move |
    DragDropEffects.Copy);
        }
        private void labelPlaneWithRadar_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlaneWithRadar.DoDragDrop(labelPlaneWithRadar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    plane = new Plane(100, 500, Color.Yellow);
                    break;
                case "Самолет с радаром":
                    plane = new PlaneWithRadar(100, 500, Color.Yellow, Color.Black, true, true, true);
                    break;
            }

            DrawPlane();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            var c = (sender as Panel);
            c.DoDragDrop(c.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void lableMainColor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lableMainColor_DragDrop(object sender, DragEventArgs e)
        {
            var color = (Color)e.Data.GetData(typeof(Color));
            (plane as Plane).SetMainColor(color);
            DrawPlane();
            labelMainColor.BackColor = color;

        }
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("fired");
            var color = (Color)e.Data.GetData(typeof(Color));

            if (plane is PlaneWithRadar)
            {
                labelDopColor.BackColor = color;

                (plane as PlaneWithRadar).SetDopColor(color);
                DrawPlane();
            }
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {

            eventAddPlane?.Invoke(plane);
            Close();
        }

      
      
    }
}

