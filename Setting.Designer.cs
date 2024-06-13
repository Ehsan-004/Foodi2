namespace Foodi
{
    partial class Setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shortcut_panel = new System.Windows.Forms.GroupBox();
            this.current_shortcuts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shorts_button = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.GroupBox();
            this.current_menu = new System.Windows.Forms.Button();
            this.label_exp = new System.Windows.Forms.Label();
            this.button_setting_set = new System.Windows.Forms.Button();
            this.bkgr_panel = new System.Windows.Forms.GroupBox();
            this.button_bgcolor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.shortcut_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.bkgr_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.shortcut_panel);
            this.panel1.Controls.Add(this.menu_panel);
            this.panel1.Controls.Add(this.bkgr_panel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 832);
            this.panel1.TabIndex = 0;
            // 
            // shortcut_panel
            // 
            this.shortcut_panel.Controls.Add(this.current_shortcuts);
            this.shortcut_panel.Controls.Add(this.label1);
            this.shortcut_panel.Controls.Add(this.shorts_button);
            this.shortcut_panel.Location = new System.Drawing.Point(0, 430);
            this.shortcut_panel.Name = "shortcut_panel";
            this.shortcut_panel.Size = new System.Drawing.Size(870, 209);
            this.shortcut_panel.TabIndex = 2;
            this.shortcut_panel.TabStop = false;
            this.shortcut_panel.Text = "set shortcut keys";
            // 
            // current_shortcuts
            // 
            this.current_shortcuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_shortcuts.Location = new System.Drawing.Point(339, 56);
            this.current_shortcuts.Name = "current_shortcuts";
            this.current_shortcuts.Size = new System.Drawing.Size(132, 113);
            this.current_shortcuts.TabIndex = 2;
            this.current_shortcuts.Text = "see current shortcuts";
            this.current_shortcuts.UseVisualStyleBackColor = true;
            this.current_shortcuts.Click += new System.EventHandler(this.current_shortcuts_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 113);
            this.label1.TabIndex = 1;
            this.label1.Text = "active or deactive shorcut keys for different parts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shorts_button
            // 
            this.shorts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shorts_button.Location = new System.Drawing.Point(48, 56);
            this.shorts_button.Name = "shorts_button";
            this.shorts_button.Size = new System.Drawing.Size(254, 113);
            this.shorts_button.TabIndex = 0;
            this.shorts_button.Text = "set the shortcuts";
            this.shorts_button.UseVisualStyleBackColor = true;
            this.shorts_button.Click += new System.EventHandler(this.shorts_button_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.current_menu);
            this.menu_panel.Controls.Add(this.label_exp);
            this.menu_panel.Controls.Add(this.button_setting_set);
            this.menu_panel.Location = new System.Drawing.Point(0, 215);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(870, 209);
            this.menu_panel.TabIndex = 0;
            this.menu_panel.TabStop = false;
            this.menu_panel.Text = "menu setting";
            // 
            // current_menu
            // 
            this.current_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_menu.Location = new System.Drawing.Point(339, 55);
            this.current_menu.Name = "current_menu";
            this.current_menu.Size = new System.Drawing.Size(132, 113);
            this.current_menu.TabIndex = 2;
            this.current_menu.Text = "see current setting";
            this.current_menu.UseVisualStyleBackColor = true;
            this.current_menu.Click += new System.EventHandler(this.current_menu_Click);
            // 
            // label_exp
            // 
            this.label_exp.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exp.Location = new System.Drawing.Point(487, 55);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(349, 113);
            this.label_exp.TabIndex = 1;
            this.label_exp.Text = "if you want to set up your pesonalized menu click the button.";
            this.label_exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_setting_set
            // 
            this.button_setting_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_setting_set.Location = new System.Drawing.Point(48, 55);
            this.button_setting_set.Name = "button_setting_set";
            this.button_setting_set.Size = new System.Drawing.Size(254, 113);
            this.button_setting_set.TabIndex = 0;
            this.button_setting_set.Text = "set the setting ";
            this.button_setting_set.UseVisualStyleBackColor = true;
            this.button_setting_set.Click += new System.EventHandler(this.button_setting_set_Click);
            // 
            // bkgr_panel
            // 
            this.bkgr_panel.Controls.Add(this.button_bgcolor);
            this.bkgr_panel.Location = new System.Drawing.Point(0, 0);
            this.bkgr_panel.Name = "bkgr_panel";
            this.bkgr_panel.Size = new System.Drawing.Size(870, 209);
            this.bkgr_panel.TabIndex = 0;
            this.bkgr_panel.TabStop = false;
            this.bkgr_panel.Text = "them and background";
            // 
            // button_bgcolor
            // 
            this.button_bgcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bgcolor.Location = new System.Drawing.Point(48, 50);
            this.button_bgcolor.Name = "button_bgcolor";
            this.button_bgcolor.Size = new System.Drawing.Size(254, 113);
            this.button_bgcolor.TabIndex = 1;
            this.button_bgcolor.Text = "change background color";
            this.button_bgcolor.UseVisualStyleBackColor = true;
            this.button_bgcolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 673);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            this.shortcut_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.bkgr_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox bkgr_panel;
        private System.Windows.Forms.GroupBox menu_panel;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.Button button_setting_set;
        private System.Windows.Forms.GroupBox shortcut_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shorts_button;
        private System.Windows.Forms.Button current_shortcuts;
        private System.Windows.Forms.Button current_menu;
        private System.Windows.Forms.Button button_bgcolor;
    }
}