namespace Foodi
{
    partial class user_orders
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
            this.orders_list = new System.Windows.Forms.DataGridView();
            this.blabel_orders = new System.Windows.Forms.Label();
            this.label_food_count = new System.Windows.Forms.Label();
            this.label_sum_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orders_list)).BeginInit();
            this.SuspendLayout();
            // 
            // orders_list
            // 
            this.orders_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_list.Location = new System.Drawing.Point(13, 191);
            this.orders_list.Name = "orders_list";
            this.orders_list.ReadOnly = true;
            this.orders_list.RowHeadersWidth = 51;
            this.orders_list.RowTemplate.Height = 24;
            this.orders_list.Size = new System.Drawing.Size(847, 470);
            this.orders_list.TabIndex = 0;
            // 
            // blabel_orders
            // 
            this.blabel_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel_orders.Location = new System.Drawing.Point(24, 27);
            this.blabel_orders.Name = "blabel_orders";
            this.blabel_orders.Size = new System.Drawing.Size(336, 54);
            this.blabel_orders.TabIndex = 1;
            this.blabel_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_food_count
            // 
            this.label_food_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_food_count.Location = new System.Drawing.Point(434, 27);
            this.label_food_count.Name = "label_food_count";
            this.label_food_count.Size = new System.Drawing.Size(426, 54);
            this.label_food_count.TabIndex = 2;
            this.label_food_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_food_count.Click += new System.EventHandler(this.label_food_count_Click);
            // 
            // label_sum_price
            // 
            this.label_sum_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sum_price.Location = new System.Drawing.Point(434, 86);
            this.label_sum_price.Name = "label_sum_price";
            this.label_sum_price.Size = new System.Drawing.Size(426, 54);
            this.label_sum_price.TabIndex = 2;
            this.label_sum_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 673);
            this.Controls.Add(this.label_sum_price);
            this.Controls.Add(this.label_food_count);
            this.Controls.Add(this.blabel_orders);
            this.Controls.Add(this.orders_list);
            this.Name = "user_orders";
            this.Text = "user_orders";
            this.Load += new System.EventHandler(this.user_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orders_list;
        private System.Windows.Forms.Label blabel_orders;
        private System.Windows.Forms.Label label_food_count;
        private System.Windows.Forms.Label label_sum_price;
    }
}