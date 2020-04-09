namespace LabTp
{
    partial class FormPlaneConfig
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
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.labelPlane = new System.Windows.Forms.Label();
            this.labelPlaneWithRadar = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelVinous = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.groupBoxPlane.SuspendLayout();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.labelPlane);
            this.groupBoxPlane.Controls.Add(this.labelPlaneWithRadar);
            this.groupBoxPlane.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Size = new System.Drawing.Size(200, 247);
            this.groupBoxPlane.TabIndex = 2;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Наличие радара";
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(34, 60);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(143, 71);
            this.labelPlane.TabIndex = 13;
            this.labelPlane.Text = "Самолет";
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LablePlane_MouseDown);
            // 
            // labelPlaneWithRadar
            // 
            this.labelPlaneWithRadar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlaneWithRadar.Location = new System.Drawing.Point(25, 162);
            this.labelPlaneWithRadar.Name = "labelPlaneWithRadar";
            this.labelPlaneWithRadar.Size = new System.Drawing.Size(152, 66);
            this.labelPlaneWithRadar.TabIndex = 2;
            this.labelPlaneWithRadar.Text = "Самолет с радаром";
            this.labelPlaneWithRadar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlaneWithRadar_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 265);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(95, 45);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(70, 316);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 44);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.labelDopColor);
            this.panelPlane.Controls.Add(this.labelMainColor);
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(203, 22);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(395, 407);
            this.panelPlane.TabIndex = 14;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(189, 319);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 43);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(83, 318);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 44);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Осн цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.lableMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(23, 20);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(348, 295);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(630, 34);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(48, 51);
            this.panelRed.TabIndex = 15;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(724, 33);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(51, 52);
            this.panelBlue.TabIndex = 16;
            // 
            // panelVinous
            // 
            this.panelVinous.BackColor = System.Drawing.Color.Maroon;
            this.panelVinous.Location = new System.Drawing.Point(630, 123);
            this.panelVinous.Name = "panelVinous";
            this.panelVinous.Size = new System.Drawing.Size(47, 48);
            this.panelVinous.TabIndex = 17;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(724, 123);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(51, 48);
            this.panelGreen.TabIndex = 18;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(631, 209);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(47, 50);
            this.panelYellow.TabIndex = 19;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(728, 209);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(47, 53);
            this.panelBlack.TabIndex = 20;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(631, 304);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(48, 46);
            this.panelAqua.TabIndex = 21;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelPink.Location = new System.Drawing.Point(728, 304);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(51, 46);
            this.panelPink.TabIndex = 22;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPink);
            this.Controls.Add(this.panelAqua);
            this.Controls.Add(this.panelBlack);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelVinous);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxPlane);
            this.Name = "FormPlaneConfig";
            this.Text = "FormCarConfig";
            this.groupBoxPlane.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlane;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.Label labelPlaneWithRadar;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelVinous;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelPink;
    }
}