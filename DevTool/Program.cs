using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTool
{
    public static class Program
    {
        [DllImport("kernel32.dll",SetLastError =true)]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Boolean FreeConsole();
        [DllImport("kernel32", SetLastError = true)]
        private static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            DebugConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DevTool());

            

        }

        static void DebugConsole()
        {
            
            AllocConsole();
            Shell.WriteLine("注意：启动程序...");
            Shell.WriteLine("\tWritten by wuming");
            Shell.WriteLine("{0}：{1}", "警告", "这是一条警告信息。");
            Shell.WriteLine("{0}：{1}", "错误", "这是一条错误信息！");
            Shell.WriteLine("{0}：{1}", "注意", "这是一条需要的注意信息。");
            Shell.WriteLine("");
          
        }
    }

    public static class Shell
    {
        public static void Show()
        {
            
        }

        /// <summary>  
        /// 输出信息  
        /// </summary>  
        /// <param name="format"></param>  
        /// <param name="args"></param>  
        public static void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
        }

        /// <summary>  
        /// 输出信息  
        /// </summary>  
        /// <param name="output"></param>  
        public static void WriteLine(string output)
        {
            Console.ForegroundColor = GetConsoleColor(output);
            Console.WriteLine(@"[{0}]{1}", DateTimeOffset.Now, output);
        }

        /// <summary>  
        /// 根据输出文本选择控制台文字颜色  
        /// </summary>  
        /// <param name="output"></param>  
        /// <returns></returns>  
        private static ConsoleColor GetConsoleColor(string output)
        {
            if (output.StartsWith("警告")) return ConsoleColor.Yellow;
            if (output.StartsWith("错误")) return ConsoleColor.Red;
            if (output.StartsWith("注意")) return ConsoleColor.Green;
            return ConsoleColor.Gray;
        }
    }  
}
