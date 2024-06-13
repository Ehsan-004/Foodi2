namespace Foodi
{
    partial class register_user
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
            this.tb_new_username = new System.Windows.Forms.TextBox();
            this.tb_new_password = new System.Windows.Forms.TextBox();
            this.label_reg_password = new System.Windows.Forms.Label();
            this.label_reg_username = new System.Windows.Forms.Label();
            this.have_account_buttun = new System.Windows.Forms.Button();
            this.tb_password_again = new System.Windows.Forms.TextBox();
            this.label_password_again = new System.Windows.Forms.Label();
            this.username_checker = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_checker = new System.Windows.Forms.ErrorProvider(this.components);
            this.again_checker = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.username_checker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_checker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.again_checker)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(371, 408);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(138, 62);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "register";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // tb_new_username
            // 
            this.tb_new_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_new_username.Location = new System.Drawing.Point(524, 111);
            this.tb_new_username.Name = "tb_new_username";
            this.tb_new_username.Size = new System.Drawing.Size(196, 45);
            this.tb_new_username.TabIndex = 0;
            this.tb_new_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_new_username_Validating);
            // 
            // tb_new_password
            // 
            this.tb_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_new_password.Location = new System.Drawing.Point(524, 209);
            this.tb_new_password.Name = "tb_new_password";
            this.tb_new_password.Size = new System.Drawing.Size(196, 45);
            this.tb_new_password.TabIndex = 1;
            this.tb_new_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_new_password_Validating);
            // 
            // label_reg_password
            // 
            this.label_reg_password.AutoSize = true;
            this.label_reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reg_password.Location = new System.Drawing.Point(164, 209);
            this.label_reg_password.Name = "label_reg_password";
            this.label_reg_password.Size = new System.Drawing.Size(163, 39);
            this.label_reg_password.TabIndex = 0;
            this.label_reg_password.Text = "password";
            // 
            // label_reg_username
            // 
            this.label_reg_username.AutoSize = true;
            this.label_reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reg_username.Location = new System.Drawing.Point(164, 114);
            this.label_reg_username.Name = "label_reg_username";
            this.label_reg_username.Size = new System.Drawing.Size(102, 39);
            this.label_reg_username.TabIndex = 0;
            this.label_reg_username.Text = "name";
            // 
            // have_account_buttun
            // 
            this.have_account_buttun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.have_account_buttun.Location = new System.Drawing.Point(323, 513);
            this.have_account_buttun.Name = "have_account_buttun";
            this.have_account_buttun.Size = new System.Drawing.Size(234, 62);
            this.have_account_buttun.TabIndex = 4;
            this.have_account_buttun.Text = "I have account";
            this.have_account_buttun.UseVisualStyleBackColor = true;
            this.have_account_buttun.Click += new System.EventHandler(this.have_account_buttun_Click);
            // 
            // tb_password_again
            // 
            this.tb_password_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password_again.Location = new System.Drawing.Point(524, 306);
            this.tb_password_again.Name = "tb_password_again";
            this.tb_password_again.Size = new System.Drawing.Size(196, 45);
            this.tb_password_again.TabIndex = 2;
            this.tb_password_again.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_again_Validating);
            // 
            // label_password_again
            // 
            this.label_password_again.AutoSize = true;
            this.label_password_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password_again.Location = new System.Drawing.Point(164, 306);
            this.label_password_again.Name = "label_password_again";
            this.label_password_again.Size = new System.Drawing.Size(282, 39);
            this.label_password_again.TabIndex = 0;
            this.label_password_again.Text = "Repeat password";
            // 
            // username_checker
            // 
            this.username_checker.ContainerControl = this;
            // 
            // password_checker
            // 
            this.password_checker.ContainerControl = this;
            // 
            // again_checker
            // 
            this.again_checker.ContainerControl = this;
            // 
            // register_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 673);
            this.Controls.Add(this.label_password_again);
            this.Controls.Add(this.tb_password_again);
            this.Controls.Add(this.have_account_buttun);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.tb_new_username);
            this.Controls.Add(this.tb_new_password);
            this.Controls.Add(this.label_reg_password);
            this.Controls.Add(this.label_reg_username);
            this.Name = "register_user";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.username_checker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_checker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.again_checker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox tb_new_username;
        private System.Windows.Forms.TextBox tb_new_password;
        private System.Windows.Forms.Label label_reg_password;
        private System.Windows.Forms.Label label_reg_username;
        private System.Windows.Forms.Button have_account_buttun;
        private System.Windows.Forms.TextBox tb_password_again;
        private System.Windows.Forms.Label label_password_again;
        private System.Windows.Forms.ErrorProvider username_checker;
        private System.Windows.Forms.ErrorProvider password_checker;
        private System.Windows.Forms.ErrorProvider again_checker;
    }
}