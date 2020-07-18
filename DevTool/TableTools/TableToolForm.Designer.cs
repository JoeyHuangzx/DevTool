namespace DevTool.TableTools
{
    partial class TableToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jsonFormatBtn = new System.Windows.Forms.Button();
            this.importExcelBtn = new System.Windows.Forms.Button();
            this.InputRowIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputJsonBtn = new System.Windows.Forms.Button();
            this.InputTableNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jsonFormatBtn
            // 
            this.jsonFormatBtn.Location = new System.Drawing.Point(30, 371);
            this.jsonFormatBtn.Name = "jsonFormatBtn";
            this.jsonFormatBtn.Size = new System.Drawing.Size(120, 35);
            this.jsonFormatBtn.TabIndex = 0;
            this.jsonFormatBtn.Text = "格式化JSON";
            this.jsonFormatBtn.UseVisualStyleBackColor = true;
            this.jsonFormatBtn.Click += new System.EventHandler(this.jsonFormatBtn_Click);
            // 
            // importExcelBtn
            // 
            this.importExcelBtn.Location = new System.Drawing.Point(30, 51);
            this.importExcelBtn.Name = "importExcelBtn";
            this.importExcelBtn.Size = new System.Drawing.Size(120, 35);
            this.importExcelBtn.TabIndex = 1;
            this.importExcelBtn.Text = "导入Excel";
            this.importExcelBtn.UseVisualStyleBackColor = true;
            this.importExcelBtn.Click += new System.EventHandler(this.importExcelBtn_Click);
            // 
            // InputRowIndex
            // 
            this.InputRowIndex.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputRowIndex.Location = new System.Drawing.Point(175, 51);
            this.InputRowIndex.Name = "InputRowIndex";
            this.InputRowIndex.Size = new System.Drawing.Size(100, 33);
            this.InputRowIndex.TabIndex = 2;
            this.InputRowIndex.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "字段所在行(从0开始)";
            // 
            // outputJsonBtn
            // 
            this.outputJsonBtn.Location = new System.Drawing.Point(538, 49);
            this.outputJsonBtn.Name = "outputJsonBtn";
            this.outputJsonBtn.Size = new System.Drawing.Size(120, 35);
            this.outputJsonBtn.TabIndex = 4;
            this.outputJsonBtn.Text = "输出json";
            this.outputJsonBtn.UseVisualStyleBackColor = true;
            this.outputJsonBtn.Click += new System.EventHandler(this.outputJsonBtn_Click);
            // 
            // InputTableNum
            // 
            this.InputTableNum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputTableNum.Location = new System.Drawing.Point(361, 53);
            this.InputTableNum.Name = "InputTableNum";
            this.InputTableNum.Size = new System.Drawing.Size(100, 33);
            this.InputTableNum.TabIndex = 5;
            this.InputTableNum.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(373, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "表格数量";
            // 
            // TableToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputTableNum);
            this.Controls.Add(this.outputJsonBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputRowIndex);
            this.Controls.Add(this.importExcelBtn);
            this.Controls.Add(this.jsonFormatBtn);
            this.Name = "TableToolForm";
            this.Text = "TableToolForm";
            this.Load += new System.EventHandler(this.TableToolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jsonFormatBtn;
        private System.Windows.Forms.Button importExcelBtn;
        private System.Windows.Forms.TextBox InputRowIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button outputJsonBtn;
        private System.Windows.Forms.TextBox InputTableNum;
        private System.Windows.Forms.Label label2;
    }
}