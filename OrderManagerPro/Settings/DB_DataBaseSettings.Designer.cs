namespace OrderManagerPro
{
    partial class DB_DataBaseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_DataBaseSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentFileLocationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetNewLocationTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImportDataButton = new System.Windows.Forms.Button();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.InsertHeaderButton = new System.Windows.Forms.Button();
            this.WorkerNameComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ImportedDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertDataIntoDataBaseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current File Location :";
            // 
            // CurrentFileLocationLabel
            // 
            this.CurrentFileLocationLabel.AutoSize = true;
            this.CurrentFileLocationLabel.Location = new System.Drawing.Point(192, 14);
            this.CurrentFileLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentFileLocationLabel.Name = "CurrentFileLocationLabel";
            this.CurrentFileLocationLabel.Size = new System.Drawing.Size(41, 20);
            this.CurrentFileLocationLabel.TabIndex = 1;
            this.CurrentFileLocationLabel.Text = "How";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set New Location :";
            // 
            // SetNewLocationTextBox
            // 
            this.SetNewLocationTextBox.Location = new System.Drawing.Point(180, 75);
            this.SetNewLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetNewLocationTextBox.Name = "SetNewLocationTextBox";
            this.SetNewLocationTextBox.Size = new System.Drawing.Size(1000, 26);
            this.SetNewLocationTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1070, 115);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Example :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "\"C:\\DataBase\\DatabaseOrderManagerPro.mdf\"";
            // 
            // ImportDataButton
            // 
            this.ImportDataButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportDataButton.BackgroundImage")));
            this.ImportDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportDataButton.Location = new System.Drawing.Point(26, 201);
            this.ImportDataButton.Name = "ImportDataButton";
            this.ImportDataButton.Size = new System.Drawing.Size(215, 222);
            this.ImportDataButton.TabIndex = 18;
            this.ImportDataButton.UseVisualStyleBackColor = true;
            this.ImportDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnalyzeButton.BackgroundImage")));
            this.AnalyzeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnalyzeButton.Location = new System.Drawing.Point(1511, 201);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(215, 222);
            this.AnalyzeButton.TabIndex = 30;
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            // 
            // InsertHeaderButton
            // 
            this.InsertHeaderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertHeaderButton.Location = new System.Drawing.Point(26, 165);
            this.InsertHeaderButton.Name = "InsertHeaderButton";
            this.InsertHeaderButton.Size = new System.Drawing.Size(215, 30);
            this.InsertHeaderButton.TabIndex = 31;
            this.InsertHeaderButton.Text = "Insert Header";
            this.InsertHeaderButton.UseVisualStyleBackColor = true;
            this.InsertHeaderButton.Click += new System.EventHandler(this.InsertHeaderButton_Click);
            // 
            // WorkerNameComboBox
            // 
            this.WorkerNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerNameComboBox.FormattingEnabled = true;
            this.WorkerNameComboBox.Items.AddRange(new object[] {
            "No Filter"});
            this.WorkerNameComboBox.Location = new System.Drawing.Point(2811, 81);
            this.WorkerNameComboBox.Name = "WorkerNameComboBox";
            this.WorkerNameComboBox.Size = new System.Drawing.Size(137, 33);
            this.WorkerNameComboBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2806, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Worker :";
            // 
            // ImportedDataGridView
            // 
            this.ImportedDataGridView.AllowUserToOrderColumns = true;
            this.ImportedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportedDataGridView.Location = new System.Drawing.Point(26, 447);
            this.ImportedDataGridView.Name = "ImportedDataGridView";
            this.ImportedDataGridView.RowHeadersWidth = 62;
            this.ImportedDataGridView.Size = new System.Drawing.Size(3054, 1131);
            this.ImportedDataGridView.TabIndex = 34;
            // 
            // InsertDataIntoDataBaseButton
            // 
            this.InsertDataIntoDataBaseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertDataIntoDataBaseButton.BackgroundImage")));
            this.InsertDataIntoDataBaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InsertDataIntoDataBaseButton.Location = new System.Drawing.Point(2865, 201);
            this.InsertDataIntoDataBaseButton.Name = "InsertDataIntoDataBaseButton";
            this.InsertDataIntoDataBaseButton.Size = new System.Drawing.Size(215, 222);
            this.InsertDataIntoDataBaseButton.TabIndex = 35;
            this.InsertDataIntoDataBaseButton.UseVisualStyleBackColor = true;
            this.InsertDataIntoDataBaseButton.Click += new System.EventHandler(this.InsertDataIntoDataBaseButton_Click);
            // 
            // DB_DataBaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3107, 1590);
            this.Controls.Add(this.InsertDataIntoDataBaseButton);
            this.Controls.Add(this.ImportedDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WorkerNameComboBox);
            this.Controls.Add(this.InsertHeaderButton);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.ImportDataButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SetNewLocationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentFileLocationLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_DataBaseSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_DataBaseSettings";
            this.Load += new System.EventHandler(this.DB_DataBaseSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentFileLocationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetNewLocationTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ImportDataButton;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Button InsertHeaderButton;
        private System.Windows.Forms.ComboBox WorkerNameComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ImportedDataGridView;
        private System.Windows.Forms.Button InsertDataIntoDataBaseButton;
    }
}