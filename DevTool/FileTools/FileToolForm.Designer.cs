namespace DevTool.FileTools
{
    partial class FileToolForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFileName = new System.Windows.Forms.TextBox();
            this.selectFilesBtn = new System.Windows.Forms.Button();
            this.changeNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "批量修改文件名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件名首部分";
            // 
            // InputFileName
            // 
            this.InputFileName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputFileName.Location = new System.Drawing.Point(124, 59);
            this.InputFileName.Name = "InputFileName";
            this.InputFileName.Size = new System.Drawing.Size(171, 33);
            this.InputFileName.TabIndex = 3;
            // 
            // selectFilesBtn
            // 
            this.selectFilesBtn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectFilesBtn.Location = new System.Drawing.Point(327, 57);
            this.selectFilesBtn.Name = "selectFilesBtn";
            this.selectFilesBtn.Size = new System.Drawing.Size(120, 35);
            this.selectFilesBtn.TabIndex = 5;
            this.selectFilesBtn.Text = "选择文件";
            this.selectFilesBtn.UseVisualStyleBackColor = true;
            this.selectFilesBtn.Click += new System.EventHandler(this.selectFilesBtn_Click);
            // 
            // changeNameBtn
            // 
            this.changeNameBtn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeNameBtn.Location = new System.Drawing.Point(472, 57);
            this.changeNameBtn.Name = "changeNameBtn";
            this.changeNameBtn.Size = new System.Drawing.Size(120, 35);
            this.changeNameBtn.TabIndex = 6;
            this.changeNameBtn.Text = "修改";
            this.changeNameBtn.UseVisualStyleBackColor = true;
            this.changeNameBtn.Click += new System.EventHandler(this.changeNameBtn_Click);
            // 
            // FileToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.changeNameBtn);
            this.Controls.Add(this.selectFilesBtn);
            this.Controls.Add(this.InputFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileToolForm";
            this.Text = "FileToolForm";
            this.Load += new System.EventHandler(this.FileToolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputFileName;
        private System.Windows.Forms.Button selectFilesBtn;
        private System.Windows.Forms.Button changeNameBtn;
    }
}