namespace LabTp
{
    partial class FormPlane
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlane));
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCreatePlaneWithRadar = new System.Windows.Forms.Button();
            this.buttonCreatePlane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPlane.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(1174, 577);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(1050, 435);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(45, 46);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1050, 517);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(45, 46);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(1116, 476);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(45, 46);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(980, 476);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(45, 46);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreatePlaneWithRadar
            // 
            this.buttonCreatePlaneWithRadar.Location = new System.Drawing.Point(309, 23);
            this.buttonCreatePlaneWithRadar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreatePlaneWithRadar.Name = "buttonCreatePlaneWithRadar";
            this.buttonCreatePlaneWithRadar.Size = new System.Drawing.Size(284, 35);
            this.buttonCreatePlaneWithRadar.TabIndex = 8;
            this.buttonCreatePlaneWithRadar.Text = "Создать самолет с радаром";
            this.buttonCreatePlaneWithRadar.UseVisualStyleBackColor = true;
            this.buttonCreatePlaneWithRadar.Click += new System.EventHandler(this.buttonCreatePlaneWithRadar_Click_1);
            // 
            // buttonCreatePlane
            // 
            this.buttonCreatePlane.Location = new System.Drawing.Point(43, 23);
            this.buttonCreatePlane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreatePlane.Name = "buttonCreatePlane";
            this.buttonCreatePlane.Size = new System.Drawing.Size(202, 35);
            this.buttonCreatePlane.TabIndex = 9;
            this.buttonCreatePlane.Text = "Создать самолет";
            this.buttonCreatePlane.UseVisualStyleBackColor = true;
            this.buttonCreatePlane.Click += new System.EventHandler(this.buttonCreatePlane_Click_1);
            // 
            // FormPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 577);
            this.Controls.Add(this.buttonCreatePlane);
            this.Controls.Add(this.buttonCreatePlaneWithRadar);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxPlane);
            this.Name = "FormPlane";
            this.Text = "Plane";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCreatePlaneWithRadar;
        private System.Windows.Forms.Button buttonCreatePlane;
    }
}

