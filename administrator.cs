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
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace Foodi
{
    public partial class administrator : Form
    {
        Form1 f1 = new Form1();
        public admin_foods af;
        public admin_users au;
        public admin_report ar;
        string admin_name;
        string[] admin_access;
        string current_active;
        string to_delet = "";
        string[] to_delet_arr;
        string data = "";
        string[] data_arr;

        public static string myConnectionString = "server=127.0.0.1;uid=root;database=foodi2";
        public static MySqlConnection myConnection = new MySqlConnection(myConnectionString);


        public administrator(string admin_name, string[] admin_access)
        {
            InitializeComponent();
            this.admin_name = admin_name;
            this.admin_access = admin_access;
        }

        private void administrator_Load(object sender, EventArgs e)
        {
            foreach (var a in admin_access)
                admin_menu.Items.Add(a);
        }

        private void admin_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "foods")
            {   
                this.current_active = "foods";
                button_add.Text = "add new food";
                button_delet.Text = "delet chosen food(s)";

                af = new admin_foods
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                af.Show();
            }
            else if (e.ClickedItem.Text == "users")
            {
                this.current_active = "users";
                button_add.Text = "add new user";
                button_delet.Text = "delet chosen users";

                au = new admin_users
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                au.Show();
            }
            else if (e.ClickedItem.Text == "report")
            {
                this.current_active = "reports";
                button_add.Enabled = false;
                button_delet.Enabled = false;

                ar = new admin_report
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };
                ar.Show();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (this.current_active == "foods")
            {
                admin_add_new ani = new admin_add_new("foods", "new food name:", "new food price:");
                DialogResult ani_d = ani.ShowDialog();

                if (ani_d == DialogResult.OK)
                {
                    MessageBox.Show("new food added");
                }
                return;
            }
            else if (this.current_active == "users")
            {
                admin_add_new ani = new admin_add_new("users", "new username:", "new user password:");
                DialogResult ani_d = ani.ShowDialog();

                if (ani_d == DialogResult.OK)
                {
                    MessageBox.Show("new user added");
                }
                return;
            }
        }

        private void button_delet_Click(object sender, EventArgs e)
        {
            if (this.current_active == "foods")
            {
                //=====================================================================================================================
                string path = Form1.order_path;

                if (MessageBox.Show("are you sure you want to delet some foods?",
                    "delet error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;

                if (af.foods_grid.SelectedRows == null)
                    return;

                MySqlCommand mysq = new MySqlCommand();
                mysq.Connection = myConnection;

                myConnection.Open();

                foreach (DataGridViewRow row in af.foods_grid.SelectedRows)
                {
                    string deleted_food = row.Cells[1].Value.ToString();
                    mysq.CommandText = "DELETE FROM foods WHERE name = \"" + deleted_food+ "\"";

                    mysq.ExecuteNonQuery();
                }

                myConnection.Close();

                MessageBox.Show("task completed!", "delet finish",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.current_active == "users")
            {
                //=====================================================================================================================
                string path = Form1.order_path;

                if (MessageBox.Show("are you sure you want to delet some users?",
                    "delet error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;

                if (au.users_grid.SelectedRows == null)
                    return;


                MySqlCommand mysq = new MySqlCommand();
                mysq.Connection = myConnection;

                myConnection.Open();

                foreach (DataGridViewRow row in au.users_grid.SelectedRows)
                {
                    string deleted_username = row.Cells[1].Value.ToString();
                    mysq.CommandText = "DELETE FROM users WHERE username = \"" + deleted_username + "\"";

                    mysq.ExecuteNonQuery();

                    if (File.Exists(path + deleted_username + ".order"))
                    {
                        try
                        {
                            File.Delete(path + deleted_username + ".order");
                        }
                        catch
                        {
                            //there is no order
                        }
                    }

                }

                myConnection.Close();


                MessageBox.Show("task completed!", "delet finish",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
