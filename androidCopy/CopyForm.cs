using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace androidCopy
{
    public partial class CopyForm : Form
    {
        readonly string _toPath = System.Configuration.ConfigurationSettings.AppSettings["BackupToFolder"];
        readonly string _fileTypes = System.Configuration.ConfigurationSettings.AppSettings["PhotosFileType"];
        public static Dictionary<PictureBox, PictureBox> Dict = new Dictionary<PictureBox, PictureBox>();
        private string _date;
        public CopyForm()
        {
            InitializeComponent();
            ScanPcForPhotosDatesToDropDown();
            datesDropDown.SelectedIndexChanged += DatesDropDownOnSelectedIndexChanged;
        }


        private void DatesDropDownOnSelectedIndexChanged(object sender, EventArgs e)
        {
            getPhotosFromPcBtn.Enabled = true;
        }

        private void ScanPcForPhotosDatesToDropDown()
        {
            var folders = new DirectoryInfo(_toPath).GetDirectories()
                .OrderByDescending(d => d.LastWriteTimeUtc);
            datesDropDown.Items.Clear();
            foreach (var folder in folders)
            {
                datesDropDown.Items.Add(folder.Name);
            }
        }

        private void getPhotosFromPcBtn_Click(object sender, EventArgs e)
        {
            getPhotosFromPcBtn.Enabled = false;
            datesDropDown.Enabled = false;
            Application.EnableVisualStyles();
            collectPhotosProgressBar.Style = ProgressBarStyle.Marquee;
            collectPhotosProgressBar.Visible = true;
            waitText.Visible = true;
            panel1.Controls.Clear();
            Application.DoEvents();
            _date = datesDropDown.Text;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += BwOnDoWork;
            bw.RunWorkerCompleted += BwOnRunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void BwOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            collectPhotosProgressBar.Style = ProgressBarStyle.Blocks;
            collectPhotosProgressBar.Value = 100;
            waitText.Visible = false;
        }

        private void BwOnDoWork(object sender, DoWorkEventArgs e)
        {
            var counter = 0;
            var nextPhotoLocation = new Point(3, 3);
            foreach (var fileType in _fileTypes.Split('|'))
            {
                var photos = new DirectoryInfo(_toPath + "\\" + _date).GetFiles(fileType, SearchOption.AllDirectories)
                    .OrderByDescending(d => d.LastWriteTimeUtc);
                foreach (var photo in photos)
                {
                    counter++;
                    var img = Image.FromFile(photo.FullName);
                    var size = SetPhotoOrientation(img);
                    var smallImg = img.GetThumbnailImage(size.Width, size.Height, () => false, IntPtr.Zero);
                    var pic = new PictureBox
                    {
                        Image = smallImg,
                        BackColor = Color.Black,
                        Size = size,
                        Location = SetPhotoToMiddle(nextPhotoLocation, size),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = photo.FullName
                    };
                    pic.MouseClick += PicOnMouseClick;
                    pic.MouseDoubleClick += PicOnMouseClick;
                    panel1.Invoke(new MethodInvoker(delegate { panel1.Controls.Add(pic); }));

                    nextPhotoLocation = CalcNextPhotoLocation(nextPhotoLocation);
                }
            }
            numberOfPhotosText.Invoke(new MethodInvoker(delegate{numberOfPhotosText.Text = $@"נמצאו {counter} תמונות";}));
        }

        private Size SetPhotoOrientation(Image img)
        {
            if (img.Height > img.Width)
                return new Size(60, 100);
            if (img.Width > img.Height)
                return new Size(100, 60);
            return new Size(90, 90);
        }

        private Point CalcNextPhotoLocation(Point prevPhotoLocation)
        {
            if (prevPhotoLocation.X + 106 + 100 > panel1.Size.Width)
                return new Point(3, prevPhotoLocation.Y + 106);
            return new Point(prevPhotoLocation.X + 106, prevPhotoLocation.Y);
        }

        private Point SetPhotoToMiddle(Point location, Size size)
        {
            if (size.Height > size.Width)
                return new Point(location.X + 20, location.Y);
            if (size.Height < size.Width)
                return new Point(location.X, location.Y + 20);
            return new Point(location.X + 5, location.Y + 5);
        }

        private Point SetRectangleToMiddle(Point location, Size size)
        {
            if (size.Height > size.Width)
                return new Point(location.X - 20, location.Y);
            if (size.Height < size.Width)
                return new Point(location.X, location.Y - 20);
            return new Point(location.X - 5, location.Y - 5);
        }

        private void PicOnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                using (Form form = new Form())
                {
                    var control = (Control) sender;
                    var pb = (PictureBox) control;
                    var img = Image.FromFile(pb.Tag.ToString());
                    form.StartPosition = FormStartPosition.CenterScreen;
                    var screenSize = Screen.PrimaryScreen.WorkingArea.Size;
                    if (img.Size.Width >= screenSize.Width || img.Size.Height >= screenSize.Height)
                        form.Size = screenSize;
                    else
                        form.Size = img.Size;

                    pb = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = img,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    form.Controls.Add(pb);
                    form.ShowDialog();
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                var control = (Control)sender;
                var pb = (PictureBox)control;
                var v = new PictureBox
                {
                    Image = Properties.Resources.Image1,
                    BackColor = Color.Transparent,
                    Size = new Size(100, 100),
                    Location = SetRectangleToMiddle(pb.Location, pb.Size),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                if (Dict.ContainsKey(pb))
                {
                    panel1.Controls.Remove(Dict[pb]);
                    Dict.Remove(pb);
                    numberOfSelectedPhotosText.Invoke(new MethodInvoker(delegate { numberOfSelectedPhotosText.Text = $@"נבחרו {Dict.Count} תמונות"; }));
                }
                else
                {
                    Dict.Add(pb, v);
                    panel1.Controls.Add(v);
                    numberOfSelectedPhotosText.Invoke(new MethodInvoker(delegate { numberOfSelectedPhotosText.Text = $@"נבחרו {Dict.Count} תמונות"; }));
                }
            }

            doneBtn.Enabled = true;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            var done = new DiskOnKeyForm();
            done.ShowDialog();
        }
    }
}
