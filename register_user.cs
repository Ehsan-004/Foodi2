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
    public partial class register_user : Form
    {
        MySqlConnection myc = Form1.myConnection;
        //==============================================================================
        public register_user()
        {
            InitializeComponent();
        }
        //==============================================================================
        private void register_user_Load(object sender, EventArgs e)
        {
            
        }
        //==============================================================================
        private void have_account_buttun_Click(object sender, EventArgs e)
        {
            ((Form1)this.MdiParent).open_login_menu();
            try
            {
                myc.Close();
            }
            catch
            { }
            this.Close();
        }
        //==============================================================================
        private void button_login_Click(object sender, EventArgs e)
        {
            myc.Open();

            if (tb_new_username.Text == "")
            {
                MessageBox.Show(
                    "enter your username!",
                    "username error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tb_new_username.Focus();
                return;
            }

            if (tb_new_password.Text == "")
            {
                MessageBox.Show(
                    "enter your password!",
                    "password error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tb_new_password.Focus();
                return;
            }
            else if (tb_new_password.Text.Length < 4)
            {
                MessageBox.Show("a password has at least 4 characters",
                    "length error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_new_password.Focus();
                return;
            }

            bool created = false;

            MySqlConnection mycon = Form1.myConnection;
            MySqlCommand mycommand = new MySqlCommand();
            mycommand.Connection = mycon;
            mycommand.CommandText = $"SELECT * FROM users WHERE username = \"{tb_new_username.Text}\"";

            using (var reader = mycommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        if (tb_new_username.Text == reader.GetString("username"))
                        {
                            MessageBox.Show(
                            "this uername has already been used! use another username",
                            "username error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            tb_new_username.Focus();
                            return;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            mycommand.CommandText = $"INSERT INTO users(username, password) VALUES (\"{tb_new_username.Text}\", \"{tb_new_password.Text}\")";
            
            mycommand.ExecuteNonQuery();
            created = true;

            //go to login form if user is created
            if (created)
            {
                MessageBox.Show(
                    "your accout has been successfuly created!",
                    "registered!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ((Form1)this.MdiParent).open_login_menu();
                try
                {
                    myc.Close();
                }
                catch { }
                this.Close();
            }
            else
            {
                tb_new_username.Focus();
            }
        }
        //==============================================================================
        //error provider
        private void tb_new_username_Validating(object sender, CancelEventArgs e)
        {
            if (tb_new_username.Text == String.Empty)
            {
                username_checker.SetError(tb_new_username, "enter a valid username");
            }
            else
            {
                username_checker.Clear();
            }
        }
        //==============================================================================
        //error provider
        private void tb_new_password_Validating(object sender, CancelEventArgs e)
        {
            if (tb_new_password.Text == String.Empty)
            {
                password_checker.SetError(tb_new_password, "enter your password!");
            }
            else if (tb_new_password.Text.Length < 4)
            {
                password_checker.SetError(tb_new_password, "password has 4 characters at least");
            }
            else
            {
                password_checker.Clear();
            }
        }
        //==============================================================================
        //error provider
        private void tb_password_again_Validating(object sender, CancelEventArgs e)
        {
            if (tb_new_password.Text == String.Empty)
            {
                again_checker.SetError(tb_new_password, "enter your password again");
            }
            else if (tb_new_password.Text != tb_password_again.Text)
            {
                again_checker.SetError(tb_password_again, "your password does not match!");
            }
            else
            {
                again_checker.Clear();
            }
        }
        //==============================================================================
    }
}
