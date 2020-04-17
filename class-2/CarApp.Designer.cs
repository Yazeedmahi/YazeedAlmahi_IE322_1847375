namespace class_2
{
    partial class CarApp
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
            this.BtnAccelrate = new System.Windows.Forms.Button();
            this.BtnStopCar = new System.Windows.Forms.Button();
            this.BtnStartCar = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnAccelrateCar2 = new System.Windows.Forms.Button();
            this.StopCar2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAccelrate
            // 
            this.BtnAccelrate.Location = new System.Drawing.Point(573, 88);
            this.BtnAccelrate.Name = "BtnAccelrate";
            this.BtnAccelrate.Size = new System.Drawing.Size(109, 23);
            this.BtnAccelrate.TabIndex = 5;
            this.BtnAccelrate.Text = "AccelrateCar";
            this.BtnAccelrate.UseVisualStyleBackColor = true;
            this.BtnAccelrate.Click += new System.EventHandler(this.BtnAccelrate_Click);
            // 
            // BtnStopCar
            // 
            this.BtnStopCar.Location = new System.Drawing.Point(363, 88);
            this.BtnStopCar.Name = "BtnStopCar";
            this.BtnStopCar.Size = new System.Drawing.Size(75, 23);
            this.BtnStopCar.TabIndex = 4;
            this.BtnStopCar.Text = "StopCar";
            this.BtnStopCar.UseVisualStyleBackColor = true;
            this.BtnStopCar.Click += new System.EventHandler(this.BtnStopCar_Click);
            // 
            // BtnStartCar
            // 
            this.BtnStartCar.Location = new System.Drawing.Point(149, 88);
            this.BtnStartCar.Name = "BtnStartCar";
            this.BtnStartCar.Size = new System.Drawing.Size(75, 23);
            this.BtnStartCar.TabIndex = 3;
            this.BtnStartCar.Text = "StartCar";
            this.BtnStartCar.UseVisualStyleBackColor = true;
            this.BtnStartCar.Click += new System.EventHandler(this.BtnStartCar_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(363, 214);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAccelrateCar2
            // 
            this.BtnAccelrateCar2.Location = new System.Drawing.Point(583, 143);
            this.BtnAccelrateCar2.Name = "BtnAccelrateCar2";
            this.BtnAccelrateCar2.Size = new System.Drawing.Size(109, 23);
            this.BtnAccelrateCar2.TabIndex = 9;
            this.BtnAccelrateCar2.Text = "AccelrateCar2";
            this.BtnAccelrateCar2.UseVisualStyleBackColor = true;
            this.BtnAccelrateCar2.Click += new System.EventHandler(this.BtnAccelrateCar2_Click);
            // 
            // StopCar2
            // 
            this.StopCar2.Location = new System.Drawing.Point(373, 143);
            this.StopCar2.Name = "StopCar2";
            this.StopCar2.Size = new System.Drawing.Size(75, 23);
            this.StopCar2.TabIndex = 8;
            this.StopCar2.Text = "StopCar2";
            this.StopCar2.UseVisualStyleBackColor = true;
            this.StopCar2.Click += new System.EventHandler(this.StopCar2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "StartCar2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CarApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAccelrateCar2);
            this.Controls.Add(this.StopCar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAccelrate);
            this.Controls.Add(this.BtnStopCar);
            this.Controls.Add(this.BtnStartCar);
            this.Name = "CarApp";
            this.Text = "CarApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAccelrate;
        private System.Windows.Forms.Button BtnStopCar;
        private System.Windows.Forms.Button BtnStartCar;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnAccelrateCar2;
        private System.Windows.Forms.Button StopCar2;
        private System.Windows.Forms.Button button3;
    }
}