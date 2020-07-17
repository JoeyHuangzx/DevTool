namespace DevTool
{
    partial class DevTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.scriptToolBtn = new System.Windows.Forms.Button();
            this.FileToolBtn = new System.Windows.Forms.Button();
            this.imageToolBtn = new System.Windows.Forms.Button();
            this.tableToolBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scriptToolBtn
            // 
            this.scriptToolBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scriptToolBtn.Location = new System.Drawing.Point(149, 300);
            this.scriptToolBtn.Name = "scriptToolBtn";
            this.scriptToolBtn.Size = new System.Drawing.Size(112, 36);
            this.scriptToolBtn.TabIndex = 0;
            this.scriptToolBtn.Text = "脚本工具";
            this.scriptToolBtn.UseVisualStyleBackColor = true;
            this.scriptToolBtn.Click += new System.EventHandler(this.scriptToolBtn_Click);
            // 
            // FileToolBtn
            // 
            this.FileToolBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.FileToolBtn.Location = new System.Drawing.Point(350, 300);
            this.FileToolBtn.Name = "FileToolBtn";
            this.FileToolBtn.Size = new System.Drawing.Size(112, 36);
            this.FileToolBtn.TabIndex = 1;
            this.FileToolBtn.Text = "文件工具";
            this.FileToolBtn.UseVisualStyleBackColor = true;
            this.FileToolBtn.Click += new System.EventHandler(this.FileToolBtn_Click);
            // 
            // imageToolBtn
            // 
            this.imageToolBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.imageToolBtn.Location = new System.Drawing.Point(516, 300);
            this.imageToolBtn.Name = "imageToolBtn";
            this.imageToolBtn.Size = new System.Drawing.Size(112, 36);
            this.imageToolBtn.TabIndex = 2;
            this.imageToolBtn.Text = "图像工具";
            this.imageToolBtn.UseVisualStyleBackColor = true;
            this.imageToolBtn.Click += new System.EventHandler(this.imageToolBtn_Click);
            // 
            // tableToolBtn
            // 
            this.tableToolBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.tableToolBtn.Location = new System.Drawing.Point(725, 300);
            this.tableToolBtn.Name = "tableToolBtn";
            this.tableToolBtn.Size = new System.Drawing.Size(112, 36);
            this.tableToolBtn.TabIndex = 3;
            this.tableToolBtn.Text = "表工具";
            this.tableToolBtn.UseVisualStyleBackColor = true;
            this.tableToolBtn.Click += new System.EventHandler(this.tableToolBtn_Click);
            // 
            // DevTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableToolBtn);
            this.Controls.Add(this.imageToolBtn);
            this.Controls.Add(this.FileToolBtn);
            this.Controls.Add(this.scriptToolBtn);
            this.Name = "DevTool";
            this.Text = "DevTool";
            this.Load += new System.EventHandler(this.DevTool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scriptToolBtn;
        private System.Windows.Forms.Button FileToolBtn;
        private System.Windows.Forms.Button imageToolBtn;
        private System.Windows.Forms.Button tableToolBtn;
    }
}

