using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace androidCopy
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            WelcomeMessage();
        }

        private void WelcomeMessage()
        {
            if (DateTime.Now.Hour < 12)
            {
                MorningWelcomeText.Visible = true;
                noonWelcomeText.Visible = false;
                EveWelcomeText.Visible = false;
            }
            else if (DateTime.Now.Hour < 18)
            {
                MorningWelcomeText.Visible = false;
                noonWelcomeText.Visible = true;
                EveWelcomeText.Visible = false;
            }
            else
            {
                MorningWelcomeText.Visible = false;
                noonWelcomeText.Visible = false;
                EveWelcomeText.Visible = true;
            }
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            var backForm = new BackupForm();
            backForm.ShowDialog();
        }

        private void developBtn_Click(object sender, EventArgs e)
        {
            var developForm = new CopyForm();
            developForm.ShowDialog();
        }

        private long GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.AvailableFreeSpace;
                }
            }
            return -1;
        }

    }
}
