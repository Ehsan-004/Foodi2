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
    public partial class admin_add_new : Form
    {
        MySqlConnection myc = Form1.myConnection;

        string kind;
        public admin_add_new(string kind, string lb_name, string lb_value)
        {
            InitializeComponent();
            this.kind = kind;
            label_nama.Text = lb_name;
            label_value.Text = lb_value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (this.kind == "foods")
            {
                MySqlCommand mysq = new MySqlCommand();
                mysq.Connection = myc;
                mysq.CommandText = "INSERT INTO foods(name, price) VALUES (\"" + tb_name.Text + "\"," + tb_value.Text + ")";
                myc.Open();
                mysq.ExecuteNonQuery();
                myc.Close();
            }
            else if(this.kind == "users")
            {
                MySqlCommand mysq = new MySqlCommand();
                mysq.Connection = myc;
                mysq.CommandText = "INSERT INTO users(username, password) VALUES (\"" + tb_name.Text + "\",\"" + tb_value.Text + "\")";
                myc.Open();
                mysq.ExecuteNonQuery();
                myc.Close();
            }
            

            this.DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
