namespace OrderManagerPro
{
    partial class DB_MistakesMadeBy
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
            this.FromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
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
            this.MainWindowChart.Location = new System.Drawing.Point(0, 114);
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
            series1.Name = "MistakeMadeBy";
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            this.MainWindowChart.Series.Add(series1);
            this.MainWindowChart.Size = new System.Drawing.Size(1440, 563);
            this.MainWindowChart.TabIndex = 3;
            this.MainWindowChart.Text = "chart1";
            // 
            // FromDateDateTimePicker
            // 
            this.FromDateDateTimePicker.Location = new System.Drawing.Point(22, 39);
            this.FromDateDateTimePicker.Name = "FromDateDateTimePicker";
            this.FromDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FromDateDateTimePicker.TabIndex = 4;
            // 
            // EndDateDateTimePicker
            // 
            this.EndDateDateTimePicker.Location = new System.Drawing.Point(253, 39);
            this.EndDateDateTimePicker.Name = "EndDateDateTimePicker";
            this.EndDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.EndDateDateTimePicker.TabIndex = 5;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Location = new System.Drawing.Point(18, 12);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(85, 20);
            this.FromDateLabel.TabIndex = 6;
            this.FromDateLabel.Text = "From Date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(249, 13);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(77, 20);
            this.EndDateLabel.TabIndex = 7;
            this.EndDateLabel.Text = "End Date";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(378, 75);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(148, 75);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 31);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = " Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(253, 75);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 31);
            this.ForwardButton.TabIndex = 10;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(22, 75);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 31);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DB_MistakesMadeBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 678);
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
            this.Name = "DB_MistakesMadeBy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_MistakesMadeBy";
            this.Load += new System.EventHandler(this.DB_MistakesMadeBy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainWindowChart;
        private System.Windows.Forms.DateTimePicker FromDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateDateTimePicker;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button ResetButton;
    }
}