namespace _0403
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_ThreadCount = new System.Windows.Forms.Button();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.btn_CountAndShow = new System.Windows.Forms.Button();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Num3 = new System.Windows.Forms.TextBox();
            this.txt_Num4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_ThreadCount
            // 
            this.btn_ThreadCount.Location = new System.Drawing.Point(108, 12);
            this.btn_ThreadCount.Name = "btn_ThreadCount";
            this.btn_ThreadCount.Size = new System.Drawing.Size(75, 23);
            this.btn_ThreadCount.TabIndex = 1;
            this.btn_ThreadCount.Text = "线程计数";
            this.btn_ThreadCount.UseVisualStyleBackColor = true;
            this.btn_ThreadCount.Click += new System.EventHandler(this.btn_ThreadCount_Click);
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(12, 58);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 21);
            this.txt_Num.TabIndex = 2;
            // 
            // btn_CountAndShow
            // 
            this.btn_CountAndShow.Location = new System.Drawing.Point(145, 58);
            this.btn_CountAndShow.Name = "btn_CountAndShow";
            this.btn_CountAndShow.Size = new System.Drawing.Size(75, 23);
            this.btn_CountAndShow.TabIndex = 3;
            this.btn_CountAndShow.Text = "计算和显示";
            this.btn_CountAndShow.UseVisualStyleBackColor = true;
            this.btn_CountAndShow.Click += new System.EventHandler(this.btn_CountAndShow_Click);
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(12, 104);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 21);
            this.txt_Num2.TabIndex = 2;
            // 
            // txt_Num3
            // 
            this.txt_Num3.Location = new System.Drawing.Point(12, 146);
            this.txt_Num3.Name = "txt_Num3";
            this.txt_Num3.Size = new System.Drawing.Size(100, 21);
            this.txt_Num3.TabIndex = 2;
            // 
            // txt_Num4
            // 
            this.txt_Num4.Location = new System.Drawing.Point(12, 194);
            this.txt_Num4.Name = "txt_Num4";
            this.txt_Num4.Size = new System.Drawing.Size(100, 21);
            this.txt_Num4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_CountAndShow);
            this.Controls.Add(this.txt_Num4);
            this.Controls.Add(this.txt_Num3);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.btn_ThreadCount);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_ThreadCount;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Button btn_CountAndShow;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Num3;
        private System.Windows.Forms.TextBox txt_Num4;
    }
}

