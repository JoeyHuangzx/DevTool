using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTool
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            Shell.logCallBack += Log;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        public void Log(string str)
        {
            LogInput.AppendText(str);
            LogInput.AppendText("\r\n");
        }

        private void LogInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
