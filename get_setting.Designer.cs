namespace Foodi
{
    partial class get_setting
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
            this.order_login = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.order_food = new System.Windows.Forms.TextBox();
            this.label_foods = new System.Windows.Forms.Label();
            this.order_order = new System.Windows.Forms.TextBox();
            this.label_orders = new System.Windows.Forms.Label();
            this.order_setting = new System.Windows.Forms.TextBox();
            this.label_setting = new System.Windows.Forms.Label();
            this.order_exit = new System.Windows.Forms.TextBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order_login
            // 
            this.order_login.Location = new System.Drawing.Point(58, 27);
            this.order_login.Name = "order_login";
            this.order_login.Size = new System.Drawing.Size(22, 22);
            this.order_login.TabIndex = 0;
            this.order_login.Text = "0";
            // 
            // label_login
            // 
            this.label_login.Location = new System.Drawing.Point(86, 26);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(100, 23);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "login or logout";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_food
            // 
            this.order_food.Location = new System.Drawing.Point(58, 68);
            this.order_food.Name = "order_food";
            this.order_food.Size = new System.Drawing.Size(22, 22);
            this.order_food.TabIndex = 0;
            this.order_food.Text = "0";
            // 
            // label_foods
            // 
            this.label_foods.Location = new System.Drawing.Point(86, 67);
            this.label_foods.Name = "label_foods";
            this.label_foods.Size = new System.Drawing.Size(100, 23);
            this.label_foods.TabIndex = 1;
            this.label_foods.Text = "foods";
            this.label_foods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_order
            // 
            this.order_order.Location = new System.Drawing.Point(58, 109);
            this.order_order.Name = "order_order";
            this.order_order.Size = new System.Drawing.Size(22, 22);
            this.order_order.TabIndex = 0;
            this.order_order.Text = "0";
            // 
            // label_orders
            // 
            this.label_orders.Location = new System.Drawing.Point(86, 108);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(100, 23);
            this.label_orders.TabIndex = 1;
            this.label_orders.Text = "orders";
            this.label_orders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_setting
            // 
            this.order_setting.Location = new System.Drawing.Point(58, 150);
            this.order_setting.Name = "order_setting";
            this.order_setting.Size = new System.Drawing.Size(22, 22);
            this.order_setting.TabIndex = 0;
            this.order_setting.Tag = "0";
            this.order_setting.Text = "0";
            // 
            // label_setting
            // 
            this.label_setting.Location = new System.Drawing.Point(86, 149);
            this.label_setting.Name = "label_setting";
            this.label_setting.Size = new System.Drawing.Size(100, 23);
            this.label_setting.TabIndex = 1;
            this.label_setting.Text = "setting";
            this.label_setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_exit
            // 
            this.order_exit.Location = new System.Drawing.Point(58, 190);
            this.order_exit.Name = "order_exit";
            this.order_exit.Size = new System.Drawing.Size(22, 22);
            this.order_exit.TabIndex = 0;
            this.order_exit.Text = "0";
            // 
            // label_exit
            // 
            this.label_exit.Location = new System.Drawing.Point(86, 190);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(100, 23);
            this.label_exit.TabIndex = 1;
            this.label_exit.Text = "exit the app";
            this.label_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(305, 24);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(186, 66);
            this.OK.TabIndex = 2;
            this.OK.Text = "ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(305, 127);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(186, 66);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // get_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 253);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.order_exit);
            this.Controls.Add(this.label_setting);
            this.Controls.Add(this.order_setting);
            this.Controls.Add(this.label_orders);
            this.Controls.Add(this.order_order);
            this.Controls.Add(this.label_foods);
            this.Controls.Add(this.order_food);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.order_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "get_setting";
            this.Text = "get_setting";
            this.Load += new System.EventHandler(this.get_setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox order_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox order_food;
        private System.Windows.Forms.Label label_foods;
        private System.Windows.Forms.TextBox order_order;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.TextBox order_setting;
        private System.Windows.Forms.Label label_setting;
        private System.Windows.Forms.TextBox order_exit;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}