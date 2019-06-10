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

namespace androidCopy
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
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

        private void WaitForUsb()
        {
            var watcher = new ManagementEventWatcher();
            var query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            //watcher.EventArrived += new EventArrivedEventHandler(blah);
            watcher.EventArrived += WatcherOnEventArrived;
            watcher.Query = query;
            watcher.Start();
        }

        private void WatcherOnEventArrived(object sender, EventArrivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
