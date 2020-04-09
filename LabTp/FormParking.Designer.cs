namespace LabTp
{
    partial class FormParking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakePlanes = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxNomber = new System.Windows.Forms.MaskedTextBox();
            this.labelMesto = new System.Windows.Forms.Label();
            this.listBoxPlane = new System.Windows.Forms.ListBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlanes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-2, 47);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(832, 564);
            this.pictureBoxParking.TabIndex = 1;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.pictureBoxTakePlanes);
            this.groupBoxParking.Controls.Add(this.buttonTake);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxNomber);
            this.groupBoxParking.Controls.Add(this.labelMesto);
            this.groupBoxParking.Location = new System.Drawing.Point(836, 177);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(285, 434);
            this.groupBoxParking.TabIndex = 4;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать самолет";
            // 
            // pictureBoxTakePlanes
            // 
            this.pictureBoxTakePlanes.Location = new System.Drawing.Point(10, 105);
            this.pictureBoxTakePlanes.Name = "pictureBoxTakePlanes";
            this.pictureBoxTakePlanes.Size = new System.Drawing.Size(239, 323);
            this.pictureBoxTakePlanes.TabIndex = 3;
            this.pictureBoxTakePlanes.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(10, 63);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(84, 34);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxNomber
            // 
            this.maskedTextBoxNomber.Location = new System.Drawing.Point(70, 31);
            this.maskedTextBoxNomber.Name = "maskedTextBoxNomber";
            this.maskedTextBoxNomber.Size = new System.Drawing.Size(51, 26);
            this.maskedTextBoxNomber.TabIndex = 1;
            // 
            // labelMesto
            // 
            this.labelMesto.Location = new System.Drawing.Point(6, 31);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(58, 31);
            this.labelMesto.TabIndex = 0;
            this.labelMesto.Text = "Место";
            // 
            // listBoxPlane
            // 
            this.listBoxPlane.FormattingEnabled = true;
            this.listBoxPlane.ItemHeight = 20;
            this.listBoxPlane.Location = new System.Drawing.Point(1018, 47);
            this.listBoxPlane.Name = "listBoxPlane";
            this.listBoxPlane.Size = new System.Drawing.Size(120, 124);
            this.listBoxPlane.TabIndex = 7;
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(836, 99);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(154, 72);
            this.buttonSetPlane.TabIndex = 8;
            this.buttonSetPlane.Text = "Добавить самолет";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.загрузитьToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.сохранитьToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(182, 30);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt file | *.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 623);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.listBoxPlane);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlanes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxTakePlanes;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomber;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.ListBox listBoxPlane;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}