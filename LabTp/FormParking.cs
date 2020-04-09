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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void SetPlane_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                int place = parking + plane;
                Draw();
            }
        }


        private void buttonSetPlaneWithRadar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new PlaneWithRadar(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    int place = parking + plane;
                    Draw();
                }
            }
        }

        private void buttonTake_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBoxNomber.Text != "")
            {
                var plane = parking - Convert.ToInt32(maskedTextBoxNomber.Text);
                if (plane != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlanes.Width,
                   pictureBoxTakePlanes.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    plane.SetPosition(5, 5, pictureBoxTakePlanes.Width,
                   pictureBoxTakePlanes.Height);
                    plane.DrawPlane(gr);
                    pictureBoxTakePlanes.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlanes.Width,
                   pictureBoxTakePlanes.Height);
                    pictureBoxTakePlanes.Image = bmp;
                }
                Draw();
            }
        }

       
    }
}


