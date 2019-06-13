namespace androidCopy
{
    partial class DiskOnKeyForm
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
            this.usbConnectText = new System.Windows.Forms.Label();
            this.copyText = new System.Windows.Forms.Label();
            this.copyFilesProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // usbConnectText
            // 
            this.usbConnectText.AutoSize = true;
            this.usbConnectText.Location = new System.Drawing.Point(55, 9);
            this.usbConnectText.Name = "usbConnectText";
            this.usbConnectText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usbConnectText.Size = new System.Drawing.Size(416, 39);
            this.usbConnectText.TabIndex = 1;
            this.usbConnectText.Text = "אחלה בסדר אז קודם כל תחברי את הדיסק-און-קי למחשב.\r\nאם במקרה כבר חיברת - אין ברירה" +
    ", תנתקי אותו, תחכי כמה שניות ואז תחברי שוב.\r\nאני ממתין...";
            this.usbConnectText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyText
            // 
            this.copyText.AutoSize = true;
            this.copyText.Location = new System.Drawing.Point(94, 48);
            this.copyText.Name = "copyText";
            this.copyText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.copyText.Size = new System.Drawing.Size(377, 52);
            this.copyText.TabIndex = 2;
            this.copyText.Text = "יופי תודה!\r\nאני אצור תיקייה בפנים עם התאריך של היום כדי שיהיה קל.\r\nאחר כך בחנות צ" +
    "ילום פשוט תבחרי את התיקייה עם התאריך של היום וזהו!\r\nאז רגע, מעתיקים... נא להמתין" +
    "!";
            this.copyText.Visible = false;
            // 
            // copyFilesProgressBar
            // 
            this.copyFilesProgressBar.Location = new System.Drawing.Point(12, 103);
            this.copyFilesProgressBar.Name = "copyFilesProgressBar";
            this.copyFilesProgressBar.Size = new System.Drawing.Size(459, 23);
            this.copyFilesProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.copyFilesProgressBar.TabIndex = 3;
            this.copyFilesProgressBar.Visible = false;
            // 
            // DiskOnKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 143);
            this.Controls.Add(this.copyFilesProgressBar);
            this.Controls.Add(this.copyText);
            this.Controls.Add(this.usbConnectText);
            this.Name = "DiskOnKeyForm";
            this.Text = "העתקת קבצים לדיסק-און-קי";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usbConnectText;
        private System.Windows.Forms.Label copyText;
        private System.Windows.Forms.ProgressBar copyFilesProgressBar;
    }
}