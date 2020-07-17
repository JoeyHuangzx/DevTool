/**
 * 
 * Author:JoeyHuang
 * Time: 2020/7/17 17:00:06
 * 说明：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public class FileSelectTool
    {

        /// <summary>
        /// 选择文件（多选）
        /// </summary>
        /// <param name="paths"></param>
        public static void SelectFiles(out List<string> paths)
        {
            paths = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "选择文件";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                paths=dialog.FileNames.ToList();
            }
            
        }

        /// <summary>
        /// 选择文件夹路径
        /// </summary>
        /// <param name="folderPath"></param>
        public static void SelectFolders(out string folderPath)
        {
            folderPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;

            }
        }
    }


}
