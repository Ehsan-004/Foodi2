namespace Foodi
{
    partial class admin_report
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
            this.user_count = new System.Windows.Forms.Label();
            this.food_count = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_count
            // 
            this.user_count.AutoSize = true;
            this.user_count.Location = new System.Drawing.Point(32, 71);
            this.user_count.Name = "user_count";
            this.user_count.Size = new System.Drawing.Size(0, 16);
            this.user_count.TabIndex = 4;
            this.user_count.Click += new System.EventHandler(this.label2_Click);
            // 
            // food_count
            // 
            this.food_count.AutoSize = true;
            this.food_count.Location = new System.Drawing.Point(32, 122);
            this.food_count.Name = "food_count";
            this.food_count.Size = new System.Drawing.Size(0, 16);
            this.food_count.TabIndex = 5;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(79, 272);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(100, 22);
            this.user_name.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "enter name of user ";
            // 
            // admin_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.food_count);
            this.Controls.Add(this.user_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_report";
            this.Text = "admin_report";
            this.Load += new System.EventHandler(this.admin_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_count;
        private System.Windows.Forms.Label food_count;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}