namespace Foodi
{
    partial class form_shortcutkeys
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
            this.button_foods = new System.Windows.Forms.CheckBox();
            this.button_orders = new System.Windows.Forms.CheckBox();
            this.button_setting = new System.Windows.Forms.CheckBox();
            this.button_profile = new System.Windows.Forms.CheckBox();
            this.button_exit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_foods
            // 
            this.button_foods.AutoSize = true;
            this.button_foods.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_foods.Location = new System.Drawing.Point(80, 20);
            this.button_foods.Name = "button_foods";
            this.button_foods.Size = new System.Drawing.Size(105, 33);
            this.button_foods.TabIndex = 0;
            this.button_foods.Text = "Foods";
            this.button_foods.UseVisualStyleBackColor = true;
            // 
            // button_orders
            // 
            this.button_orders.AutoSize = true;
            this.button_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_orders.Location = new System.Drawing.Point(80, 63);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(111, 33);
            this.button_orders.TabIndex = 1;
            this.button_orders.Text = "Orders";
            this.button_orders.UseVisualStyleBackColor = true;
            // 
            // button_setting
            // 
            this.button_setting.AutoSize = true;
            this.button_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_setting.Location = new System.Drawing.Point(80, 106);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(114, 33);
            this.button_setting.TabIndex = 2;
            this.button_setting.Text = "Setting";
            this.button_setting.UseVisualStyleBackColor = true;
            // 
            // button_profile
            // 
            this.button_profile.AutoSize = true;
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.Location = new System.Drawing.Point(80, 149);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(181, 33);
            this.button_profile.TabIndex = 3;
            this.button_profile.Text = "Login/Logout";
            this.button_profile.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(80, 192);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(77, 33);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 87);
            this.label1.TabIndex = 5;
            this.label1.Text = "the shortcuts work with pressing Alt+first word of each part.\r\nfor example Alt+F " +
    "goes to food part.";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(293, 125);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(98, 57);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(420, 125);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(98, 57);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // form_shortcutkeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 253);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_foods);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_shortcutkeys";
            this.Text = "form_shortcutkeys";
            this.Load += new System.EventHandler(this.form_shortcutkeys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox button_foods;
        private System.Windows.Forms.CheckBox button_orders;
        private System.Windows.Forms.CheckBox button_setting;
        private System.Windows.Forms.CheckBox button_profile;
        private System.Windows.Forms.CheckBox button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}