
namespace OrderManagerPro
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.InboundDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.InboundAddNewInquiryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewReadyInquiriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewFinishedInquiriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.InboundSearchInquiryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StockControlDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.StockControlViewActiveInquiriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StockControlViewSeniorInquiriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StockControlViewFinishedInquiriesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInquiryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AnalyzingDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.MistakesMadeByButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MistakesByTypeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeTrackingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.UsersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.MainWindowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalInquiriesResultLabel = new System.Windows.Forms.Label();
            this.TotalFoundResultLabel = new System.Windows.Forms.Label();
            this.TotalFoundLabel = new System.Windows.Forms.Label();
            this.TotalNotFoundResultLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalFoundProcentLabel = new System.Windows.Forms.Label();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.DashBoardButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowChart)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InboundDropDownButton,
            this.toolStripSeparator1,
            this.StockControlDropDownButton,
            this.toolStripSeparator2,
            this.AnalyzingDropDownButton,
            this.toolStripSeparator3,
            this.SettingsDropDownButton,
            this.RefreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1476, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // InboundDropDownButton
            // 
            this.InboundDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InboundDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InboundAddNewInquiryButton,
            this.ViewReadyInquiriesButton,
            this.ViewFinishedInquiriesButton,
            this.InboundSearchInquiryButton});
            this.InboundDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("InboundDropDownButton.Image")));
            this.InboundDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InboundDropDownButton.Name = "InboundDropDownButton";
            this.InboundDropDownButton.Size = new System.Drawing.Size(98, 29);
            this.InboundDropDownButton.Text = "Inbound";
            // 
            // InboundAddNewInquiryButton
            // 
            this.InboundAddNewInquiryButton.Name = "InboundAddNewInquiryButton";
            this.InboundAddNewInquiryButton.Size = new System.Drawing.Size(293, 34);
            this.InboundAddNewInquiryButton.Text = "Add New Inquiry";
            this.InboundAddNewInquiryButton.Click += new System.EventHandler(this.InboundAddNewInquiryButton_Click);
            // 
            // ViewReadyInquiriesButton
            // 
            this.ViewReadyInquiriesButton.Name = "ViewReadyInquiriesButton";
            this.ViewReadyInquiriesButton.Size = new System.Drawing.Size(293, 34);
            this.ViewReadyInquiriesButton.Text = "View Ready Inquiries";
            this.ViewReadyInquiriesButton.Click += new System.EventHandler(this.ViewReadyInquiriesButton_Click);
            // 
            // ViewFinishedInquiriesButton
            // 
            this.ViewFinishedInquiriesButton.Name = "ViewFinishedInquiriesButton";
            this.ViewFinishedInquiriesButton.Size = new System.Drawing.Size(293, 34);
            this.ViewFinishedInquiriesButton.Text = "View Finished Inquiries";
            this.ViewFinishedInquiriesButton.Click += new System.EventHandler(this.ViewFinishedInquiriesButton_Click);
            // 
            // InboundSearchInquiryButton
            // 
            this.InboundSearchInquiryButton.Name = "InboundSearchInquiryButton";
            this.InboundSearchInquiryButton.Size = new System.Drawing.Size(293, 34);
            this.InboundSearchInquiryButton.Text = "Search Inquiry";
            this.InboundSearchInquiryButton.Click += new System.EventHandler(this.InboundSearchInquiryButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // StockControlDropDownButton
            // 
            this.StockControlDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StockControlDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StockControlViewActiveInquiriesButton,
            this.StockControlViewSeniorInquiriesButton,
            this.StockControlViewFinishedInquiriesButton,
            this.SearchInquiryButton});
            this.StockControlDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("StockControlDropDownButton.Image")));
            this.StockControlDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StockControlDropDownButton.Name = "StockControlDropDownButton";
            this.StockControlDropDownButton.Size = new System.Drawing.Size(137, 29);
            this.StockControlDropDownButton.Text = "Stock Control";
            // 
            // StockControlViewActiveInquiriesButton
            // 
            this.StockControlViewActiveInquiriesButton.Name = "StockControlViewActiveInquiriesButton";
            this.StockControlViewActiveInquiriesButton.Size = new System.Drawing.Size(293, 34);
            this.StockControlViewActiveInquiriesButton.Text = "View Active inquiries";
            this.StockControlViewActiveInquiriesButton.Click += new System.EventHandler(this.StockControlViewActiveInquiriesButton_Click);
            // 
            // StockControlViewSeniorInquiriesButton
            // 
            this.StockControlViewSeniorInquiriesButton.Name = "StockControlViewSeniorInquiriesButton";
            this.StockControlViewSeniorInquiriesButton.Size = new System.Drawing.Size(293, 34);
            this.StockControlViewSeniorInquiriesButton.Text = "View Senior Inquiries";
            this.StockControlViewSeniorInquiriesButton.Click += new System.EventHandler(this.StockControlViewSeniorInquiriesButton_Click);
            // 
            // StockControlViewFinishedInquiriesButton
            // 
            this.StockControlViewFinishedInquiriesButton.Name = "StockControlViewFinishedInquiriesButton";
            this.StockControlViewFinishedInquiriesButton.Size = new System.Drawing.Size(293, 34);
            this.StockControlViewFinishedInquiriesButton.Text = "View Finished Inquiries";
            this.StockControlViewFinishedInquiriesButton.Click += new System.EventHandler(this.ViewFinishedInquiriesButton_Click);
            // 
            // SearchInquiryButton
            // 
            this.SearchInquiryButton.Name = "SearchInquiryButton";
            this.SearchInquiryButton.Size = new System.Drawing.Size(293, 34);
            this.SearchInquiryButton.Text = "Search Inquiry";
            this.SearchInquiryButton.Click += new System.EventHandler(this.SearchInquiryButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // AnalyzingDropDownButton
            // 
            this.AnalyzingDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AnalyzingDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MistakesMadeByButton,
            this.MistakesByTypeButton,
            this.TimeTrackingButton,
            this.DashBoardButton});
            this.AnalyzingDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("AnalyzingDropDownButton.Image")));
            this.AnalyzingDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnalyzingDropDownButton.Name = "AnalyzingDropDownButton";
            this.AnalyzingDropDownButton.Size = new System.Drawing.Size(107, 29);
            this.AnalyzingDropDownButton.Text = "Analyzing";
            // 
            // MistakesMadeByButton
            // 
            this.MistakesMadeByButton.Name = "MistakesMadeByButton";
            this.MistakesMadeByButton.Size = new System.Drawing.Size(270, 34);
            this.MistakesMadeByButton.Text = "Mistakes Made By";
            this.MistakesMadeByButton.Click += new System.EventHandler(this.MistakesMadeByButton_Click);
            // 
            // MistakesByTypeButton
            // 
            this.MistakesByTypeButton.Name = "MistakesByTypeButton";
            this.MistakesByTypeButton.Size = new System.Drawing.Size(270, 34);
            this.MistakesByTypeButton.Text = "Mistakes By Type";
            this.MistakesByTypeButton.Click += new System.EventHandler(this.MistakesByTypeButton_Click);
            // 
            // TimeTrackingButton
            // 
            this.TimeTrackingButton.Name = "TimeTrackingButton";
            this.TimeTrackingButton.Size = new System.Drawing.Size(270, 34);
            this.TimeTrackingButton.Text = "Time Tracking";
            this.TimeTrackingButton.Click += new System.EventHandler(this.TimeTrackingButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // SettingsDropDownButton
            // 
            this.SettingsDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersButton,
            this.DataBaseButton});
            this.SettingsDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsDropDownButton.Image")));
            this.SettingsDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsDropDownButton.Name = "SettingsDropDownButton";
            this.SettingsDropDownButton.Size = new System.Drawing.Size(94, 29);
            this.SettingsDropDownButton.Text = "Settings";
            // 
            // UsersButton
            // 
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(187, 34);
            this.UsersButton.Text = "Users";
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // DataBaseButton
            // 
            this.DataBaseButton.Name = "DataBaseButton";
            this.DataBaseButton.Size = new System.Drawing.Size(187, 34);
            this.DataBaseButton.Text = "DataBase";
            this.DataBaseButton.Click += new System.EventHandler(this.DataBaseButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(74, 29);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainWindowChart
            // 
            this.MainWindowChart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.MainWindowChart.ChartAreas.Add(chartArea1);
            this.MainWindowChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.MainWindowChart.Legends.Add(legend1);
            this.MainWindowChart.Location = new System.Drawing.Point(0, 34);
            this.MainWindowChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainWindowChart.Name = "MainWindowChart";
            this.MainWindowChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Yellow;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Inquiries";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Green;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Found";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.DarkRed;
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Not Found";
            this.MainWindowChart.Series.Add(series1);
            this.MainWindowChart.Series.Add(series2);
            this.MainWindowChart.Series.Add(series3);
            this.MainWindowChart.Size = new System.Drawing.Size(1476, 644);
            this.MainWindowChart.TabIndex = 2;
            this.MainWindowChart.Text = "chart1";
            this.MainWindowChart.Click += new System.EventHandler(this.MainWindowChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1257, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Inquiries :";
            // 
            // TotalInquiriesResultLabel
            // 
            this.TotalInquiriesResultLabel.AutoSize = true;
            this.TotalInquiriesResultLabel.BackColor = System.Drawing.Color.White;
            this.TotalInquiriesResultLabel.Location = new System.Drawing.Point(1383, 254);
            this.TotalInquiriesResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalInquiriesResultLabel.Name = "TotalInquiriesResultLabel";
            this.TotalInquiriesResultLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalInquiriesResultLabel.TabIndex = 4;
            this.TotalInquiriesResultLabel.Text = "0";
            // 
            // TotalFoundResultLabel
            // 
            this.TotalFoundResultLabel.AutoSize = true;
            this.TotalFoundResultLabel.BackColor = System.Drawing.Color.White;
            this.TotalFoundResultLabel.Location = new System.Drawing.Point(1383, 288);
            this.TotalFoundResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalFoundResultLabel.Name = "TotalFoundResultLabel";
            this.TotalFoundResultLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalFoundResultLabel.TabIndex = 6;
            this.TotalFoundResultLabel.Text = "0";
            // 
            // TotalFoundLabel
            // 
            this.TotalFoundLabel.AutoSize = true;
            this.TotalFoundLabel.BackColor = System.Drawing.Color.White;
            this.TotalFoundLabel.Location = new System.Drawing.Point(1269, 288);
            this.TotalFoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalFoundLabel.Name = "TotalFoundLabel";
            this.TotalFoundLabel.Size = new System.Drawing.Size(102, 20);
            this.TotalFoundLabel.TabIndex = 5;
            this.TotalFoundLabel.Text = "Total Found :";
            // 
            // TotalNotFoundResultLabel
            // 
            this.TotalNotFoundResultLabel.AutoSize = true;
            this.TotalNotFoundResultLabel.BackColor = System.Drawing.Color.White;
            this.TotalNotFoundResultLabel.Location = new System.Drawing.Point(1383, 324);
            this.TotalNotFoundResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalNotFoundResultLabel.Name = "TotalNotFoundResultLabel";
            this.TotalNotFoundResultLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalNotFoundResultLabel.TabIndex = 8;
            this.TotalNotFoundResultLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1239, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Not Found :";
            // 
            // TotalFoundProcentLabel
            // 
            this.TotalFoundProcentLabel.AutoSize = true;
            this.TotalFoundProcentLabel.BackColor = System.Drawing.Color.White;
            this.TotalFoundProcentLabel.Location = new System.Drawing.Point(1422, 288);
            this.TotalFoundProcentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalFoundProcentLabel.Name = "TotalFoundProcentLabel";
            this.TotalFoundProcentLabel.Size = new System.Drawing.Size(32, 20);
            this.TotalFoundProcentLabel.TabIndex = 9;
            this.TotalFoundProcentLabel.Text = "0%";
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Location = new System.Drawing.Point(1199, 9);
            this.GreetingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(65, 20);
            this.GreetingsLabel.TabIndex = 10;
            this.GreetingsLabel.Text = "Hello ....";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "NL",
            "EN",
            "DE"});
            this.LanguageComboBox.Location = new System.Drawing.Point(1388, 6);
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(66, 28);
            this.LanguageComboBox.TabIndex = 135;
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Size = new System.Drawing.Size(270, 34);
            this.DashBoardButton.Text = "DashBoard";
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 678);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.GreetingsLabel);
            this.Controls.Add(this.TotalFoundProcentLabel);
            this.Controls.Add(this.TotalNotFoundResultLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalFoundResultLabel);
            this.Controls.Add(this.TotalFoundLabel);
            this.Controls.Add(this.TotalInquiriesResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainWindowChart);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Manager Pro";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton InboundDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem InboundAddNewInquiryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton StockControlDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem StockControlViewActiveInquiriesButton;
        private System.Windows.Forms.ToolStripMenuItem ViewReadyInquiriesButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainWindowChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton AnalyzingDropDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem StockControlViewSeniorInquiriesButton;
        private System.Windows.Forms.ToolStripMenuItem MistakesMadeByButton;
        private System.Windows.Forms.ToolStripMenuItem MistakesByTypeButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripDropDownButton SettingsDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem UsersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalInquiriesResultLabel;
        private System.Windows.Forms.Label TotalFoundResultLabel;
        private System.Windows.Forms.Label TotalFoundLabel;
        private System.Windows.Forms.Label TotalNotFoundResultLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem ViewFinishedInquiriesButton;
        private System.Windows.Forms.ToolStripMenuItem DataBaseButton;
        private System.Windows.Forms.Label TotalFoundProcentLabel;
        private System.Windows.Forms.ToolStripMenuItem TimeTrackingButton;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.ToolStripMenuItem SearchInquiryButton;
        private System.Windows.Forms.ToolStripMenuItem InboundSearchInquiryButton;
        private System.Windows.Forms.ToolStripMenuItem StockControlViewFinishedInquiriesButton;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.ToolStripMenuItem DashBoardButton;
    }
}