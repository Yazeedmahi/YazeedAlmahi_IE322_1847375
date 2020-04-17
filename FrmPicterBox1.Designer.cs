namespace class_2
{
    partial class FrmPicterBox
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
            this.Pictry = new System.Windows.Forms.PictureBox();
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.BtnLoadImage2 = new System.Windows.Forms.Button();
            this.Pictry2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pictry
            // 
            this.Pictry.Location = new System.Drawing.Point(87, 194);
            this.Pictry.Name = "Pictry";
            this.Pictry.Size = new System.Drawing.Size(147, 143);
            this.Pictry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictry.TabIndex = 0;
            this.Pictry.TabStop = false;
            this.Pictry.Click += new System.EventHandler(this.Pictry_Click);
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Location = new System.Drawing.Point(87, 117);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(147, 23);
            this.BtnLoadImage.TabIndex = 1;
            this.BtnLoadImage.Text = "load Image from file";
            this.BtnLoadImage.UseVisualStyleBackColor = true;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // BtnLoadImage2
            // 
            this.BtnLoadImage2.Location = new System.Drawing.Point(253, 109);
            this.BtnLoadImage2.Name = "BtnLoadImage2";
            this.BtnLoadImage2.Size = new System.Drawing.Size(249, 38);
            this.BtnLoadImage2.TabIndex = 2;
            this.BtnLoadImage2.Text = "Load image from Resources";
            this.BtnLoadImage2.UseVisualStyleBackColor = true;
            this.BtnLoadImage2.Click += new System.EventHandler(this.BtnLoadImage2_Click);
            // 
            // Pictry2
            // 
            this.Pictry2.Location = new System.Drawing.Point(286, 194);
            this.Pictry2.Name = "Pictry2";
            this.Pictry2.Size = new System.Drawing.Size(140, 143);
            this.Pictry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictry2.TabIndex = 3;
            this.Pictry2.TabStop = false;
            this.Pictry2.Click += new System.EventHandler(this.Pictry2_Click);
            // 
            // FrmPicterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pictry2);
            this.Controls.Add(this.BtnLoadImage2);
            this.Controls.Add(this.BtnLoadImage);
            this.Controls.Add(this.Pictry);
            this.Name = "FrmPicterBox";
            this.Text = "FrmPicterBox1";
            this.Load += new System.EventHandler(this.FrmPicterBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictry;
        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.Button BtnLoadImage2;
        private System.Windows.Forms.PictureBox Pictry2;
    }
}