﻿using System;
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
                ImageHelper.CompressImage(compressImgPaths[i], _path + "\\compressImgs\\" + _name + "." + Path.GetExtension(compressImgPaths[i]), 90, 2000);
            }
        }

        private List<string> SelectChangImgPaths = new List<string>();
        private void selectChangeWHbtn_Click(object sender, EventArgs e)
        {
            FileSelectTool.SelectFiles(out SelectChangImgPaths);
        }


        private void changeWHBtn_Click(object sender, EventArgs e)
        {
            string newpath = Path.GetDirectoryName(SelectChangImgPaths[0]) + "\\changeImgs";
            if (!Directory.Exists(newpath)) Directory.CreateDirectory(newpath);
            for (int i = 0; i < SelectChangImgPaths.Count; i++)
            {
                ImageHelper.Image_Resize(SelectChangImgPaths[i], newpath, int.Parse(inputChangeWidth.Text));
            }
        }


    }
}
