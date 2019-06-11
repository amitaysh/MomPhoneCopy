namespace androidCopy
{
    partial class BackupForm
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
            this.PhoneConnectText = new System.Windows.Forms.Label();
            this.dateBackupText = new System.Windows.Forms.Label();
            this.lastDateBackupText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RunBackupBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // PhoneConnectText
            // 
            this.PhoneConnectText.AutoSize = true;
            this.PhoneConnectText.Location = new System.Drawing.Point(42, 9);
            this.PhoneConnectText.Name = "PhoneConnectText";
            this.PhoneConnectText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PhoneConnectText.Size = new System.Drawing.Size(447, 39);
            this.PhoneConnectText.TabIndex = 0;
            this.PhoneConnectText.Text = "אחלה בסדר אז קודם כל תחברי את הטלפון למחשב.\r\nאם במקרה כבר חיברת - אין ברירה, תנתק" +
    "י את הטלפון, תחכי כמה שניות ואז תחברי שוב.\r\nאני ממתין...";
            this.PhoneConnectText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBackupText
            // 
            this.dateBackupText.AutoSize = true;
            this.dateBackupText.Location = new System.Drawing.Point(87, 48);
            this.dateBackupText.Name = "dateBackupText";
            this.dateBackupText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateBackupText.Size = new System.Drawing.Size(402, 39);
            this.dateBackupText.TabIndex = 1;
            this.dateBackupText.Text = "יופי תודה!\r\nמאיזה תאריך תרצי לגבות? זאת אומרת מתי פעם אחרונה שגיבית את התמונות?\r\n" +
    "אני חושב שפעם אחרונה הייתה ב:";
            this.dateBackupText.Visible = false;
            // 
            // lastDateBackupText
            // 
            this.lastDateBackupText.AutoSize = true;
            this.lastDateBackupText.Location = new System.Drawing.Point(431, 87);
            this.lastDateBackupText.Name = "lastDateBackupText";
            this.lastDateBackupText.Size = new System.Drawing.Size(55, 13);
            this.lastDateBackupText.TabIndex = 2;
            this.lastDateBackupText.Text = "20.8.2019";
            this.lastDateBackupText.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // RunBackupBtn
            // 
            this.RunBackupBtn.Location = new System.Drawing.Point(370, 129);
            this.RunBackupBtn.Name = "RunBackupBtn";
            this.RunBackupBtn.Size = new System.Drawing.Size(116, 23);
            this.RunBackupBtn.TabIndex = 4;
            this.RunBackupBtn.Text = "יאללה תעשה גיבוי";
            this.RunBackupBtn.UseVisualStyleBackColor = true;
            this.RunBackupBtn.Click += new System.EventHandler(this.RunBackupBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(474, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 197);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RunBackupBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lastDateBackupText);
            this.Controls.Add(this.dateBackupText);
            this.Controls.Add(this.PhoneConnectText);
            this.Name = "BackupForm";
            this.Text = "BackupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhoneConnectText;
        private System.Windows.Forms.Label dateBackupText;
        private System.Windows.Forms.Label lastDateBackupText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button RunBackupBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}