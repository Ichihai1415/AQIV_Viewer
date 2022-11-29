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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PGA = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.Times = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RealTimeCB = new System.Windows.Forms.CheckBox();
            this.RealTimeTimes = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.Location = new System.Drawing.Point(179, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "～          s";
            // 
            // RealTimeCB
            // 
            this.RealTimeCB.AutoSize = true;
            this.RealTimeCB.Enabled = false;
            this.RealTimeCB.Location = new System.Drawing.Point(258, 328);
            this.RealTimeCB.Name = "RealTimeCB";
            this.RealTimeCB.Size = new System.Drawing.Size(219, 28);
            this.RealTimeCB.TabIndex = 6;
            this.RealTimeCB.Text = "リアルタイム 過去          s";
            this.RealTimeCB.UseVisualStyleBackColor = true;
            // 
            // RealTimeTimes
            // 
            this.RealTimeTimes.Enabled = false;
            this.RealTimeTimes.Location = new System.Drawing.Point(379, 326);
            this.RealTimeTimes.Name = "RealTimeTimes";
            this.RealTimeTimes.Size = new System.Drawing.Size(35, 32);
            this.RealTimeTimes.TabIndex = 7;
            this.RealTimeTimes.Text = "1";
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(431, 326);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(60, 30);
            this.View.TabIndex = 8;
            this.View.Text = "表示";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.View);
            this.Controls.Add(this.RealTimeTimes);
            this.Controls.Add(this.RealTimeCB);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.PGA);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox RealTimeCB;
        private System.Windows.Forms.TextBox RealTimeTimes;
        private System.Windows.Forms.Button View;
    }
}

