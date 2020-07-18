using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code;

namespace DevTool.ImageTools
{
    public partial class ImageToolForm : Form
    {
        public ImageToolForm()
        {
            InitializeComponent();
        }

        private void ImageToolForm_Load(object sender, EventArgs e)
        {

        }

        private void pngToJpgBtn_Click(object sender, EventArgs e)
        {

            Convert(ImageFormat.Jpeg);
        }

        private void jpgTopng_Click(object sender, EventArgs e)
        {
            Convert(ImageFormat.Png);
        }

        private void Convert(ImageFormat format)
        {
            List<string> paths = new List<string>();
            FileSelectTool.SelectFiles(out paths);
            if (paths.Count == 0) return;
            for (int i = 0; i < paths.Count; i++)
            {
                string _path = Path.GetDirectoryName(paths[i]);
                string _name = Path.GetFileNameWithoutExtension(paths[i]);
                Shell.WriteLine(string.Format("图片名：{0}", _name));
                Image img = Image.FromFile(paths[i]);
                if (format == ImageFormat.Jpeg)
                {
                    img.Save(_path + @"/" + _name + ".jpg", format);
                }
                else
                {
                    img.Save(_path + @"/" + _name + ".png", format);
                }
                img.Dispose();
            }
            Shell.WriteLine(string.Format("完成"));
        }

        private List<string> compressImgPaths = new List<string>();
        private void selectImgBtn_Click(object sender, EventArgs e)
        {
            FileSelectTool.SelectFiles(out compressImgPaths);

        }


        private void compressImageBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < compressImgPaths.Count; i++)
            {
                string _path = Path.GetDirectoryName(compressImgPaths[i]);
                string _name = Path.GetFileNameWithoutExtension(compressImgPaths[i]);
                Shell.WriteLine(string.Format("path:{0},name:{1}", _path, _name));
                if (!Directory.Exists(_path + "\\compressImgs")) Directory.CreateDirectory(_path + "\\compressImgs");
                string newPath = _path + "\\compressImgs\\" + _name + "." + Path.GetExtension(compressImgPaths[i]);
                ImageHelper.CompressImage(compressImgPaths[i],newPath, int.Parse(InputFlag.Text), int.Parse(inputImgSize.Text));
            }
        }

        private List<string> SelectChangImgPaths = new List<string>();
        private void selectChangeWHbtn_Click(object sender, EventArgs e)
        {
            SelectChangImgPaths.Clear();
            FileSelectTool.SelectFiles(out SelectChangImgPaths);
        }


        private void changeWHBtn_Click(object sender, EventArgs e)
        {
            string newpath = Path.GetDirectoryName(SelectChangImgPaths[0]) + "\\changeImgs";
            if (!Directory.Exists(newpath)) Directory.CreateDirectory(newpath);
            for (int i = 0; i < SelectChangImgPaths.Count; i++)
            {
                Shell.WriteLine(string.Format("改变的图片：{0}",SelectChangImgPaths[i]));
                ImageHelper.Image_Resize(SelectChangImgPaths[i], newpath, int.Parse(inputChangeWidth.Text));
            }
            Shell.WriteLine(string.Format("完成"));
        }


    }
}
