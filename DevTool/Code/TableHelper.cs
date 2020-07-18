/**
 * 
 * Author:JoeyHuang
 * Time: 2020/7/18 9:59:49
 * 说明：
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using OfficeOpenXml;
using DevTool;

namespace Code
{
    public class TableHelper
    {
        public static DataSet ImportExcel(string filePath, string fileName,int rowNum,int tableNum)
        {
            DataSet ds = null;
            DataTable dt = null;


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            Microsoft.Office.Interop.Excel.Sheets sheets = null;
            Microsoft.Office.Interop.Excel.Range range = null;
            object missing = System.Reflection.Missing.Value;

            try
            {
                if (excel == null)
                {
                    return null;
                }

                //打开 Excel 文件
                workbook = excel.Workbooks.Open(filePath, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                List<string> _types = new List<string>();
                List<string> _fields = new List<string>();
                List<string> _descs = new List<string>();
                //获取所有的 sheet 表
                sheets = workbook.Worksheets;
                ds = new DataSet();
                Shell.WriteLine(sheets.Count.ToString());
                int sheetCount = 1;
                if (tableNum > 1) sheetCount = sheets.Count;
                for (int i = 1; i <= sheetCount; i++)
                {
                    //获取第一个表
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(i);

                    int rowCount = worksheet.UsedRange.Rows.Count;
                    int colCount = worksheet.UsedRange.Columns.Count;

                    int rowIndex = 1;   //起始行为 1
                    int colIndex = 1;   //起始列为 1

                    DataColumn dc;
                    dt = new DataTable();
                    dt.TableName = "table" + i.ToString();
                    string str = "";
                    //读取列名
                    for (int j = 0; j < colCount; j++)
                    {
                        range = worksheet.Cells[rowNum, colIndex + j];

                        dc = new DataColumn();
                        dc.DataType = Type.GetType("System.String");
                        dc.ColumnName = range.Text.ToString().Trim();
                        // textBox1.AppendText(dc.ColumnName+",");
                        //添加列
                        dt.Columns.Add(dc);
                    }
                    //textBox1.AppendText("[");
                    str += "[";
                    //读取行数据
                    for (int k = 2; k < rowCount; k++)
                    {
                        str += "{";
                        DataRow dr = dt.NewRow();
                        for (int l = 0; l < colCount; l++)
                        {
                            range = worksheet.Cells[rowIndex + k, colIndex + l];

                            //使用 range.Value.ToString(); 或 range.Value2.ToString(); 或 range.Text.ToString(); 都可以获取单元格的值
                            dr[l] = range.Text.ToString();
                            //if (dt.Columns[l].ToString() != "名称" && dt.Columns[l].ToString() != "获取途径")
                            //{
                            //    textBox1.AppendText("" + dr[l] + "");
                            //}
                            //else
                            //{
                            //    textBox1.AppendText("\'" + dr[l] + "\'");
                            //}

                            str += "\"" + dt.Columns[l].ToString().TrimEnd() + "\":\"" + dr[l] + "\"";
                            if (l != colCount - 1)
                            {
                              //  textBox1.AppendText(",");
                                str += ",";
                            }
                        }
                        dt.Rows.Add(dr.ItemArray);
                        //textBox1.AppendText(")");
                        str += "}";
                        if (k != rowCount - 1)
                        {
                          //  textBox1.AppendText(",");
                            str += ",";
                        }

                        //textBox1.AppendText("\n");
                        str += "\n";
                    }
                    //textBox1.AppendText("]");
                    str += "]";
                    ds.Tables.Add(dt);
                    str =FileTool.ConvertJsonString(str);
                    StreamWriter streamWriter = null;
                    if (rowNum > 1)
                    {
                        fileName = worksheet.Name;
                    }
                    streamWriter = File.AppendText(Environment.CurrentDirectory + "/" + fileName + ".json");
                    streamWriter.WriteLine(str);
                    streamWriter.Close();
                    //textBox1.AppendText(str);
                }

            }
            catch (Exception ex)
            {
                //textBox1.AppendText(ex.Message);
                //throw;
            }
            finally
            {
                workbook.Close();

                //关闭退出
                excel.Quit();

                //释放 COM 对象
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excel);

                worksheet = null;
                workbook = null;
                excel = null;

                GC.Collect();
            }
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                foreach (DataColumn mDc in ds.Tables[0].Columns)
                {
                    //textBox1.AppendText(mDr[mDc].ToString()+"\n");
                    //Console.WriteLine(mDr[mDc].ToString());
                }
            }
            return ds;
        }
    }
}
