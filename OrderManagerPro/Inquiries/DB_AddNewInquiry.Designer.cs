
namespace OrderManagerPro
{
    partial class DB_AddNewInquiry
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ProblemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.ProblemAmountTextBox = new System.Windows.Forms.TextBox();
            this.ProblemAmountLabel = new System.Windows.Forms.Label();
            this.ProblemTypeLabel = new System.Windows.Forms.Label();
            this.OrderAmountTextBox = new System.Windows.Forms.TextBox();
            this.OrderAmountLabel = new System.Windows.Forms.Label();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.SupplierTextBox = new System.Windows.Forms.TextBox();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.ProductNumberTextBox = new System.Windows.Forms.TextBox();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.DeliveryNumberTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.NameCreatorTextBox = new System.Windows.Forms.TextBox();
            this.CheckInquiryButton = new System.Windows.Forms.Button();
            this.NameCreatorLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.ProblemStateComboBox = new System.Windows.Forms.ComboBox();
            this.ProblemStateLabel = new System.Windows.Forms.Label();
            this.InquiryOrderComboBox = new System.Windows.Forms.ComboBox();
            this.InquiryOrderLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(634, 457);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 35);
            this.AddButton.TabIndex = 64;
            this.AddButton.Text = "Toevoegen";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProblemTypeComboBox
            // 
            this.ProblemTypeComboBox.FormattingEnabled = true;
            this.ProblemTypeComboBox.Items.AddRange(new object[] {
            "Missend",
            "Teveel"});
            this.ProblemTypeComboBox.Location = new System.Drawing.Point(393, 34);
            this.ProblemTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProblemTypeComboBox.Name = "ProblemTypeComboBox";
            this.ProblemTypeComboBox.Size = new System.Drawing.Size(180, 28);
            this.ProblemTypeComboBox.TabIndex = 63;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(14, 205);
            this.CommentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(732, 222);
            this.CommentTextBox.TabIndex = 62;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(357, 180);
            this.CommentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(86, 20);
            this.CommentLabel.TabIndex = 61;
            this.CommentLabel.Text = "Opmerking";
            // 
            // ProblemAmountTextBox
            // 
            this.ProblemAmountTextBox.Location = new System.Drawing.Point(393, 92);
            this.ProblemAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProblemAmountTextBox.Name = "ProblemAmountTextBox";
            this.ProblemAmountTextBox.Size = new System.Drawing.Size(112, 26);
            this.ProblemAmountTextBox.TabIndex = 56;
            this.ProblemAmountTextBox.TextChanged += new System.EventHandler(this.ProblemAmountTextBox_TextChanged);
            // 
            // ProblemAmountLabel
            // 
            this.ProblemAmountLabel.AutoSize = true;
            this.ProblemAmountLabel.Location = new System.Drawing.Point(388, 66);
            this.ProblemAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProblemAmountLabel.Name = "ProblemAmountLabel";
            this.ProblemAmountLabel.Size = new System.Drawing.Size(126, 20);
            this.ProblemAmountLabel.TabIndex = 55;
            this.ProblemAmountLabel.Text = "Probleem Aantal";
            // 
            // ProblemTypeLabel
            // 
            this.ProblemTypeLabel.AutoSize = true;
            this.ProblemTypeLabel.Location = new System.Drawing.Point(388, 8);
            this.ProblemTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProblemTypeLabel.Name = "ProblemTypeLabel";
            this.ProblemTypeLabel.Size = new System.Drawing.Size(119, 20);
            this.ProblemTypeLabel.TabIndex = 54;
            this.ProblemTypeLabel.Text = "Probleem Soort";
            // 
            // OrderAmountTextBox
            // 
            this.OrderAmountTextBox.Location = new System.Drawing.Point(198, 92);
            this.OrderAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderAmountTextBox.Name = "OrderAmountTextBox";
            this.OrderAmountTextBox.Size = new System.Drawing.Size(148, 26);
            this.OrderAmountTextBox.TabIndex = 53;
            this.OrderAmountTextBox.TextChanged += new System.EventHandler(this.OrderAmountTextBox_TextChanged);
            // 
            // OrderAmountLabel
            // 
            this.OrderAmountLabel.AutoSize = true;
            this.OrderAmountLabel.Location = new System.Drawing.Point(194, 66);
            this.OrderAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderAmountLabel.Name = "OrderAmountLabel";
            this.OrderAmountLabel.Size = new System.Drawing.Size(98, 20);
            this.OrderAmountLabel.TabIndex = 52;
            this.OrderAmountLabel.Text = "Bestelaantal";
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(198, 152);
            this.ProductPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(148, 26);
            this.ProductPriceTextBox.TabIndex = 51;
            this.ProductPriceTextBox.TextChanged += new System.EventHandler(this.ProductPriceTextBox_TextChanged);
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(194, 126);
            this.ProductPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(38, 20);
            this.ProductPriceLabel.TabIndex = 50;
            this.ProductPriceLabel.Text = "Prijs";
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.Location = new System.Drawing.Point(14, 34);
            this.SupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.Size = new System.Drawing.Size(148, 26);
            this.SupplierTextBox.TabIndex = 49;
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(9, 8);
            this.SupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(91, 20);
            this.SupplierLabel.TabIndex = 48;
            this.SupplierLabel.Text = "Leverancier";
            // 
            // ProductNumberTextBox
            // 
            this.ProductNumberTextBox.Location = new System.Drawing.Point(198, 34);
            this.ProductNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductNumberTextBox.Name = "ProductNumberTextBox";
            this.ProductNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.ProductNumberTextBox.TabIndex = 47;
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Location = new System.Drawing.Point(194, 8);
            this.ProductNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(122, 20);
            this.ProductNumberLabel.TabIndex = 46;
            this.ProductNumberLabel.Text = "Produktnummer";
            // 
            // DeliveryNumberTextBox
            // 
            this.DeliveryNumberTextBox.Location = new System.Drawing.Point(14, 152);
            this.DeliveryNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliveryNumberTextBox.Name = "DeliveryNumberTextBox";
            this.DeliveryNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.DeliveryNumberTextBox.TabIndex = 45;
            // 
            // DeliveryNumberLabel
            // 
            this.DeliveryNumberLabel.AutoSize = true;
            this.DeliveryNumberLabel.Location = new System.Drawing.Point(9, 126);
            this.DeliveryNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeliveryNumberLabel.Name = "DeliveryNumberLabel";
            this.DeliveryNumberLabel.Size = new System.Drawing.Size(135, 20);
            this.DeliveryNumberLabel.TabIndex = 44;
            this.DeliveryNumberLabel.Text = "Leveringsnummer";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(14, 92);
            this.OrderNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.OrderNumberTextBox.TabIndex = 43;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(9, 66);
            this.OrderNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(112, 20);
            this.OrderNumberLabel.TabIndex = 42;
            this.OrderNumberLabel.Text = "Bestelnummer";
            // 
            // NameCreatorTextBox
            // 
            this.NameCreatorTextBox.Location = new System.Drawing.Point(588, 152);
            this.NameCreatorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameCreatorTextBox.Name = "NameCreatorTextBox";
            this.NameCreatorTextBox.Size = new System.Drawing.Size(157, 26);
            this.NameCreatorTextBox.TabIndex = 41;
            // 
            // CheckInquiryButton
            // 
            this.CheckInquiryButton.BackColor = System.Drawing.Color.LightGreen;
            this.CheckInquiryButton.Location = new System.Drawing.Point(14, 457);
            this.CheckInquiryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckInquiryButton.Name = "CheckInquiryButton";
            this.CheckInquiryButton.Size = new System.Drawing.Size(112, 35);
            this.CheckInquiryButton.TabIndex = 65;
            this.CheckInquiryButton.Text = "Controleer";
            this.CheckInquiryButton.UseVisualStyleBackColor = false;
            this.CheckInquiryButton.Click += new System.EventHandler(this.CheckInquiryButton_Click);
            // 
            // NameCreatorLabel
            // 
            this.NameCreatorLabel.AutoSize = true;
            this.NameCreatorLabel.Location = new System.Drawing.Point(584, 126);
            this.NameCreatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameCreatorLabel.Name = "NameCreatorLabel";
            this.NameCreatorLabel.Size = new System.Drawing.Size(51, 20);
            this.NameCreatorLabel.TabIndex = 40;
            this.NameCreatorLabel.Text = "Naam";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "NL",
            "EN",
            "DE"});
            this.LanguageComboBox.Location = new System.Drawing.Point(680, 3);
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(66, 28);
            this.LanguageComboBox.TabIndex = 66;
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // ProblemStateComboBox
            // 
            this.ProblemStateComboBox.FormattingEnabled = true;
            this.ProblemStateComboBox.Items.AddRange(new object[] {
            "",
            "Active",
            "Ready"});
            this.ProblemStateComboBox.Location = new System.Drawing.Point(428, 460);
            this.ProblemStateComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProblemStateComboBox.Name = "ProblemStateComboBox";
            this.ProblemStateComboBox.Size = new System.Drawing.Size(180, 28);
            this.ProblemStateComboBox.TabIndex = 67;
            this.ProblemStateComboBox.SelectedIndexChanged += new System.EventHandler(this.ProblemStateComboBox_SelectedIndexChanged);
            // 
            // ProblemStateLabel
            // 
            this.ProblemStateLabel.AutoSize = true;
            this.ProblemStateLabel.Location = new System.Drawing.Point(423, 437);
            this.ProblemStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProblemStateLabel.Name = "ProblemStateLabel";
            this.ProblemStateLabel.Size = new System.Drawing.Size(127, 20);
            this.ProblemStateLabel.TabIndex = 68;
            this.ProblemStateLabel.Text = "Probleem Status";
            // 
            // InquiryOrderComboBox
            // 
            this.InquiryOrderComboBox.FormattingEnabled = true;
            this.InquiryOrderComboBox.Items.AddRange(new object[] {
            "",
            "Count",
            "Do Not Count"});
            this.InquiryOrderComboBox.Location = new System.Drawing.Point(237, 460);
            this.InquiryOrderComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InquiryOrderComboBox.Name = "InquiryOrderComboBox";
            this.InquiryOrderComboBox.Size = new System.Drawing.Size(180, 28);
            this.InquiryOrderComboBox.TabIndex = 69;
            this.InquiryOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.InquiryOrderComboBox_SelectedIndexChanged);
            // 
            // InquiryOrderLabel
            // 
            this.InquiryOrderLabel.AutoSize = true;
            this.InquiryOrderLabel.Location = new System.Drawing.Point(237, 432);
            this.InquiryOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InquiryOrderLabel.Name = "InquiryOrderLabel";
            this.InquiryOrderLabel.Size = new System.Drawing.Size(147, 20);
            this.InquiryOrderLabel.TabIndex = 70;
            this.InquiryOrderLabel.Text = "Aanvraag Opdracht";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.LightGreen;
            this.EditButton.Location = new System.Drawing.Point(14, 460);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 35);
            this.EditButton.TabIndex = 71;
            this.EditButton.Text = "Bewerk";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DB_AddNewInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.InquiryOrderLabel);
            this.Controls.Add(this.InquiryOrderComboBox);
            this.Controls.Add(this.ProblemStateLabel);
            this.Controls.Add(this.ProblemStateComboBox);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.CheckInquiryButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProblemTypeComboBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.ProblemAmountTextBox);
            this.Controls.Add(this.ProblemAmountLabel);
            this.Controls.Add(this.ProblemTypeLabel);
            this.Controls.Add(this.OrderAmountTextBox);
            this.Controls.Add(this.OrderAmountLabel);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.SupplierTextBox);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ProductNumberTextBox);
            this.Controls.Add(this.ProductNumberLabel);
            this.Controls.Add(this.DeliveryNumberTextBox);
            this.Controls.Add(this.DeliveryNumberLabel);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.NameCreatorTextBox);
            this.Controls.Add(this.NameCreatorLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_AddNewInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Aanvraag Toevoegen";
            this.Load += new System.EventHandler(this.DB_AddNewInquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ProblemTypeComboBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox ProblemAmountTextBox;
        private System.Windows.Forms.Label ProblemAmountLabel;
        private System.Windows.Forms.Label ProblemTypeLabel;
        private System.Windows.Forms.TextBox OrderAmountTextBox;
        private System.Windows.Forms.Label OrderAmountLabel;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox SupplierTextBox;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.TextBox ProductNumberTextBox;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.TextBox DeliveryNumberTextBox;
        private System.Windows.Forms.Label DeliveryNumberLabel;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.TextBox NameCreatorTextBox;
        private System.Windows.Forms.Button CheckInquiryButton;
        private System.Windows.Forms.Label NameCreatorLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.ComboBox ProblemStateComboBox;
        private System.Windows.Forms.Label ProblemStateLabel;
        private System.Windows.Forms.ComboBox InquiryOrderComboBox;
        private System.Windows.Forms.Label InquiryOrderLabel;
        private System.Windows.Forms.Button EditButton;
    }
}