namespace OrderManagerPro
{
    partial class DB_SearchInquiries
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchResultGridView = new System.Windows.Forms.DataGridView();
            this.InquiryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductNumberTextBox = new System.Windows.Forms.TextBox();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.DeliveryNumberTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryNumberLabel = new System.Windows.Forms.Label();
            this.ProblemAmountTextBox = new System.Windows.Forms.TextBox();
            this.ProblemAmountLabel = new System.Windows.Forms.Label();
            this.ProblemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProblemTypeLabel = new System.Windows.Forms.Label();
            this.RowsFoundLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightGreen;
            this.SearchButton.Location = new System.Drawing.Point(1008, 25);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 35);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchResultGridView
            // 
            this.SearchResultGridView.AllowUserToAddRows = false;
            this.SearchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InquiryColumn});
            this.SearchResultGridView.Location = new System.Drawing.Point(0, 94);
            this.SearchResultGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchResultGridView.Name = "SearchResultGridView";
            this.SearchResultGridView.RowHeadersWidth = 62;
            this.SearchResultGridView.Size = new System.Drawing.Size(2068, 378);
            this.SearchResultGridView.TabIndex = 1;
            this.SearchResultGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultGridView_CellContentClick);
            // 
            // InquiryColumn
            // 
            this.InquiryColumn.HeaderText = "Inquiry";
            this.InquiryColumn.MinimumWidth = 8;
            this.InquiryColumn.Name = "InquiryColumn";
            this.InquiryColumn.Width = 150;
            // 
            // ProductNumberTextBox
            // 
            this.ProductNumberTextBox.Location = new System.Drawing.Point(336, 29);
            this.ProductNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductNumberTextBox.Name = "ProductNumberTextBox";
            this.ProductNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.ProductNumberTextBox.TabIndex = 49;
            this.ProductNumberTextBox.TextChanged += new System.EventHandler(this.SearchFields_TextChanged);
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Location = new System.Drawing.Point(336, 5);
            this.ProductNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(122, 20);
            this.ProductNumberLabel.TabIndex = 48;
            this.ProductNumberLabel.Text = "Produktnummer";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(18, 29);
            this.OrderNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.OrderNumberTextBox.TabIndex = 51;
            this.OrderNumberTextBox.TextChanged += new System.EventHandler(this.SearchFields_TextChanged);
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(14, 3);
            this.OrderNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(112, 20);
            this.OrderNumberLabel.TabIndex = 50;
            this.OrderNumberLabel.Text = "Bestelnummer";
            // 
            // DeliveryNumberTextBox
            // 
            this.DeliveryNumberTextBox.Location = new System.Drawing.Point(177, 29);
            this.DeliveryNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliveryNumberTextBox.Name = "DeliveryNumberTextBox";
            this.DeliveryNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.DeliveryNumberTextBox.TabIndex = 53;
            this.DeliveryNumberTextBox.TextChanged += new System.EventHandler(this.SearchFields_TextChanged);
            // 
            // DeliveryNumberLabel
            // 
            this.DeliveryNumberLabel.AutoSize = true;
            this.DeliveryNumberLabel.Location = new System.Drawing.Point(172, 3);
            this.DeliveryNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeliveryNumberLabel.Name = "DeliveryNumberLabel";
            this.DeliveryNumberLabel.Size = new System.Drawing.Size(135, 20);
            this.DeliveryNumberLabel.TabIndex = 52;
            this.DeliveryNumberLabel.Text = "Leveringsnummer";
            // 
            // ProblemAmountTextBox
            // 
            this.ProblemAmountTextBox.Location = new System.Drawing.Point(687, 29);
            this.ProblemAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProblemAmountTextBox.Name = "ProblemAmountTextBox";
            this.ProblemAmountTextBox.Size = new System.Drawing.Size(112, 26);
            this.ProblemAmountTextBox.TabIndex = 58;
            this.ProblemAmountTextBox.TextChanged += new System.EventHandler(this.SearchFields_TextChanged);
            // 
            // ProblemAmountLabel
            // 
            this.ProblemAmountLabel.AutoSize = true;
            this.ProblemAmountLabel.Location = new System.Drawing.Point(682, 3);
            this.ProblemAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProblemAmountLabel.Name = "ProblemAmountLabel";
            this.ProblemAmountLabel.Size = new System.Drawing.Size(126, 20);
            this.ProblemAmountLabel.TabIndex = 57;
            this.ProblemAmountLabel.Text = "Probleem Aantal";
            // 
            // ProblemTypeComboBox
            // 
            this.ProblemTypeComboBox.FormattingEnabled = true;
            this.ProblemTypeComboBox.Items.AddRange(new object[] {
            "Missend",
            "Teveel"});
            this.ProblemTypeComboBox.Location = new System.Drawing.Point(496, 28);
            this.ProblemTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProblemTypeComboBox.Name = "ProblemTypeComboBox";
            this.ProblemTypeComboBox.Size = new System.Drawing.Size(180, 28);
            this.ProblemTypeComboBox.TabIndex = 65;
            this.ProblemTypeComboBox.TextChanged += new System.EventHandler(this.SearchFields_TextChanged);
            // 
            // ProblemTypeLabel
            // 
            this.ProblemTypeLabel.AutoSize = true;
            this.ProblemTypeLabel.Location = new System.Drawing.Point(492, 2);
            this.ProblemTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProblemTypeLabel.Name = "ProblemTypeLabel";
            this.ProblemTypeLabel.Size = new System.Drawing.Size(119, 20);
            this.ProblemTypeLabel.TabIndex = 64;
            this.ProblemTypeLabel.Text = "Probleem Soort";
            // 
            // RowsFoundLabel
            // 
            this.RowsFoundLabel.AutoSize = true;
            this.RowsFoundLabel.Location = new System.Drawing.Point(1257, 32);
            this.RowsFoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RowsFoundLabel.Name = "RowsFoundLabel";
            this.RowsFoundLabel.Size = new System.Drawing.Size(107, 20);
            this.RowsFoundLabel.TabIndex = 66;
            this.RowsFoundLabel.Text = "Rows Found :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1377, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "0";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(854, 25);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(112, 26);
            this.IDTextBox.TabIndex = 69;
            this.IDTextBox.TextChanged += new System.EventHandler(this.SearchFields_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "ID";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "NL",
            "EN",
            "DE"});
            this.LanguageComboBox.Location = new System.Drawing.Point(1979, 5);
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(66, 28);
            this.LanguageComboBox.TabIndex = 134;
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // DB_SearchInquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2070, 475);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RowsFoundLabel);
            this.Controls.Add(this.ProblemTypeComboBox);
            this.Controls.Add(this.ProblemTypeLabel);
            this.Controls.Add(this.ProblemAmountTextBox);
            this.Controls.Add(this.ProblemAmountLabel);
            this.Controls.Add(this.DeliveryNumberTextBox);
            this.Controls.Add(this.DeliveryNumberLabel);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.ProductNumberTextBox);
            this.Controls.Add(this.ProductNumberLabel);
            this.Controls.Add(this.SearchResultGridView);
            this.Controls.Add(this.SearchButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_SearchInquiries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_SearchInquiries";
            this.Load += new System.EventHandler(this.DB_SearchInquiries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView SearchResultGridView;
        private System.Windows.Forms.DataGridViewButtonColumn InquiryColumn;
        private System.Windows.Forms.TextBox ProductNumberTextBox;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.TextBox DeliveryNumberTextBox;
        private System.Windows.Forms.Label DeliveryNumberLabel;
        private System.Windows.Forms.TextBox ProblemAmountTextBox;
        private System.Windows.Forms.Label ProblemAmountLabel;
        private System.Windows.Forms.ComboBox ProblemTypeComboBox;
        private System.Windows.Forms.Label ProblemTypeLabel;
        private System.Windows.Forms.Label RowsFoundLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LanguageComboBox;
    }
}