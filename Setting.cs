using Foodi.Properties;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities;
using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Foodi
{
    public partial class Setting : Form
    {
        public bool logged_in = false;
        public string username;
        MySqlConnection myc = Form1.myConnection;
        //=========================================================================================
        public Setting(bool logged_in, string username = "")
        {
            InitializeComponent();
            this.logged_in = logged_in;
            this.username = username;
        }
        //=========================================================================================
        private void Setting_Load(object sender, EventArgs e)
        {

        }
        //=========================================================================================
        private void button_setting_set_Click(object sender, EventArgs e)
        {
            if (!logged_in)
            {
                MessageBox.Show("you must login first!",
                    "login needed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            get_setting gs = new get_setting(this.username);
            DialogResult dr = gs.ShowDialog();

            if (dr == DialogResult.OK)
            {
                myc.Open();
                string order = gs.order;

                MessageBox.Show(order);

                MySqlCommand mysqc = new MySqlCommand();
                mysqc.Connection = myc;
                mysqc.CommandText = "UPDATE users SET special_menu = " + $"\"{order}\"" + " WHERE username =" + "\"" + username + "\"";

                mysqc.ExecuteNonQuery();


                MessageBox.Show(
                    "your settings are saved succesfully",
                    "data saved!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                myc.Close();

                ((Form1)this.MdiParent).logged_in = true;
                ((Form1)this.MdiParent).username = this.username;
                ((Form1)this.MdiParent).Form1_Load(sender, e);
                this.Close();

            }
        }
        //=========================================================================================
        private void shorts_button_Click(object sender, EventArgs e)
        {
            if (!logged_in)
            {
                MessageBox.Show("you must login first!",
                    "login needed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            form_shortcutkeys fs = new form_shortcutkeys(this.username);
            DialogResult dr = fs.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Dictionary<string, bool> shortcutkeys = fs.shortcuts;

                string shorts = "";

                //TODO :
                // why after form 1 loads again, the menu fucks?


                foreach (var shkey in shortcutkeys.Keys)
                {
                    if (shortcutkeys[shkey])
                    {
                        shorts += shkey + ",";
                    }
                }

                myc.Open();

                MySqlCommand mysqc = new MySqlCommand();
                mysqc.Connection = myc;
                mysqc.CommandText = "UPDATE users SET shortcuts = " + $"\"{shorts}\"" + " WHERE username =" + "\"" + username + "\"";

                mysqc.ExecuteNonQuery();


                MessageBox.Show(
                    "your settings are saved succesfully",
                    "data saved!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                myc.Close();

                ((Form1)this.MdiParent).logged_in = true;
                ((Form1)this.MdiParent).username = this.username;
                ((Form1)this.MdiParent).Form1_Load(sender, e);
                this.Close();
            }
        }
        //=========================================================================================
        private void current_menu_Click(object sender, EventArgs e)
        {
            if (!logged_in)
            {
                MessageBox.Show("you must login first!",
                    "login needed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            myc.Open();

            MySqlCommand mysqc = new MySqlCommand();
            mysqc.Connection = myc;
            mysqc.CommandText = "SELECT special_menu FROM users WHERE username = \"" + username + "\"";


            string[] setting = {String.Empty};

            using (var re = mysqc.ExecuteReader())
            {
                while (re.Read())
                {
                    try
                    {
                        setting = re.GetString("special_menu").Split(',');
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            myc.Close();


            try
            {
                string a = setting[0];
            }
            catch
            {
                MessageBox.Show(
                    "you have not set any setting yet", "no setting",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string str_menu = "";

            foreach (var a in setting)
            {
                str_menu += a + '\n';
            }

            MessageBox.Show(
                "here is your menu items:\n\n" + str_menu,
                "current menu items",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        //=========================================================================================
        private void current_shortcuts_Click(object sender, EventArgs e)
        {
            if (!logged_in)
            {
                MessageBox.Show("you must login first!",
                    "login needed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            myc.Open();

            MySqlCommand mysqc = new MySqlCommand();
            mysqc.Connection = myc;
            mysqc.CommandText = "SELECT special_menu FROM users WHERE username = \"" + username + "\"";


            string[] setting = { String.Empty };

            using (var re = mysqc.ExecuteReader())
            {
                while (re.Read())
                {
                    try
                    {
                        setting = re.GetString("special_menu").Split(',');
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            myc.Close();


            try
            {
                string a = setting[0];
            }
            catch
            {
                MessageBox.Show(
                    "you have not set any setting yet", "no setting",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string str_shortcuts = "";

            foreach (var a in setting)
            {
                if (a == String.Empty | a == " ")
                    continue;
                str_shortcuts += "Alt + " + a + '\n';
            }

            MessageBox.Show(
                "here is your menu items:\n\n" + str_shortcuts,
                "current menu items",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                MySqlCommand myscq = new MySqlCommand();
                myscq.Connection = myc;
                myscq.CommandText = "UPDATE users SET bg_color = \"" + MyDialog.Color + "\"WHERE username = \"" + username + "\";";
                myc.Open();

                myscq.ExecuteNonQuery();

                myc.Close();

                MessageBox.Show("your settings are saved succesfully",
                    "data saved!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ((Form1)this.MdiParent).logged_in = true;
                ((Form1)this.MdiParent).username = this.username;
                ((Form1)this.MdiParent).Form1_Load(sender, e);
            }
        }
        //=========================================================================================
    }
}
