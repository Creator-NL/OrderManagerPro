namespace OrderManagerPro
{
    partial class DB_EditUser
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
            this.EditUserDataGridView = new System.Windows.Forms.DataGridView();
            this.EditUserButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EditUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUserDataGridView
            // 
            this.EditUserDataGridView.AllowUserToAddRows = false;
            this.EditUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditUserButton});
            this.EditUserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditUserDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EditUserDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditUserDataGridView.Name = "EditUserDataGridView";
            this.EditUserDataGridView.RowHeadersWidth = 62;
            this.EditUserDataGridView.Size = new System.Drawing.Size(1089, 692);
            this.EditUserDataGridView.TabIndex = 0;
            // 
            // EditUserButton
            // 
            this.EditUserButton.HeaderText = "EditButton";
            this.EditUserButton.MinimumWidth = 8;
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Width = 150;
            // 
            // DB_EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 692);
            this.Controls.Add(this.EditUserDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DB_EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_EditUser";
            this.Load += new System.EventHandler(this.DB_EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditUserDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn EditUserButton;
    }
}