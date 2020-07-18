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

namespace DevTool.TableTools
{
    public partial class TableToolForm : Form
    {
        public TableToolForm()
        {
            InitializeComponent();
        }

        private void TableToolForm_Load(object sender, EventArgs e)
        {

        }

        private void jsonFormatBtn_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            FileSelectTool.SelectFiles(out paths);
            Shell.WriteLine("格式化开始");
            foreach (string file in paths)
            {
                Shell.WriteLine(file);
                string str = File.ReadAllText(file);
                str = FileTool.ConvertJsonString(str);
                FileTool.WriteToTxt(str, file, true);

            }
            Shell.WriteLine("完成");
        }

        List<string> excelPathsList = new List<string>();
        private void importExcelBtn_Click(object sender, EventArgs e)
        {
            excelPathsList.Clear();
            FileSelectTool.SelectFiles(out excelPathsList);
            Shell.WriteLine("导入的表");
            foreach (string file in excelPathsList)
            {
                Shell.WriteLine(Path.GetFileName(file));
            }

        }

        private void outputJsonBtn_Click(object sender, EventArgs e)
        {
            Shell.WriteLine("开始");
            foreach (string file in excelPathsList)
            {
                FileInfo info = new FileInfo(file);
                Shell.WriteLine(string.Format("file:{0},name:{1}",file,info.Name));
                TableHelper.ImportExcel(file, info.Name.Split('.')[0],int.Parse(InputRowIndex.Text),int.Parse(InputTableNum.Text));
            }
            Shell.WriteLine("完成");
        }
    }
}
