namespace DevTool.ScriptsTools
{
    partial class ScriptToolForm
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
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.inputClassName = new System.Windows.Forms.TextBox();
            this.inputDesc = new System.Windows.Forms.TextBox();
            this.generatorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputEnumName = new System.Windows.Forms.TextBox();
            this.enumBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassCombo
            // 
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Location = new System.Drawing.Point(37, 66);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(121, 20);
            this.ClassCombo.TabIndex = 0;
            // 
            // inputClassName
            // 
            this.inputClassName.Location = new System.Drawing.Point(164, 66);
            this.inputClassName.Name = "inputClassName";
            this.inputClassName.Size = new System.Drawing.Size(100, 21);
            this.inputClassName.TabIndex = 1;
            // 
            // inputDesc
            // 
            this.inputDesc.Location = new System.Drawing.Point(270, 66);
            this.inputDesc.Multiline = true;
            this.inputDesc.Name = "inputDesc";
            this.inputDesc.Size = new System.Drawing.Size(241, 74);
            this.inputDesc.TabIndex = 3;
            // 
            // generatorBtn
            // 
            this.generatorBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.generatorBtn.Location = new System.Drawing.Point(558, 63);
            this.generatorBtn.Name = "generatorBtn";
            this.generatorBtn.Size = new System.Drawing.Size(120, 35);
            this.generatorBtn.TabIndex = 4;
            this.generatorBtn.Text = "生成脚本";
            this.generatorBtn.UseVisualStyleBackColor = true;
            this.generatorBtn.Click += new System.EventHandler(this.generatorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "类模板";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(159, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "类名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(32, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "枚举名：";
            // 
            // InputEnumName
            // 
            this.InputEnumName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputEnumName.Location = new System.Drawing.Point(126, 177);
            this.InputEnumName.Name = "InputEnumName";
            this.InputEnumName.Size = new System.Drawing.Size(177, 33);
            this.InputEnumName.TabIndex = 8;
            this.InputEnumName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enumBtn
            // 
            this.enumBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enumBtn.Location = new System.Drawing.Point(330, 177);
            this.enumBtn.Name = "enumBtn";
            this.enumBtn.Size = new System.Drawing.Size(120, 35);
            this.enumBtn.TabIndex = 9;
            this.enumBtn.Text = "生成枚举类";
            this.enumBtn.UseVisualStyleBackColor = true;
            this.enumBtn.Click += new System.EventHandler(this.enumBtn_Click);
            // 
            // ScriptToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.enumBtn);
            this.Controls.Add(this.InputEnumName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatorBtn);
            this.Controls.Add(this.inputDesc);
            this.Controls.Add(this.inputClassName);
            this.Controls.Add(this.ClassCombo);
            this.Name = "ScriptToolForm";
            this.Text = "ScriptToolForm";
            this.Load += new System.EventHandler(this.ScriptToolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.TextBox inputClassName;
        private System.Windows.Forms.TextBox inputDesc;
        private System.Windows.Forms.Button generatorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputEnumName;
        private System.Windows.Forms.Button enumBtn;
    }
}