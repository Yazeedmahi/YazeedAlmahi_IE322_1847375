namespace class_2
{
    partial class FrmRandom
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
            this.BtnGenrate = new System.Windows.Forms.Button();
            this.BtnGrandom = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGenrate
            // 
            this.BtnGenrate.Location = new System.Drawing.Point(263, 64);
            this.BtnGenrate.Name = "BtnGenrate";
            this.BtnGenrate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenrate.TabIndex = 0;
            this.BtnGenrate.Text = "Genrate Random Number";
            this.BtnGenrate.UseVisualStyleBackColor = true;
            this.BtnGenrate.Click += new System.EventHandler(this.BtnGenrate_Click);
            // 
            // BtnGrandom
            // 
            this.BtnGrandom.Location = new System.Drawing.Point(182, 261);
            this.BtnGrandom.Name = "BtnGrandom";
            this.BtnGrandom.Size = new System.Drawing.Size(75, 23);
            this.BtnGrandom.TabIndex = 1;
            this.BtnGrandom.Text = "Show Random";
            this.BtnGrandom.UseVisualStyleBackColor = true;
            this.BtnGrandom.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(544, 290);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnTextBox
            // 
            this.BtnTextBox.Location = new System.Drawing.Point(170, 290);
            this.BtnTextBox.Name = "BtnTextBox";
            this.BtnTextBox.Size = new System.Drawing.Size(100, 22);
            this.BtnTextBox.TabIndex = 3;
            this.BtnTextBox.TextChanged += new System.EventHandler(this.BtnTextBox_TextChanged);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTextBox);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGrandom);
            this.Controls.Add(this.BtnGenrate);
            this.Name = "FrmRandom";
            this.Text = "FrmRandom";
            this.Load += new System.EventHandler(this.FrmRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenrate;
        private System.Windows.Forms.Button BtnGrandom;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox BtnTextBox;
    }
}