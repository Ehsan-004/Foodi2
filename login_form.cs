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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Prng.Drbg;


namespace Foodi
{
    public partial class login_form : Form
    {
        string name_user, password;
        MySqlConnection myc = Form1.myConnection;
        //==========================================================================
        public login_form()
        {
            InitializeComponent();
            try
            {
                myc.Close();
            }
            catch { }
        }
        //==========================================================================
        private void button_login_Click(object sender, EventArgs e)
        {
            myc.Open();

            if (tb_username.Text == "")
            {
                MessageBox.Show(
                    "enter your username!",
                    "username error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tb_username.Focus();
                return;
            }

            if (tb_password.Text == "")
            {
                MessageBox.Show(
                    "enter your password!",
                    "password error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tb_password.Focus();
                return;
            }
            else if (tb_password.Text.Length < 4)
            {
                MessageBox.Show("a password has at least 4 characters",
                    "length error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_password.Focus();
                return;
            }

            MySqlCommand mycm = new MySqlCommand();
            try
            {
                //===========================================================================
                mycm.Connection = myc;
                mycm.CommandText = $"SELECT * FROM users WHERE username = \"{tb_username.Text}\"";

                try
                {
                    //===========================================================================
                    using (var reader = mycm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string pass = reader.GetString("password");
                            bool is_st = reader.GetBoolean("is_stuff");

                            myc.Close();

                            if (tb_password.Text == pass)
                            {
                                if (!is_st)
                                {
                                    MessageBox.Show(
                                            $"Wellcome dear {tb_username.Text} !", "wellcome!",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk
                                            );

                                    ((Form1)this.MdiParent).username = tb_username.Text;
                                    ((Form1)this.MdiParent).logged_in = true;
                                    ((Form1)this.MdiParent).Form1_Load(sender, e);
                                    ((Form1)this.MdiParent).button_foods.Focus();
                                    tb_username.Text = "";
                                    tb_password.Text = "";
                                    this.Close();
                                    return;
                                }
                                else
                                {
                                    string[] admin_ac = { "foods", "users", "report" };
                                    MessageBox.Show($"wellcome admin {tb_username.Text} ",
                                                    "wellcome!", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                                    myc.Close();


                                    administrator adf = new administrator(tb_username.Text, admin_ac);
                                    adf.Show();

                                    //adf.MdiParent = this.MdiParent;
                                    //adf.Dock = DockStyle.Fill;

                                    tb_username.Text = "";
                                    tb_password.Text = "";

                                    this.MdiParent.Hide();
                                    this.Close();


                                    return;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    //===========================================================================
                    MessageBox.Show(
                        "something went wrong!",
                        "Unknown error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    myc.Close();
                    tb_username.Focus();
                }
                finally
                {
                    myc.Close();
                }
            }
            catch
            {
               
            }
            finally
            {
                myc.Close();
            }
            DialogResult dr = MessageBox.Show(
                            "wrong username !",
                            "not found error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
            myc.Close();

            

            if (dr == DialogResult.OK)
                tb_username.Focus();
        }
        //==========================================================================
        //error provider
        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            if (tb_username.Text == String.Empty)
            {
                username_check.SetError(tb_username, "enter your username!");
            }
            else
            {
                username_check.Clear();
            }
        }
        //==========================================================================
        //error provider
        private void tb_password_Validating(object sender, CancelEventArgs e)
        {
            if (tb_password.Text == String.Empty)
            {
                password_check.SetError(tb_password, "enter your password!");
            }
            else if (tb_password.Text.Length < 4)
            {
                password_check.SetError(tb_password, "password has 4 characters at least!");
            }
            else
            {
                password_check.Clear();
            }
        }
        //=========================================================================================
        private void login_form_Load(object sender, EventArgs e)
        {

        }
        //==========================================================================
        //button register new user
        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            ((Form1)this.MdiParent).open_reg_menu();
            myc.Close();
            this.Close();
        }
        //==========================================================================
    }
}
