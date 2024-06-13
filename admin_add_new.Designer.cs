namespace Foodi
{
    partial class admin_add_new
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
            this.label_nama = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(95, 58);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(0, 26);
            this.label_nama.TabIndex = 0;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.Location = new System.Drawing.Point(95, 135);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(0, 26);
            this.label_value.TabIndex = 1;
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_value.Location = new System.Drawing.Point(340, 135);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(181, 32);
            this.tb_value.TabIndex = 2;
            this.tb_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(340, 58);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(181, 32);
            this.tb_name.TabIndex = 3;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(188, 203);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(310, 203);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // admin_add_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 253);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label_nama);
            this.Name = "admin_add_new";
            this.ShowIcon = false;
            this.Text = "admin_add_new";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}