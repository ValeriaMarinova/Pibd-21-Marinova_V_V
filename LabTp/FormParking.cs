using NLog;
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

        private Logger logger;

        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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

        private void buttonTake_Click(object sender, EventArgs e)
        
            {
            if (listBoxPlane.SelectedIndex > -1)
            {
                if (maskedTextBoxNomber.Text != "")
                {
                    try
                    {
                        var plane = parking[listBoxPlane.SelectedIndex] -
                       Convert.ToInt32(maskedTextBoxNomber.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakePlanes.Width,
                       pictureBoxTakePlanes.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        plane.SetPosition(5, 5, pictureBoxTakePlanes.Width,
                       pictureBoxTakePlanes.Height);
                        plane.DrawPlane(gr);
                        pictureBoxTakePlanes.Image = bmp;
                        logger.Info("Изъят самолет " + plane.ToString() + " с места "
                       + maskedTextBoxNomber.Text);
                        Draw();

                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakePlanes.Width,
                       pictureBoxTakePlanes.Height);
                        pictureBoxTakePlanes.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listBoxPlane_SelectedIndexChanged_1(object sender, EventArgs e)
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
                try
                {
                    int place = parking[listBoxPlane.SelectedIndex] + plane;
                    logger.Info("Добавлен самолет " + plane.ToString() + " на место "
                    + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {

                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }

       
    }
}

