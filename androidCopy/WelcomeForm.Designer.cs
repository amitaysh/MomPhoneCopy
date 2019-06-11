namespace androidCopy
{
    partial class WelcomeForm
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
            this.backupBtn = new System.Windows.Forms.Button();
            this.developBtn = new System.Windows.Forms.Button();
            this.MorningWelcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noonWelcomeText = new System.Windows.Forms.Label();
            this.EveWelcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(12, 66);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backupBtn.Size = new System.Drawing.Size(200, 23);
            this.backupBtn.TabIndex = 0;
            this.backupBtn.Text = "לגבות תמונות מהטלפון למחשב";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // developBtn
            // 
            this.developBtn.Location = new System.Drawing.Point(12, 98);
            this.developBtn.Name = "developBtn";
            this.developBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.developBtn.Size = new System.Drawing.Size(200, 23);
            this.developBtn.TabIndex = 1;
            this.developBtn.Text = "להעביר תמונות לפיתוח";
            this.developBtn.UseVisualStyleBackColor = true;
            this.developBtn.Click += new System.EventHandler(this.developBtn_Click);
            // 
            // MorningWelcomeText
            // 
            this.MorningWelcomeText.AutoSize = true;
            this.MorningWelcomeText.Location = new System.Drawing.Point(132, 9);
            this.MorningWelcomeText.Name = "MorningWelcomeText";
            this.MorningWelcomeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MorningWelcomeText.Size = new System.Drawing.Size(83, 13);
            this.MorningWelcomeText.TabIndex = 2;
            this.MorningWelcomeText.Text = "בוקר טוב אמא!";
            this.MorningWelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "מה תרצי לעשות היום?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noonWelcomeText
            // 
            this.noonWelcomeText.AutoSize = true;
            this.noonWelcomeText.Location = new System.Drawing.Point(113, 9);
            this.noonWelcomeText.Name = "noonWelcomeText";
            this.noonWelcomeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noonWelcomeText.Size = new System.Drawing.Size(102, 13);
            this.noonWelcomeText.TabIndex = 4;
            this.noonWelcomeText.Text = "צהרים טובים אמא!";
            // 
            // EveWelcomeText
            // 
            this.EveWelcomeText.AutoSize = true;
            this.EveWelcomeText.Location = new System.Drawing.Point(137, 9);
            this.EveWelcomeText.Name = "EveWelcomeText";
            this.EveWelcomeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EveWelcomeText.Size = new System.Drawing.Size(78, 13);
            this.EveWelcomeText.TabIndex = 5;
            this.EveWelcomeText.Text = "ערב טוב אמא!";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 133);
            this.Controls.Add(this.EveWelcomeText);
            this.Controls.Add(this.noonWelcomeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MorningWelcomeText);
            this.Controls.Add(this.developBtn);
            this.Controls.Add(this.backupBtn);
            this.Name = "WelcomeForm";
            this.Text = "תמונות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button developBtn;
        private System.Windows.Forms.Label MorningWelcomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noonWelcomeText;
        private System.Windows.Forms.Label EveWelcomeText;
    }
}

