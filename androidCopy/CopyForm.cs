using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace androidCopy
{
    public partial class CopyForm : Form
    {
        readonly string _toPath = System.Configuration.ConfigurationSettings.AppSettings["BackupToFolder"];
        readonly string _fileType = System.Configuration.ConfigurationSettings.AppSettings["PhotosFileType"];
        private readonly Dictionary<PictureBox, PictureBox> _dict = new Dictionary<PictureBox, PictureBox>();
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
            panel1.Controls.Clear();
            var photos = new DirectoryInfo(_toPath + "\\" + datesDropDown.Text).GetFiles(_fileType, SearchOption.AllDirectories)
                .OrderByDescending(d => d.LastWriteTimeUtc);
            var nextPhotoLocation = new Point(3, 3);
            foreach (var photo in photos)
            {
                var img = Image.FromFile(photo.FullName);
                var size = SetPhotoOrientation(img);
                var pic = new PictureBox
                {
                    Image = img,
                    BackColor = Color.Black,
                    Size = size,
                    Location = SetPhotoToMiddle(nextPhotoLocation, size),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = photo.FullName
                };
                pic.MouseClick += PicOnMouseClick;
                pic.MouseDoubleClick += PicOnMouseClick;
                panel1.Controls.Add(pic);
                nextPhotoLocation = CalcNextPhotoLocation(nextPhotoLocation);
            }
        }

        private Size SetPhotoOrientation(Image img)
        {
            if (img.Height > img.Width)
                return new Size(60, 100);
            if (img.Width > img.Height)
                return new Size(100, 60);
            return new Size(100, 100);
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
            return location;
        }

        private Point SetRectangleToMiddle(Point location, Size size)
        {
            if (size.Height > size.Width)
                return new Point(location.X - 20, location.Y);
            if (size.Height < size.Width)
                return new Point(location.X, location.Y - 20);
            return location;
        }

        private void PicOnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                using (Form form = new Form())
                {
                    var control = (Control) sender;
                    var pb = (PictureBox) control;
                    var img = pb.Image;
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Size = img.Size;

                    pb = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = img
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
                //var rect = new Rectangle(SetRectangleToMiddle(control.Location, pb.Size), new Size(100, 100));
                if (_dict.ContainsKey(pb))
                {
                    panel1.Controls.Remove(_dict[pb]);
                    _dict.Remove(pb);
                }
                else
                {
                    _dict.Add(pb, v);
                    panel1.Controls.Add(v);
                }
            }

            doneBtn.Enabled = true;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
