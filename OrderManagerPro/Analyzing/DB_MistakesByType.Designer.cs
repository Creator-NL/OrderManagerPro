namespace OrderManagerPro
{
    partial class DB_MistakesByType
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainWindowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.EndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWindowChart
            // 
            this.MainWindowChart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.MainWindowChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainWindowChart.Legends.Add(legend1);
            this.MainWindowChart.Location = new System.Drawing.Point(0, 110);
            this.MainWindowChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainWindowChart.Name = "MainWindowChart";
            this.MainWindowChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.IndianRed;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Yellow;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "MistakeTypes";
            this.MainWindowChart.Series.Add(series1);
            this.MainWindowChart.Size = new System.Drawing.Size(1440, 588);
            this.MainWindowChart.TabIndex = 4;
            this.MainWindowChart.Text = "chart1";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(13, 71);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 31);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(244, 71);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 31);
            this.ForwardButton.TabIndex = 18;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(139, 71);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 31);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = " Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(369, 71);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(240, 9);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(77, 20);
            this.EndDateLabel.TabIndex = 15;
            this.EndDateLabel.Text = "End Date";
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Location = new System.Drawing.Point(9, 8);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(85, 20);
            this.FromDateLabel.TabIndex = 14;
            this.FromDateLabel.Text = "From Date";
            // 
            // EndDateDateTimePicker
            // 
            this.EndDateDateTimePicker.Location = new System.Drawing.Point(244, 35);
            this.EndDateDateTimePicker.Name = "EndDateDateTimePicker";
            this.EndDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.EndDateDateTimePicker.TabIndex = 13;
            // 
            // FromDateDateTimePicker
            // 
            this.FromDateDateTimePicker.Location = new System.Drawing.Point(13, 35);
            this.FromDateDateTimePicker.Name = "FromDateDateTimePicker";
            this.FromDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FromDateDateTimePicker.TabIndex = 12;
            // 
            // DB_MistakesByType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 699);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.EndDateDateTimePicker);
            this.Controls.Add(this.FromDateDateTimePicker);
            this.Controls.Add(this.MainWindowChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_MistakesByType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_MistakesByType";
            this.Load += new System.EventHandler(this.DB_MistakesByType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainWindowChart;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.DateTimePicker EndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateDateTimePicker;
    }
}