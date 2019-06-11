using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace androidCopy
{
    public partial class BackupForm : Form
    {
        public static string DriveLetter;
        string _toPath = System.Configuration.ConfigurationSettings.AppSettings["BackupToFolder"];
        string _fromPaths = System.Configuration.ConfigurationSettings.AppSettings["BackupFromFolders"];
        string _fileType = System.Configuration.ConfigurationSettings.AppSettings["PhotosFileType"];

        public BackupForm()
        {
            InitializeComponent();
            lastDateBackupText.Text = FindLatestBackup();
            PhoneConnectText.Visible = true;
            dateBackupText.Visible = false;
            lastDateBackupText.Visible = false;
            dateTimePicker1.Visible = false;
            RunBackupBtn.Visible = false;
            WaitForUsb();
        }

        private string FindLatestBackup()
        {
            var latest = new DirectoryInfo(_toPath).GetDirectories()
                .OrderByDescending(d => d.LastWriteTimeUtc).First();
            return latest.ToString();
        }

        private void RunBackupBtn_Click(object sender, EventArgs e)
        {
            RunBackupBtn.Enabled = false;
            var paths = _fromPaths.Split(';');
            var todayPath = Directory.CreateDirectory(_toPath + "\\" + DateTime.Now.ToString("dd.MM.yy"));
            var counter = 0;
            foreach (var path in paths)
            {
                if (string.IsNullOrEmpty(path))
                    continue;
                progressBar1.Value = 0;
                var dir = new DirectoryInfo(path);
                var files = dir.GetFiles(_fileType, SearchOption.AllDirectories);
                var p = 100.0 / Convert.ToDouble(files.Length);
                var progressBarValue = Math.Ceiling(p);
                foreach (var file in files)
                {
                    var duplicate = 1;
                    if (file.LastWriteTime.Date >= dateTimePicker1.Value)
                    {
                        var newFullPath = todayPath.FullName + "\\" + file.Name;
                        while (File.Exists(newFullPath))
                        {
                            var tempFileName = $"{Path.GetFileNameWithoutExtension(file.Name)}({duplicate++})";
                            newFullPath = Path.Combine(todayPath.FullName, tempFileName + file.Extension);
                        }

                        File.Copy(file.FullName, newFullPath);
                        if (progressBar1.Value + progressBarValue < 100)
                            progressBar1.Value += Convert.ToInt32(progressBarValue);
                        counter++;
                    }
                }
            }

            var mes = "?אחלה, סיימנו! תכלס אפשר לסגור אם תרצי. לסגור" + Environment.NewLine + $@"גיבינו {counter} תמונות";
            var res = MessageBox.Show(mes, @"סיימנו!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (res == DialogResult.Yes)
                Environment.Exit(1);
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
            DriveLetter = e.NewEvent.Properties["DriveName"].Value.ToString();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            if (PhoneConnectText.InvokeRequired)
            {
                PhoneConnectText.Invoke(new MethodInvoker(delegate { PhoneConnectText.Visible = false; }));
                dateBackupText.Invoke(new MethodInvoker(delegate { dateBackupText.Visible = true; }));
                lastDateBackupText.Invoke(new MethodInvoker(delegate { lastDateBackupText.Visible = true; }));
                dateTimePicker1.Invoke(new MethodInvoker(delegate { dateTimePicker1.Visible = true; }));
                RunBackupBtn.Invoke(new MethodInvoker(delegate { RunBackupBtn.Visible = true; }));
            }
            else
            {
                PhoneConnectText.Visible = false;
                dateBackupText.Visible = true;
                lastDateBackupText.Visible = true;
                dateTimePicker1.Visible = true;
                RunBackupBtn.Visible = true;
            }

            
        }
    }
}
