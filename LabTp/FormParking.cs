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

        MultiLevelParking parking;

        FormPlaneConfig form;

        private const int countLevel = 5;

        public FormParking()

        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxPlane.Items.Add("Уровень " + (i + 1));
            }
            listBoxPlane.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxPlane.SelectedIndex > -1)
            {

                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxPlane.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void SetPlane_Click(object sender, EventArgs e)
        {
            if (listBoxPlane.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane(100, 1000, dialog.Color);
                    int place = parking[listBoxPlane.SelectedIndex] + plane;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void SetPlaneWithRadar_Click(object sender, EventArgs e)
        {
            if (listBoxPlane.SelectedIndex > -1)
            {

                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new PlaneWithRadar(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true);
                        int place = parking[listBoxPlane.SelectedIndex] + plane;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxPlane.SelectedIndex > -1)
            {
                if (maskedTextBoxNomber.Text != "")
                {
                    var plane = parking[listBoxPlane.SelectedIndex] -
                   Convert.ToInt32(maskedTextBoxNomber.Text);
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


        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

            Draw();

        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            form = new FormPlaneConfig();
            form.AddEvent(AddPlane);
            form.Show();
        }

        private void AddPlane(ITransport plane)
        {
            if (plane != null && listBoxPlane.SelectedIndex > -1)
            {
                int place = parking[listBoxPlane.SelectedIndex] + plane;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {

                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }

       
       
    }
    }
 




