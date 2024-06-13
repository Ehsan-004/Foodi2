namespace Foodi
{
    partial class administrator
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
            this.admin_menu = new System.Windows.Forms.MenuStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_menu
            // 
            this.admin_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.admin_menu.Location = new System.Drawing.Point(0, 0);
            this.admin_menu.Name = "admin_menu";
            this.admin_menu.Size = new System.Drawing.Size(982, 24);
            this.admin_menu.TabIndex = 1;
            this.admin_menu.Text = "menuStrip1";
            this.admin_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.admin_menu_ItemClicked);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(600, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(382, 529);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(709, 252);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(164, 77);
            this.button_add.TabIndex = 4;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delet
            // 
            this.button_delet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delet.Location = new System.Drawing.Point(709, 391);
            this.button_delet.Name = "button_delet";
            this.button_delet.Size = new System.Drawing.Size(164, 77);
            this.button_delet.TabIndex = 5;
            this.button_delet.UseVisualStyleBackColor = true;
            this.button_delet.Click += new System.EventHandler(this.button_delet_Click);
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button_delet);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.admin_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.admin_menu;
            this.Name = "administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.administrator_FormClosing);
            this.Load += new System.EventHandler(this.administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip admin_menu;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delet;
    }
}