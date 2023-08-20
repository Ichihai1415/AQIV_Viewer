namespace AQIV_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PGA = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.Times = new System.Windows.Forms.TextBox();
            this.SubText = new System.Windows.Forms.Label();
            this.RealTimeCB = new System.Windows.Forms.CheckBox();
            this.View = new System.Windows.Forms.Button();
            this.NowTime = new System.Windows.Forms.Button();
            this.RealTime = new System.Windows.Forms.Timer(this.components);
            this.Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(20, 20);
            this.Chart.Margin = new System.Windows.Forms.Padding(5);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(600, 300);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Chart1";
            // 
            // PGA
            // 
            this.PGA.AutoSize = true;
            this.PGA.Font = new System.Drawing.Font("Roboto", 12F);
            this.PGA.Location = new System.Drawing.Point(494, 330);
            this.PGA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PGA.Name = "PGA";
            this.PGA.Size = new System.Drawing.Size(161, 24);
            this.PGA.TabIndex = 2;
            this.PGA.Text = "Max: - - - - . - - gal";
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(20, 327);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(159, 32);
            this.StartTime.TabIndex = 3;
            this.StartTime.Text = "2000/01/01 00:00:00";
            // 
            // Times
            // 
            this.Times.Location = new System.Drawing.Point(200, 327);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(35, 32);
            this.Times.TabIndex = 4;
            this.Times.Text = "1";
            // 
            // SubText
            // 
            this.SubText.AutoSize = true;
            this.SubText.Font = new System.Drawing.Font("Roboto", 12F);
            this.SubText.Location = new System.Drawing.Point(179, 331);
            this.SubText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubText.Name = "SubText";
            this.SubText.Size = new System.Drawing.Size(89, 24);
            this.SubText.TabIndex = 5;
            this.SubText.Text = "～          s";
            // 
            // RealTimeCB
            // 
            this.RealTimeCB.AutoSize = true;
            this.RealTimeCB.Checked = true;
            this.RealTimeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RealTimeCB.Location = new System.Drawing.Point(325, 330);
            this.RealTimeCB.Name = "RealTimeCB";
            this.RealTimeCB.Size = new System.Drawing.Size(116, 28);
            this.RealTimeCB.TabIndex = 6;
            this.RealTimeCB.Text = "リアルタイム";
            this.RealTimeCB.UseVisualStyleBackColor = true;
            this.RealTimeCB.CheckedChanged += new System.EventHandler(this.RealTimeCB_CheckedChanged);
            // 
            // View
            // 
            this.View.Enabled = false;
            this.View.Location = new System.Drawing.Point(431, 326);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(60, 30);
            this.View.TabIndex = 8;
            this.View.Text = "表示";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // NowTime
            // 
            this.NowTime.Location = new System.Drawing.Point(253, 326);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(60, 30);
            this.NowTime.TabIndex = 9;
            this.NowTime.Text = "現在";
            this.NowTime.UseVisualStyleBackColor = true;
            this.NowTime.Click += new System.EventHandler(this.NowTime_Click);
            // 
            // RealTime
            // 
            this.RealTime.Enabled = true;
            this.RealTime.Tick += new System.EventHandler(this.RealTime_Tick);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Roboto", 10F);
            this.Message.Location = new System.Drawing.Point(0, 0);
            this.Message.MaximumSize = new System.Drawing.Size(640, 360);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 20);
            this.Message.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.NowTime);
            this.Controls.Add(this.View);
            this.Controls.Add(this.RealTimeCB);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.PGA);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.SubText);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AQIV Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label PGA;
        private System.Windows.Forms.TextBox StartTime;
        private System.Windows.Forms.TextBox Times;
        private System.Windows.Forms.Label SubText;
        private System.Windows.Forms.CheckBox RealTimeCB;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button NowTime;
        private System.Windows.Forms.Timer RealTime;
        private System.Windows.Forms.Label Message;
    }
}

