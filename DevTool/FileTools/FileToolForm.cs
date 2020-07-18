using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code;

namespace DevTool.FileTools
{
    public partial class FileToolForm : Form
    {
        public FileToolForm()
        {
            InitializeComponent();
        }

        private void FileToolForm_Load(object sender, EventArgs e)
        {

        }

        List<string> fileNameLists = new List<string>();
        private void selectFilesBtn_Click(object sender, EventArgs e)
        {
            fileNameLists.Clear();
            FileSelectTool.SelectFiles(out fileNameLists);
            foreach (var _name in fileNameLists)
            {
                Shell.WriteLine(Path.GetFileName(_name));
            }
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            if (fileNameLists.Count == 0) return;
            int index = 1;
            string path = Path.GetDirectoryName(fileNameLists[0]);
            foreach (string fileName in fileNameLists)
            {
                string extendsionStr = Path.GetExtension(fileName);
                File.Move(fileName, path + "\\" + InputFileName.Text + index + extendsionStr);
                index++;
            }
            Shell.WriteLine("完成");
        }
    }
}
