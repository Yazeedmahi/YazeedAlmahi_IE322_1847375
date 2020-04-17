namespace class_2
{
    partial class FrmRandomCombo
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
            this.CmbRandom = new System.Windows.Forms.ComboBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenrate
            // 
            this.BtnGenrate.Location = new System.Drawing.Point(252, 132);
            this.BtnGenrate.Name = "BtnGenrate";
            this.BtnGenrate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenrate.TabIndex = 0;
            this.BtnGenrate.Text = "Genrate";
            this.BtnGenrate.UseVisualStyleBackColor = true;
            this.BtnGenrate.Click += new System.EventHandler(this.BtnGenrate_Click);
            // 
            // CmbRandom
            // 
            this.CmbRandom.FormattingEnabled = true;
            this.CmbRandom.Location = new System.Drawing.Point(95, 131);
            this.CmbRandom.Name = "CmbRandom";
            this.CmbRandom.Size = new System.Drawing.Size(121, 24);
            this.CmbRandom.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(252, 185);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.CmbRandom);
            this.Controls.Add(this.BtnGenrate);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenrate;
        private System.Windows.Forms.ComboBox CmbRandom;
        private System.Windows.Forms.Button BtnReset;
    }
}