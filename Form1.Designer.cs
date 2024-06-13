namespace Foodi
{
    partial class Form1
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_foods = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.top_menu = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(306, 649);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // button_setting
            // 
            this.button_setting.Location = new System.Drawing.Point(70, 548);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(158, 56);
            this.button_setting.TabIndex = 10;
            this.button_setting.Text = "Setting";
            this.button_setting.UseVisualStyleBackColor = true;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(70, 424);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(158, 56);
            this.button_profile.TabIndex = 9;
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_orders
            // 
            this.button_orders.Location = new System.Drawing.Point(69, 300);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(158, 56);
            this.button_orders.TabIndex = 8;
            this.button_orders.Text = "Orrders";
            this.button_orders.UseVisualStyleBackColor = true;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // button_foods
            // 
            this.button_foods.Location = new System.Drawing.Point(69, 176);
            this.button_foods.Name = "button_foods";
            this.button_foods.Size = new System.Drawing.Size(158, 56);
            this.button_foods.TabIndex = 7;
            this.button_foods.Text = "Foods";
            this.button_foods.UseVisualStyleBackColor = true;
            this.button_foods.Click += new System.EventHandler(this.button_foods_Click);
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(69, 45);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(159, 101);
            this.label_username.TabIndex = 12;
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top_menu
            // 
            this.top_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.top_menu.Location = new System.Drawing.Point(0, 0);
            this.top_menu.Name = "top_menu";
            this.top_menu.Size = new System.Drawing.Size(1182, 24);
            this.top_menu.TabIndex = 14;
            this.top_menu.Text = "menuStrip1";
            this.top_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.top_menu_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_foods);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.top_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.top_menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Foodi : your restaurant at home!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_orders;
        public System.Windows.Forms.Button button_foods;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.MenuStrip top_menu;
    }
}

