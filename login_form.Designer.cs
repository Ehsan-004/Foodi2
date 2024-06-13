namespace Foodi
{
    partial class login_form
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
            this.components = new System.ComponentModel.Container();
            this.button_login = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.username_check = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_check = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.username_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_check)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(364, 381);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(138, 62);
            this.button_login.TabIndex = 11;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(480, 115);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(196, 45);
            this.tb_username.TabIndex = 9;
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_username_Validating);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(480, 213);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(196, 45);
            this.tb_password.TabIndex = 10;
            this.tb_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_Validating);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(204, 216);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(163, 39);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(204, 121);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(102, 39);
            this.label_username.TabIndex = 14;
            this.label_username.Text = "name";
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(364, 498);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(138, 62);
            this.button_reg.TabIndex = 15;
            this.button_reg.Text = "new account";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_check
            // 
            this.username_check.ContainerControl = this;
            // 
            // password_check
            // 
            this.password_check.ContainerControl = this;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 673);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Name = "login_form";
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.username_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.ErrorProvider username_check;
        private System.Windows.Forms.ErrorProvider password_check;
    }
}