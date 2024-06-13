using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    public partial class admin_report : Form
    {
        MySqlConnection myc = Form1.myConnection;

        public admin_report()
        {
            InitializeComponent();
        }

        private void admin_report_Load(object sender, EventArgs e)
        {
            MySqlCommand mysq = new MySqlCommand();
            mysq.Connection = myc;
            mysq.CommandText = "SELECT COUNT(username) FROM users";
            myc.Open();


            int count = 0;
            using(var re = mysq.ExecuteReader())
            {
                while(re.Read())
                {
                    count = re.GetInt32(0);
                }

            }

            user_count.Text = "total users : " + count.ToString();

            mysq.CommandText = "SELECT COUNT(name) FROM foods";

            myc.Close();
            myc.Open();


            using (var re = mysq.ExecuteReader())
            {
                while (re.Read())
                {
                    count = re.GetInt32(0);
                }

            }

            food_count.Text = "total foods : " + count.ToString();



            myc.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name.Text == String.Empty)
                return;

            string path = Form1.order_path + user_name.Text + ".order";

            try
            {
                user_orders uo = new user_orders(user_name.Text);
                uo.Show();
            }
            catch
            {
                MessageBox.Show(
                    "username not found!",
                    "no username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                user_name.Focus();
            }
        }
    }
}
