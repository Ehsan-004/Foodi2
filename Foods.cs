using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodi
{
    public partial class Foods : Form
    {
        Label[] names = new Label[10];
        Label[] prices = new Label[10];
        NumericUpDown[] counts = new NumericUpDown[10];
        bool logged_in = false;
        string orders = "";
        string username;



        MySqlConnection myc = Form1.myConnection;
        //=========================================================================================
        public Foods(bool lgn, string username = "")
        {
            InitializeComponent();
            this.logged_in = lgn;
            this.username = username;
        }
        //=========================================================================================
        private void Foods_Load(object sender, EventArgs e)
        {
            int counter = 0;
            Label[] n = { fn_1, fn_2, fn_3, fn_4, fn_5, fn_6, fn_7, fn_8, fn_9, fn_10 };
            for (int i = 0; i < 10; i++)
                this.names[i] = n[i];
            Label[] p = { pr_1, pr_2, pr_3, pr_4, pr_5, pr_6, pr_7, pr_8, pr_9, pr_10 };
            for (int i = 0; i < 10; i++)
                this.prices[i] = p[i];

            NumericUpDown[] c = {
                count_1, count_2, count_3, count_4, count_5,
                count_6, count_7, count_8, count_9, count_10
            };
            for (int i = 0; i < 10; i++)
                this.counts[i] = c[i];

            myc.Open();
            MySqlCommand mycm = new MySqlCommand();
            mycm.Connection = myc;
            mycm.CommandText = $"SELECT * FROM foods";

            using (var Reader = mycm.ExecuteReader())
            {
                while (Reader.Read())
                {
                    this.names[counter].Text = Reader.GetString("name");
                    this.prices[counter].Text = Reader.GetInt32("price").ToString();
                    counter++;
                }
            }
            myc.Close();

        }
        //=========================================================================================
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //=========================================================================================
        private void button_food_order_Click(object sender, EventArgs e)
        {
            foreach (var cc in this.counts)
            {
                if (cc.Value != 0)
                {
                    int Ind = Array.IndexOf(this.counts, cc);
                    Int32 price_food;
                    if (this.prices[Ind].Text != "")
                        price_food = Int32.Parse(this.prices[Ind].Text);
                    else
                        continue;
                    Int32 count_food = Decimal.ToInt32(cc.Value);
                    Int32 total_price = price_food * count_food;
                    String string_total = total_price.ToString();
                    this.orders += 
                        this.names[Ind].Text + "," + 
                        this.counts[Ind].Value + ","+ 
                        this.prices[Ind].Text + "," +
                        string_total + "\n";
                }
            }
            //we have all ordered foods in thie.orders as a string.
            string path = @"E:\foodi\orders\";
            if (this.logged_in)
            {
                DialogResult save_orders = MessageBox.Show(
                    "Are you sure save your orders?",
                    "ordering",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (save_orders == DialogResult.OK)
                {
                    MessageBox.Show("these are your orders : \n" + orders, "your orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string order_to_save = "";
                    order_to_save += 
                        //((Form1)this.MdiParent).username +
                        DateTime.Now.ToString("h:mm:ss") +
                        "\n" + this.orders;

                    //string path_ = ((Form1)this.MdiParent).orders_path + this.username + ".order";
                    string path_ = path + this.username + ".order";

                    using (StreamWriter sw = File.AppendText(path_))
                    {
                        sw.WriteLine(order_to_save);
                    }
                    MessageBox.Show("your orders saved", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.orders = "";
                    order_to_save = "";
                    this.Close();//===================
                }
            }
            else
            {
                MessageBox.Show("login first!", "login need", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //=========================================================================================
    }
}
