
namespace OrderManagerPro
{
    partial class DB_ViewActiveInquiries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_ViewActiveInquiries));
            this.ImportedDataGridView = new System.Windows.Forms.DataGridView();
            this.InquiryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportedDataGridView
            // 
            this.ImportedDataGridView.AllowUserToAddRows = false;
            this.ImportedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InquiryColumn});
            this.ImportedDataGridView.Location = new System.Drawing.Point(0, 43);
            this.ImportedDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImportedDataGridView.Name = "ImportedDataGridView";
            this.ImportedDataGridView.RowHeadersWidth = 62;
            this.ImportedDataGridView.Size = new System.Drawing.Size(1522, 465);
            this.ImportedDataGridView.TabIndex = 0;
            this.ImportedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImportedDataGridView_CellClick);
            this.ImportedDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImportedDataGridView_CellDoubleClick);
            this.ImportedDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ImportedDataGridView_RowPostPaint);
            // 
            // InquiryColumn
            // 
            this.InquiryColumn.HeaderText = "Inquiry";
            this.InquiryColumn.MinimumWidth = 8;
            this.InquiryColumn.Name = "InquiryColumn";
            this.InquiryColumn.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.RefreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1522, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(98, 29);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DB_ViewActiveInquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 508);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ImportedDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_ViewActiveInquiries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Actieve Inquiries";
            this.Load += new System.EventHandler(this.DB_ViewActiveInquiries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ImportedDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn InquiryColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
    }
}