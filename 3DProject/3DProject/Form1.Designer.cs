namespace _3DProject
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CBX = new System.Windows.Forms.CheckBox();
            this.CBY = new System.Windows.Forms.CheckBox();
            this.CBZ = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(36, 16);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 250;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(385, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 250;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // CBX
            // 
            this.CBX.AutoSize = true;
            this.CBX.Location = new System.Drawing.Point(519, 16);
            this.CBX.Name = "CBX";
            this.CBX.Size = new System.Drawing.Size(30, 16);
            this.CBX.TabIndex = 5;
            this.CBX.Text = "X";
            this.CBX.UseVisualStyleBackColor = true;
           
            // 
            // CBY
            // 
            this.CBY.AutoSize = true;
            this.CBY.Location = new System.Drawing.Point(596, 16);
            this.CBY.Name = "CBY";
            this.CBY.Size = new System.Drawing.Size(30, 16);
            this.CBY.TabIndex = 6;
            this.CBY.Text = "Y";
            this.CBY.UseVisualStyleBackColor = true;
            // 
            // CBZ
            // 
            this.CBZ.AutoSize = true;
            this.CBZ.Location = new System.Drawing.Point(675, 16);
            this.CBZ.Name = "CBZ";
            this.CBZ.Size = new System.Drawing.Size(30, 16);
            this.CBZ.TabIndex = 7;
            this.CBZ.Text = "Z";
            this.CBZ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBZ);
            this.Controls.Add(this.CBY);
            this.Controls.Add(this.CBX);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox CBX;
        private System.Windows.Forms.CheckBox CBY;
        private System.Windows.Forms.CheckBox CBZ;
    }
}

