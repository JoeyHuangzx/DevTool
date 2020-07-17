namespace DevTool.ImageTools
{
    partial class ImageToolForm
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
            this.pngToJpgBtn = new System.Windows.Forms.Button();
            this.jpgTopng = new System.Windows.Forms.Button();
            this.compressImageBtn = new System.Windows.Forms.Button();
            this.changeWHBtn = new System.Windows.Forms.Button();
            this.selectImgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputFlag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputImgSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectChangeWHbtn = new System.Windows.Forms.Button();
            this.inputChangeWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pngToJpgBtn
            // 
            this.pngToJpgBtn.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.pngToJpgBtn.Location = new System.Drawing.Point(54, 40);
            this.pngToJpgBtn.Name = "pngToJpgBtn";
            this.pngToJpgBtn.Size = new System.Drawing.Size(120, 40);
            this.pngToJpgBtn.TabIndex = 0;
            this.pngToJpgBtn.Text = "png-Jpg";
            this.pngToJpgBtn.UseVisualStyleBackColor = true;
            this.pngToJpgBtn.Click += new System.EventHandler(this.pngToJpgBtn_Click);
            // 
            // jpgTopng
            // 
            this.jpgTopng.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.jpgTopng.Location = new System.Drawing.Point(203, 40);
            this.jpgTopng.Name = "jpgTopng";
            this.jpgTopng.Size = new System.Drawing.Size(120, 40);
            this.jpgTopng.TabIndex = 1;
            this.jpgTopng.Text = "jpg-png";
            this.jpgTopng.UseVisualStyleBackColor = true;
            this.jpgTopng.Click += new System.EventHandler(this.jpgTopng_Click);
            // 
            // compressImageBtn
            // 
            this.compressImageBtn.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.compressImageBtn.Location = new System.Drawing.Point(668, 165);
            this.compressImageBtn.Name = "compressImageBtn";
            this.compressImageBtn.Size = new System.Drawing.Size(120, 40);
            this.compressImageBtn.TabIndex = 2;
            this.compressImageBtn.Text = "开始压缩";
            this.compressImageBtn.UseVisualStyleBackColor = true;
            this.compressImageBtn.Click += new System.EventHandler(this.compressImageBtn_Click);
            // 
            // changeWHBtn
            // 
            this.changeWHBtn.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.changeWHBtn.Location = new System.Drawing.Point(452, 235);
            this.changeWHBtn.Name = "changeWHBtn";
            this.changeWHBtn.Size = new System.Drawing.Size(120, 40);
            this.changeWHBtn.TabIndex = 3;
            this.changeWHBtn.Text = "开始改变";
            this.changeWHBtn.UseVisualStyleBackColor = true;
            this.changeWHBtn.Click += new System.EventHandler(this.changeWHBtn_Click);
            // 
            // selectImgBtn
            // 
            this.selectImgBtn.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.selectImgBtn.Location = new System.Drawing.Point(12, 116);
            this.selectImgBtn.Name = "selectImgBtn";
            this.selectImgBtn.Size = new System.Drawing.Size(120, 40);
            this.selectImgBtn.TabIndex = 4;
            this.selectImgBtn.Text = "选择图片";
            this.selectImgBtn.UseVisualStyleBackColor = true;
            this.selectImgBtn.Click += new System.EventHandler(this.selectImgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(138, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "压缩率(1-100):";
            // 
            // InputFlag
            // 
            this.InputFlag.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputFlag.Location = new System.Drawing.Point(282, 124);
            this.InputFlag.Name = "InputFlag";
            this.InputFlag.Size = new System.Drawing.Size(101, 33);
            this.InputFlag.TabIndex = 6;
            this.InputFlag.Text = "90";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(389, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "图片大小最大值(kb)：";
            // 
            // inputImgSize
            // 
            this.inputImgSize.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputImgSize.Location = new System.Drawing.Point(593, 126);
            this.inputImgSize.Name = "inputImgSize";
            this.inputImgSize.Size = new System.Drawing.Size(101, 33);
            this.inputImgSize.TabIndex = 8;
            this.inputImgSize.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(138, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "指定宽度:";
            // 
            // selectChangeWHbtn
            // 
            this.selectChangeWHbtn.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.selectChangeWHbtn.Location = new System.Drawing.Point(12, 235);
            this.selectChangeWHbtn.Name = "selectChangeWHbtn";
            this.selectChangeWHbtn.Size = new System.Drawing.Size(120, 40);
            this.selectChangeWHbtn.TabIndex = 10;
            this.selectChangeWHbtn.Text = "选择图片";
            this.selectChangeWHbtn.UseVisualStyleBackColor = true;
            this.selectChangeWHbtn.Click += new System.EventHandler(this.selectChangeWHbtn_Click);
            // 
            // inputChangeWidth
            // 
            this.inputChangeWidth.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputChangeWidth.Location = new System.Drawing.Point(237, 235);
            this.inputChangeWidth.Name = "inputChangeWidth";
            this.inputChangeWidth.Size = new System.Drawing.Size(101, 33);
            this.inputChangeWidth.TabIndex = 11;
            this.inputChangeWidth.Text = "1280";
            // 
            // ImageToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputChangeWidth);
            this.Controls.Add(this.selectChangeWHbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputImgSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputFlag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectImgBtn);
            this.Controls.Add(this.changeWHBtn);
            this.Controls.Add(this.compressImageBtn);
            this.Controls.Add(this.jpgTopng);
            this.Controls.Add(this.pngToJpgBtn);
            this.Name = "ImageToolForm";
            this.Text = "ImageToolForm";
            this.Load += new System.EventHandler(this.ImageToolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pngToJpgBtn;
        private System.Windows.Forms.Button jpgTopng;
        private System.Windows.Forms.Button compressImageBtn;
        private System.Windows.Forms.Button changeWHBtn;
        private System.Windows.Forms.Button selectImgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputFlag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputImgSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectChangeWHbtn;
        private System.Windows.Forms.TextBox inputChangeWidth;
    }
}