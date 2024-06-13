namespace Foodi
{
    partial class admin_users
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
            this.users_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.users_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // users_grid
            // 
            this.users_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_grid.Location = new System.Drawing.Point(0, 0);
            this.users_grid.Name = "users_grid";
            this.users_grid.RowHeadersWidth = 51;
            this.users_grid.RowTemplate.Height = 24;
            this.users_grid.Size = new System.Drawing.Size(403, 399);
            this.users_grid.TabIndex = 0;
            this.users_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_grid_CellContentClick);
            // 
            // admin_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 399);
            this.Controls.Add(this.users_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_users";
            this.Text = "admin_users";
            this.Load += new System.EventHandler(this.admin_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView users_grid;
    }
}