using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace androidCopy
{
    public partial class DiskOnKeyForm : Form
    {
        private string _driveLetter;
        public DiskOnKeyForm()
        {
            InitializeComponent();
            WaitForUsb();
        }

        private void WaitForUsb()
        {
            var watcher = new ManagementEventWatcher();
            var query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
            //watcher.EventArrived += new EventArrivedEventHandler(blah);
            watcher.EventArrived += WatcherOnEventArrived;
            watcher.Query = query;
            watcher.Start();
        }

        private void WatcherOnEventArrived(object sender, EventArrivedEventArgs e)
        {
            _driveLetter = e.NewEvent.Properties["DriveName"].Value.ToString();
            UpdateStatus();
            var copyToPath = Directory.CreateDirectory(_driveLetter + "\\" + DateTime.Now.ToString("dd.MM.yy"));
            var p = 100.0 / Convert.ToDouble(CopyForm.Dict.Count);
            var progressBarValue = Math.Ceiling(p);
            foreach (var file in CopyForm.Dict)
            {
                var duplicate = 1;
                var fileName = Path.GetFileName(file.Key.Tag.ToString());
                var newFullPath = copyToPath.FullName + "\\" + fileName;
                while (File.Exists(newFullPath))
                {
                    var tempFileName = $"{Path.GetFileNameWithoutExtension(fileName)}({duplicate++})";
                    newFullPath = Path.Combine(copyToPath.FullName, tempFileName + Path.GetExtension(fileName));
                }
                File.Copy(file.Key.Tag.ToString(), newFullPath);

                copyFilesProgressBar.Invoke(new MethodInvoker(delegate {
                    if (copyFilesProgressBar.Value + progressBarValue < 100)
                        copyFilesProgressBar.Value += Convert.ToInt32(progressBarValue);
                }));
            }

            copyFilesProgressBar.Invoke(new MethodInvoker(delegate { copyFilesProgressBar.Value = 100; }));
            MessageBox.Show(@"!סיימנו להעתיק! אפשר לקחת את הדיסק-און-קי לחנות! תהני", @"סיימנו!", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            Environment.Exit(0);
        }

        private void UpdateStatus()
        {
            if (usbConnectText.InvokeRequired)
            {
                usbConnectText.Invoke(new MethodInvoker(delegate { usbConnectText.Visible = false; }));
                copyText.Invoke(new MethodInvoker(delegate { copyText.Visible = true; }));
                copyFilesProgressBar.Invoke(new MethodInvoker(delegate { copyFilesProgressBar.Visible = true; }));
            }
            else
            {
                usbConnectText.Visible = false;
                copyText.Visible = true;
                copyFilesProgressBar.Visible = true;
            }


        }
    }
}
