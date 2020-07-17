/**
 * 
 * Author:JoeyHuang
 * Time: 2020/7/17 19:07:50
 * 说明：
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class FileTool
    {
        /// <summary>
        /// 获取文本文件内容
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static string GetFileContent(string filepath)
        {
            string errorStr = "";
            try
            {
                FileInfo fileInfo = new FileInfo(filepath);
                if (!fileInfo.Exists)
                {
                    return "The File not exists";
                }
                using (FileStream fs = new FileStream(filepath, FileMode.Open))
                {
                    byte[] bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, (int)fs.Length);
                    string ret = System.Text.Encoding.UTF8.GetString(bytes);
                    return ret;
                }
            }
            catch (Exception ex)
            {
                errorStr = ex.Message;
            }
            return errorStr;
        }

        /// <summary>
        /// 写入文本到文件
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="path"></param>
        public static void WriteToTxt(string txt, string path, bool isDeleteExist = false)
        {
            if (isDeleteExist)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txt);
            sw.Close();
            fs.Close();
        }
    }
}
