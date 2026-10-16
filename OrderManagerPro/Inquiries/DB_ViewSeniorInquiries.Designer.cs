namespace OrderManagerPro
{
    partial class DB_ViewSeniorInquiries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_ViewSeniorInquiries));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ImportedDataGridView = new System.Windows.Forms.DataGridView();
            this.InquiryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.RefreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1347, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(66, 22);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ImportedDataGridView
            // 
            this.ImportedDataGridView.AllowUserToAddRows = false;
            this.ImportedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InquiryColumn});
            this.ImportedDataGridView.Location = new System.Drawing.Point(0, 28);
            this.ImportedDataGridView.Name = "ImportedDataGridView";
            this.ImportedDataGridView.Size = new System.Drawing.Size(1347, 423);
            this.ImportedDataGridView.TabIndex = 3;
            this.ImportedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImportedDataGridView_CellContentClick);
            // 
            // InquiryColumn
            // 
            this.InquiryColumn.HeaderText = "Inquiry";
            this.InquiryColumn.Name = "InquiryColumn";
            // 
            // DB_ViewSeniorInquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 452);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ImportedDataGridView);
            this.Name = "DB_ViewSeniorInquiries";
            this.Text = "DB_ViewSeniorInquiries";
            this.Load += new System.EventHandler(this.DB_ViewSeniorInquiries_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.DataGridView ImportedDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn InquiryColumn;
    }
}