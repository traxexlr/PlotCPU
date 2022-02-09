
namespace PlotCPUtemperature
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userCurve1 = new HslCommunication.Controls.UserCurve();
            this.userButton2 = new HslCommunication.Controls.UserButton();
            this.userButton3 = new HslCommunication.Controls.UserButton();
            this.SuspendLayout();
            // 
            // userCurve1
            // 
            this.userCurve1.BackColor = System.Drawing.Color.Transparent;
            this.userCurve1.IsAbscissaStrech = true;
            this.userCurve1.Location = new System.Drawing.Point(12, 12);
            this.userCurve1.Name = "userCurve1";
            this.userCurve1.Size = new System.Drawing.Size(776, 426);
            this.userCurve1.StrechDataCountMax = 10;
            this.userCurve1.TabIndex = 0;
            this.userCurve1.ValueMaxLeft = 80F;
            this.userCurve1.ValueMinLeft = 20F;
            // 
            // userButton2
            // 
            this.userButton2.BackColor = System.Drawing.Color.Transparent;
            this.userButton2.CustomerInformation = "";
            this.userButton2.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.userButton2.Location = new System.Drawing.Point(62, 444);
            this.userButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton2.Name = "userButton2";
            this.userButton2.Size = new System.Drawing.Size(78, 43);
            this.userButton2.TabIndex = 2;
            this.userButton2.UIText = "开始";
            this.userButton2.Click += new System.EventHandler(this.userButton2_Click);
            // 
            // userButton3
            // 
            this.userButton3.BackColor = System.Drawing.Color.Transparent;
            this.userButton3.CustomerInformation = "";
            this.userButton3.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.userButton3.Location = new System.Drawing.Point(175, 445);
            this.userButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton3.Name = "userButton3";
            this.userButton3.Size = new System.Drawing.Size(78, 42);
            this.userButton3.TabIndex = 3;
            this.userButton3.UIText = "停止";
            this.userButton3.Click += new System.EventHandler(this.userButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.userButton3);
            this.Controls.Add(this.userButton2);
            this.Controls.Add(this.userCurve1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HslCommunication.Controls.UserCurve userCurve1;
        private HslCommunication.Controls.UserButton userButton2;
        private HslCommunication.Controls.UserButton userButton3;
    }
}

