namespace androidCopy
{
    partial class Form1
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(12, 92);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(180, 23);
            this.backupBtn.TabIndex = 0;
            this.backupBtn.Text = "לגבות תמונות מהטלפון למחשב";
            this.backupBtn.UseVisualStyleBackColor = true;
            // 
            // developBtn
            // 
            this.developBtn.Location = new System.Drawing.Point(12, 126);
            this.developBtn.Name = "developBtn";
            this.developBtn.Size = new System.Drawing.Size(180, 23);
            this.developBtn.TabIndex = 1;
            this.developBtn.Text = "להעביר תמונות לפיתוח";
            this.developBtn.UseVisualStyleBackColor = true;
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(117, 25);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(57, 13);
            this.welcomeText.TabIndex = 2;
            this.welcomeText.Text = "בוקר טוב!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.developBtn);
            this.Controls.Add(this.backupBtn);
            this.Name = "Form1";
            this.Text = "תמונות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button developBtn;
        private System.Windows.Forms.Label welcomeText;
    }
}

