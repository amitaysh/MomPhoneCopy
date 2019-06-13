namespace androidCopy
{
    partial class CopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.datesDropDown = new System.Windows.Forms.ComboBox();
            this.getPhotosFromPcBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doneBtn = new System.Windows.Forms.Button();
            this.waitText = new System.Windows.Forms.Label();
            this.collectPhotosProgressBar = new System.Windows.Forms.ProgressBar();
            this.numberOfPhotosText = new System.Windows.Forms.Label();
            this.numberOfSelectedPhotosText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(547, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // datesDropDown
            // 
            this.datesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datesDropDown.FormattingEnabled = true;
            this.datesDropDown.Location = new System.Drawing.Point(578, 78);
            this.datesDropDown.Name = "datesDropDown";
            this.datesDropDown.Size = new System.Drawing.Size(207, 21);
            this.datesDropDown.TabIndex = 1;
            // 
            // getPhotosFromPcBtn
            // 
            this.getPhotosFromPcBtn.Enabled = false;
            this.getPhotosFromPcBtn.Location = new System.Drawing.Point(454, 77);
            this.getPhotosFromPcBtn.Name = "getPhotosFromPcBtn";
            this.getPhotosFromPcBtn.Size = new System.Drawing.Size(118, 23);
            this.getPhotosFromPcBtn.TabIndex = 2;
            this.getPhotosFromPcBtn.Text = "יאללה בוא נבחר";
            this.getPhotosFromPcBtn.UseVisualStyleBackColor = true;
            this.getPhotosFromPcBtn.Click += new System.EventHandler(this.getPhotosFromPcBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 333);
            this.panel1.TabIndex = 3;
            // 
            // doneBtn
            // 
            this.doneBtn.Enabled = false;
            this.doneBtn.Location = new System.Drawing.Point(336, 77);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(112, 23);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "סיימתי לבחור";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // waitText
            // 
            this.waitText.AutoSize = true;
            this.waitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.waitText.ForeColor = System.Drawing.Color.Red;
            this.waitText.Location = new System.Drawing.Point(32, 43);
            this.waitText.Name = "waitText";
            this.waitText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.waitText.Size = new System.Drawing.Size(295, 31);
            this.waitText.TabIndex = 5;
            this.waitText.Text = "רגע עדיין אוסף תמונות!";
            this.waitText.Visible = false;
            // 
            // collectPhotosProgressBar
            // 
            this.collectPhotosProgressBar.Location = new System.Drawing.Point(32, 77);
            this.collectPhotosProgressBar.Name = "collectPhotosProgressBar";
            this.collectPhotosProgressBar.Size = new System.Drawing.Size(289, 23);
            this.collectPhotosProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.collectPhotosProgressBar.TabIndex = 6;
            this.collectPhotosProgressBar.Visible = false;
            // 
            // numberOfPhotosText
            // 
            this.numberOfPhotosText.AutoSize = true;
            this.numberOfPhotosText.Location = new System.Drawing.Point(560, 443);
            this.numberOfPhotosText.Name = "numberOfPhotosText";
            this.numberOfPhotosText.Size = new System.Drawing.Size(87, 13);
            this.numberOfPhotosText.TabIndex = 7;
            this.numberOfPhotosText.Text = "נמצאו 0 תמונות";
            // 
            // numberOfSelectedPhotosText
            // 
            this.numberOfSelectedPhotosText.AutoSize = true;
            this.numberOfSelectedPhotosText.Location = new System.Drawing.Point(407, 443);
            this.numberOfSelectedPhotosText.Name = "numberOfSelectedPhotosText";
            this.numberOfSelectedPhotosText.Size = new System.Drawing.Size(85, 13);
            this.numberOfSelectedPhotosText.TabIndex = 8;
            this.numberOfSelectedPhotosText.Text = "נבחרו 0 תמונות";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.numberOfSelectedPhotosText);
            this.Controls.Add(this.numberOfPhotosText);
            this.Controls.Add(this.collectPhotosProgressBar);
            this.Controls.Add(this.waitText);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.getPhotosFromPcBtn);
            this.Controls.Add(this.datesDropDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyForm";
            this.Text = "בחירת תמונות לפיתוח";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox datesDropDown;
        private System.Windows.Forms.Button getPhotosFromPcBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label waitText;
        private System.Windows.Forms.ProgressBar collectPhotosProgressBar;
        private System.Windows.Forms.Label numberOfPhotosText;
        private System.Windows.Forms.Label numberOfSelectedPhotosText;
    }
}