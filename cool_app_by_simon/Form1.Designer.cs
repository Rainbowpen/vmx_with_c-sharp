namespace cool_app_by_simon
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_show = new System.Windows.Forms.Button();
            this.label_show = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.label_mpos = new System.Windows.Forms.Label();
            this.label_mpos2 = new System.Windows.Forms.Label();
            this.label_mpos3 = new System.Windows.Forms.Label();
            this.progressBar_feedOvr = new System.Windows.Forms.ProgressBar();
            this.label_prog = new System.Windows.Forms.Label();
            this.timer_update_2 = new System.Windows.Forms.Timer(this.components);
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            this.SuspendLayout();
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(26, 13);
            this.button_show.Margin = new System.Windows.Forms.Padding(4);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(342, 76);
            this.button_show.TabIndex = 0;
            this.button_show.Text = "button1";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Location = new System.Drawing.Point(55, 385);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(90, 27);
            this.label_show.TabIndex = 1;
            this.label_show.Text = "output";
            this.label_show.Click += new System.EventHandler(this.label_show_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(26, 438);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(342, 34);
            this.textBox_input.TabIndex = 2;
            this.textBox_input.Text = "This is a line of text.";
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // timer_update
            // 
            this.timer_update.Interval = 1000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(44, 499);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(142, 27);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "label_time";
            this.label_time.Click += new System.EventHandler(this.label_time_Click);
            // 
            // label_mpos
            // 
            this.label_mpos.AutoSize = true;
            this.label_mpos.Location = new System.Drawing.Point(55, 178);
            this.label_mpos.Name = "label_mpos";
            this.label_mpos.Size = new System.Drawing.Size(77, 27);
            this.label_mpos.TabIndex = 4;
            this.label_mpos.Text = "mpos1";
            this.label_mpos.Click += new System.EventHandler(this.label_mpos_Click);
            // 
            // label_mpos2
            // 
            this.label_mpos2.AutoSize = true;
            this.label_mpos2.Location = new System.Drawing.Point(55, 221);
            this.label_mpos2.Name = "label_mpos2";
            this.label_mpos2.Size = new System.Drawing.Size(77, 27);
            this.label_mpos2.TabIndex = 5;
            this.label_mpos2.Text = "mpos2";
            this.label_mpos2.Click += new System.EventHandler(this.label_mpos2_Click);
            // 
            // label_mpos3
            // 
            this.label_mpos3.AutoSize = true;
            this.label_mpos3.Location = new System.Drawing.Point(55, 266);
            this.label_mpos3.Name = "label_mpos3";
            this.label_mpos3.Size = new System.Drawing.Size(77, 27);
            this.label_mpos3.TabIndex = 6;
            this.label_mpos3.Text = "mpos3";
            this.label_mpos3.Click += new System.EventHandler(this.label_mpos3_Click);
            // 
            // progressBar_feedOvr
            // 
            this.progressBar_feedOvr.Location = new System.Drawing.Point(26, 332);
            this.progressBar_feedOvr.Name = "progressBar_feedOvr";
            this.progressBar_feedOvr.Size = new System.Drawing.Size(342, 23);
            this.progressBar_feedOvr.TabIndex = 7;
            this.progressBar_feedOvr.Click += new System.EventHandler(this.progressBar_feedOvr_Click);
            // 
            // label_prog
            // 
            this.label_prog.AutoSize = true;
            this.label_prog.Location = new System.Drawing.Point(55, 134);
            this.label_prog.Name = "label_prog";
            this.label_prog.Size = new System.Drawing.Size(90, 27);
            this.label_prog.TabIndex = 8;
            this.label_prog.Text = "label1";
            // 
            // timer_update_2
            // 
            this.timer_update_2.Tick += new System.EventHandler(this.timer_update_2_Tick);
            // 
            // chart_data
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_data.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_data.Legends.Add(legend4);
            this.chart_data.Location = new System.Drawing.Point(386, 12);
            this.chart_data.Name = "chart_data";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_data.Series.Add(series4);
            this.chart_data.Size = new System.Drawing.Size(937, 482);
            this.chart_data.TabIndex = 9;
            this.chart_data.Text = "chart1";
            this.chart_data.Click += new System.EventHandler(this.chart_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1335, 551);
            this.Controls.Add(this.chart_data);
            this.Controls.Add(this.label_prog);
            this.Controls.Add(this.progressBar_feedOvr);
            this.Controls.Add(this.label_mpos3);
            this.Controls.Add(this.label_mpos2);
            this.Controls.Add(this.label_mpos);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_show);
            this.Controls.Add(this.button_show);
            this.Font = new System.Drawing.Font("Source Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(209, 290);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_mpos;
        private System.Windows.Forms.Label label_mpos2;
        private System.Windows.Forms.Label label_mpos3;
        private System.Windows.Forms.ProgressBar progressBar_feedOvr;
        private System.Windows.Forms.Label label_prog;
        private System.Windows.Forms.Timer timer_update_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
    }
}

