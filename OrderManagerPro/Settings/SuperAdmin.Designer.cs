namespace OrderManagerPro
{
    partial class SuperAdmin
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
            this.SA_SetDataBaseButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SA_SetDataBaseButton
            // 
            this.SA_SetDataBaseButton.Location = new System.Drawing.Point(26, 34);
            this.SA_SetDataBaseButton.Name = "SA_SetDataBaseButton";
            this.SA_SetDataBaseButton.Size = new System.Drawing.Size(96, 23);
            this.SA_SetDataBaseButton.TabIndex = 0;
            this.SA_SetDataBaseButton.Text = "Database";
            this.SA_SetDataBaseButton.UseVisualStyleBackColor = true;
            this.SA_SetDataBaseButton.Click += new System.EventHandler(this.SA_SetDataBaseButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(26, 79);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(75, 23);
            this.UsersButton.TabIndex = 1;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.SA_SetDataBaseButton);
            this.Name = "SuperAdmin";
            this.Text = "SuperAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SA_SetDataBaseButton;
        private System.Windows.Forms.Button UsersButton;
    }
}