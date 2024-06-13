namespace Foodi
{
    partial class admin_foods
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
            this.foods_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.foods_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // foods_grid
            // 
            this.foods_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foods_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foods_grid.Location = new System.Drawing.Point(0, 0);
            this.foods_grid.Name = "foods_grid";
            this.foods_grid.RowHeadersWidth = 51;
            this.foods_grid.RowTemplate.Height = 24;
            this.foods_grid.Size = new System.Drawing.Size(421, 446);
            this.foods_grid.TabIndex = 0;
            this.foods_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foods_grid_CellContentClick);
            // 
            // admin_foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 446);
            this.Controls.Add(this.foods_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_foods";
            this.Text = "admin_foods";
            this.Load += new System.EventHandler(this.admin_foods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foods_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView foods_grid;
    }
}