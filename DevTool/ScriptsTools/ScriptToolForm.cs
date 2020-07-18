using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Code;

namespace DevTool.ScriptsTools
{
    public partial class ScriptToolForm : Form
    {
        public ScriptToolForm()
        {
            InitializeComponent();
            Shell.WriteLine(Directory.GetCurrentDirectory());
            List<string> paths = Directory.GetFiles("TemplateClass").ToList();
            for (int i = 0; i < paths.Count; i++)
            {
                ClassCombo.Items.Add(Path.GetFileName(paths[i]).Split('.')[0]);
                Shell.WriteLine(Path.GetFileName(paths[i]));
            }
            ClassCombo.SelectedItem = ClassCombo.Items[0];
        }

        private void ScriptToolForm_Load(object sender, EventArgs e)
        {

        }

        private void generatorBtn_Click(object sender, EventArgs e)
        {
            Shell.WriteLine("创建脚本");
            ScriptGenerator.Create(ClassCombo.SelectedItem.ToString(), inputClassName.Text, "JoeyHuang", inputDesc.Text);
            Shell.WriteLine("完成");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enumBtn_Click(object sender, EventArgs e)
        {
            string _path;
            Shell.WriteLine("创建枚举");
            FileSelectTool.SelectFolders(out _path);
            DirectoryInfo directoryInfo = new DirectoryInfo(_path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            List<string> fields = new List<string>();
            string str = "";
            for (int i = 0; i < fileInfos.Length; i++)
            {
                if (fileInfos[i].Extension != ".meta")
                {
                    string _enum = fileInfos[i].Name.Split('.')[0];
                    fields.Add(_enum);
                    str += _enum + "\r\n";
                    Shell.WriteLine("name:"+_enum);
                }
            }
            ScriptGenerator.GeneratorTsEnum(InputEnumName.Text, fields.ToArray(), _path);
            Shell.WriteLine("完成");
        }
    }
}
