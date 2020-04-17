namespace class_2
{
    partial class FrmCombo
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnM2 = new System.Windows.Forms.Button();
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnLastItem = new System.Windows.Forms.Button();
            this.Btn2ndLastItem = new System.Windows.Forms.Button();
            this.CmBDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show selected Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnM2
            // 
            this.BtnM2.Location = new System.Drawing.Point(199, 159);
            this.BtnM2.Name = "BtnM2";
            this.BtnM2.Size = new System.Drawing.Size(116, 49);
            this.BtnM2.TabIndex = 1;
            this.BtnM2.Text = "Show selected Method 2";
            this.BtnM2.UseVisualStyleBackColor = true;
            this.BtnM2.Click += new System.EventHandler(this.BtnM2_Click);
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(199, 349);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(116, 49);
            this.BtnName.TabIndex = 2;
            this.BtnName.Text = "Remove By Name";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(32, 349);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(116, 49);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove By Index";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnLastItem
            // 
            this.BtnLastItem.Location = new System.Drawing.Point(350, 207);
            this.BtnLastItem.Name = "BtnLastItem";
            this.BtnLastItem.Size = new System.Drawing.Size(116, 49);
            this.BtnLastItem.TabIndex = 4;
            this.BtnLastItem.Text = "Remove Last Item";
            this.BtnLastItem.UseVisualStyleBackColor = true;
            this.BtnLastItem.Click += new System.EventHandler(this.BtnLastItem_Click);
            // 
            // Btn2ndLastItem
            // 
            this.Btn2ndLastItem.Location = new System.Drawing.Point(350, 299);
            this.Btn2ndLastItem.Name = "Btn2ndLastItem";
            this.Btn2ndLastItem.Size = new System.Drawing.Size(116, 49);
            this.Btn2ndLastItem.TabIndex = 5;
            this.Btn2ndLastItem.Text = "Remove 2nd Last iem";
            this.Btn2ndLastItem.UseVisualStyleBackColor = true;
            this.Btn2ndLastItem.Click += new System.EventHandler(this.Btn2ndLastItem_Click);
            // 
            // CmBDays
            // 
            this.CmBDays.FormattingEnabled = true;
            this.CmBDays.Location = new System.Drawing.Point(53, 235);
            this.CmBDays.Name = "CmBDays";
            this.CmBDays.Size = new System.Drawing.Size(121, 24);
            this.CmBDays.TabIndex = 6;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmBDays);
            this.Controls.Add(this.Btn2ndLastItem);
            this.Controls.Add(this.BtnLastItem);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.BtnM2);
            this.Controls.Add(this.button1);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnM2;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnLastItem;
        private System.Windows.Forms.Button Btn2ndLastItem;
        private System.Windows.Forms.ComboBox CmBDays;
    }
}