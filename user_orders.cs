using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodi
{
    public partial class user_orders : Form
    {
        string username;
        string path = @"E:\foodi\orders\";
        //=========================================================================================
        public user_orders(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        //=========================================================================================
        private void user_orders_Load(object sender, EventArgs e)
        {
            blabel_orders.Text = "username : " + this.username;

            string path = @"E:\foodi\orders\" + this.username + ".order";

            orders_list.ColumnCount = 6;
            orders_list.Columns[0].Name = "food_number";
            orders_list.Columns[1].Name = "food_name";
            orders_list.Columns[2].Name = "food_count";
            orders_list.Columns[3].Name = "food_price";
            orders_list.Columns[4].Name = "total";
            orders_list.Columns[5].Name = "time";

            orders_list.Columns[0].HeaderText = "number of food";
            orders_list.Columns[1].HeaderText = "name of food";
            orders_list.Columns[2].HeaderText = "count of food";
            orders_list.Columns[3].HeaderText = "price of food";
            orders_list.Columns[4].HeaderText = "total price";
            orders_list.Columns[5].HeaderText = "time of order";

            orders_list.AutoGenerateColumns = false;

            int counter = 1;
            int total_prcie = 0;
            string order_time = "";

            if(!File.Exists(path))
            {
                MessageBox.Show(
                    "you have not ordered any food yet.\ngo and order some!"/*\nwould you like to order some?"*/, 
                    "no foods", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
                return;
            }


            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // the : shows that there is time in this line
                    if (line.Contains(":"))
                    {
                        order_time = line;
                        continue;
                    }

                    try
                    {
                        string[] data = line.Split(',');
                        string fn = data[0], fc = data[1], fp = data[2], ft = data[3];
                        //name count price total
                        total_prcie += Int32.Parse(ft);
                        orders_list.Rows.Add(counter++, fn, fc, fp, ft, order_time);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            label_food_count.Text = $"number of your orders : {(counter - 1).ToString()}";
            label_sum_price.Text = $"total price : {total_prcie.ToString()}";
        }

        private void label_food_count_Click(object sender, EventArgs e)
        {

        }
        //=========================================================================================
    }
}
