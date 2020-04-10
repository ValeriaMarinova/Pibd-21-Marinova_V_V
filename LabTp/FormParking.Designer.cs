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
            this.SetPlane = new System.Windows.Forms.Button();
            this.buttonSetPlaneWithRadar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-2, -1);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(832, 612);
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
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click_1);
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
            // SetPlane
            // 
            this.SetPlane.Location = new System.Drawing.Point(836, -1);
            this.SetPlane.Name = "SetPlane";
            this.SetPlane.Size = new System.Drawing.Size(137, 80);
            this.SetPlane.TabIndex = 5;
            this.SetPlane.Text = "Припарковать самолет";
            this.SetPlane.UseVisualStyleBackColor = true;
            this.SetPlane.Click += new System.EventHandler(this.SetPlane_Click_1);
            // 
            // buttonSetPlaneWithRadar
            // 
            this.buttonSetPlaneWithRadar.Location = new System.Drawing.Point(842, 87);
            this.buttonSetPlaneWithRadar.Name = "buttonSetPlaneWithRadar";
            this.buttonSetPlaneWithRadar.Size = new System.Drawing.Size(131, 84);
            this.buttonSetPlaneWithRadar.TabIndex = 6;
            this.buttonSetPlaneWithRadar.Text = "Припарковать сам с рад";
            this.buttonSetPlaneWithRadar.UseVisualStyleBackColor = true;
            this.buttonSetPlaneWithRadar.Click += new System.EventHandler(this.buttonSetPlaneWithRadar_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 623);
            this.Controls.Add(this.buttonSetPlaneWithRadar);
            this.Controls.Add(this.SetPlane);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxTakePlanes;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomber;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.Button SetPlane;
        private System.Windows.Forms.Button buttonSetPlaneWithRadar;
    }
}