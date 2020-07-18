namespace DevTool
{
    partial class LogForm
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
            this.LogInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogInput
            // 
            this.LogInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.LogInput.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogInput.ForeColor = System.Drawing.SystemColors.Info;
            this.LogInput.Location = new System.Drawing.Point(13, 13);
            this.LogInput.Multiline = true;
            this.LogInput.Name = "LogInput";
            this.LogInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogInput.Size = new System.Drawing.Size(769, 545);
            this.LogInput.TabIndex = 0;
            this.LogInput.TextChanged += new System.EventHandler(this.LogInput_TextChanged);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LogInput);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogInput;
    }
}