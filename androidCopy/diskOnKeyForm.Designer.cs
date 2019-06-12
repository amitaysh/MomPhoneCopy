namespace androidCopy
{
    partial class diskOnKeyForm
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
            this.freeSpaceUsd = new System.Windows.Forms.ProgressBar();
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
    "ילום פשוט תבחרי את התיקייה עם התאריך של היום וזהו!\r\nדרך אגב זה המקום הפנוי שנשאר" +
    " בדיסק-און-קי, מדי פעם צריך למחוק.";
            this.copyText.Visible = false;
            // 
            // freeSpaceUsd
            // 
            this.freeSpaceUsd.Location = new System.Drawing.Point(12, 103);
            this.freeSpaceUsd.Name = "freeSpaceUsd";
            this.freeSpaceUsd.Size = new System.Drawing.Size(459, 23);
            this.freeSpaceUsd.TabIndex = 3;
            // 
            // diskOnKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 168);
            this.Controls.Add(this.freeSpaceUsd);
            this.Controls.Add(this.copyText);
            this.Controls.Add(this.usbConnectText);
            this.Name = "diskOnKeyForm";
            this.Text = "diskOnKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usbConnectText;
        private System.Windows.Forms.Label copyText;
        private System.Windows.Forms.ProgressBar freeSpaceUsd;
    }
}