namespace OrderManagerPro
{
    partial class DB_ViewReadyInquiries
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
            this.ImportedDataGridView = new System.Windows.Forms.DataGridView();
            this.InquiryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportedDataGridView
            // 
            this.ImportedDataGridView.AllowUserToAddRows = false;
            this.ImportedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InquiryColumn});
            this.ImportedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ImportedDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImportedDataGridView.Name = "ImportedDataGridView";
            this.ImportedDataGridView.RowHeadersWidth = 62;
            this.ImportedDataGridView.Size = new System.Drawing.Size(1233, 692);
            this.ImportedDataGridView.TabIndex = 1;
            this.ImportedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImportedDataGridView_CellClick);
            this.ImportedDataGridView.Sorted += new System.EventHandler(this.ImportedDataGridView_Sorted);
            // 
            // InquiryColumn
            // 
            this.InquiryColumn.HeaderText = "Inquiry";
            this.InquiryColumn.MinimumWidth = 8;
            this.InquiryColumn.Name = "InquiryColumn";
            this.InquiryColumn.Width = 150;
            // 
            // DB_ViewReadyInquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 692);
            this.Controls.Add(this.ImportedDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_ViewReadyInquiries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_ViewReadyInquiries";
            this.Load += new System.EventHandler(this.DB_ViewReadyInquiries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ImportedDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn InquiryColumn;
    }
}