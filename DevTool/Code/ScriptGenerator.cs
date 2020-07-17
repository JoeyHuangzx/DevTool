/**
 * 
 * Author:JoeyHuang
 * Time: 2020/7/17 19:06:33
 * 说明：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code;
using DevTool;

namespace Code
{
    public class ScriptGenerator
    {
        public static string Create(string _enum, string _className, string _author, string _desc = "")
        {
            string str = "";
            switch (_enum)
            {
                case "ComponentClass":
                    str = CreateScript("ComponentClass", _className, _author, _desc);
                    break;
                case "ComponentInstance":
                    str = CreateScript("ComponentInstance", _className, _author, _desc);
                    break;
                case "DemoClass":
                    str = CreateScript("DemoClass", _className, _author, _desc);
                    break;
                case "Instance":
                    str = CreateScript("Instance", _className, _author, _desc);
                    break;
                case "GetInstance":
                    str = CreateScript("GetInstance", _className, _author, _desc);
                    break;
                default:
                    break;
            }
            return str;
        }

        public static string CreateScript(string _scriptName, string _className, string _author, string _desc = "")
        {
            string str = FileTool.GetFileContent("TemplateClass/" + _scriptName + ".ts");
            string str2 = str;
            str2 = str2.Replace(_scriptName, _className);
            int pointer = 1;
            while (str2.IndexOf("-xxx-") != -1)
            {
                int _index = str2.IndexOf("-xxx-");
                if (pointer == 1)
                {
                    str2 = str2.Remove(_index, 5);
                    str2 = str2.Insert(_index, _author);
                }
                else if (pointer == 2)
                {
                    str2 = str2.Remove(_index, 5);
                    str2 = str2.Insert(_index, DateTime.Now.ToString());
                }
                else if (pointer == 3)
                {
                    str2 = str2.Remove(_index, 5);
                    str2 = str2.Insert(_index, _desc);
                }
                pointer++;
            }
            Shell.WriteLine(str2);
            FileTool.WriteToTxt(str2, _className + ".ts", true);
            return str + "\r\n" + str2;
        }

        public static string GeneratorTsEnum(string ClassName, string[] Fields, string _path)
        {
            StringBuilder _source = new StringBuilder();
            _source.Append("const {ccclass, property} = cc._decorator;\n");
            _source.Append("\n");
            _source.Append("\n");
            _source.Append("export enum " + ClassName + " \n");
            _source.Append("{\n");

            for (int i = 0; i < Fields.Length; i++)
            {
                string _field = Fields[i];
                _source.Append("\t " + _field + "=\"" + Fields[i] + "\",\n");
            }
            _source.Append("\n");
            _source.Append("}");
            FileTool.WriteToTxt(_source.ToString(), _path + "\\" + ClassName + ".ts", true);


            return _source.ToString();
        }
    }
}
