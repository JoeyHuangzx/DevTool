using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevTool.FileTools;
using DevTool.ImageTools;
using DevTool.ScriptsTools;
using DevTool.TableTools;

namespace DevTool
{
    public partial class DevTool : Form
    {
        public DevTool()
        {
            InitializeComponent();
        }

        private void DevTool_Load(object sender, EventArgs e)
        {

        }

        private void scriptToolBtn_Click(object sender, EventArgs e)
        {
            ScriptToolForm form = new ScriptToolForm();
            Shell.WriteLine("显示 ScriptToolForm");
            form.Show();
        }

        private void FileToolBtn_Click(object sender, EventArgs e)
        {
            FileToolForm form = new FileToolForm();
            Shell.WriteLine("显示 FileToolForm");
            form.Show();
        }

        private void imageToolBtn_Click(object sender, EventArgs e)
        {
            ImageToolForm form = new ImageToolForm();
            Shell.WriteLine("显示 ImageToolForm");
            form.Show();
        }

        private void tableToolBtn_Click(object sender, EventArgs e)
        {
            TableToolForm form = new TableToolForm();
            Shell.WriteLine("显示 TableToolForm");
            form.Show();
        }
    }
}
