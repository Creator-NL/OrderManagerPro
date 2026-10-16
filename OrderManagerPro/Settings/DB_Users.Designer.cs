namespace OrderManagerPro
{
    partial class DB_Users
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
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Location = new System.Drawing.Point(12, 12);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(100, 23);
            this.AddNewUserButton.TabIndex = 0;
            this.AddNewUserButton.Text = "Add new User";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(12, 42);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(100, 23);
            this.EditUserButton.TabIndex = 1;
            this.EditUserButton.Text = "Edit User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // DB_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 109);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.AddNewUserButton);
            this.Name = "DB_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB_Users";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.Button EditUserButton;
    }
}