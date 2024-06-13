using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Channels;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data.SqlClient;


namespace Foodi
{
    public partial class Form1 : Form
    {
        public bool admin = false;
        //public [] string admin_access;

        public string username;
        public bool logged_in = false;
        public static string order_path = @"E:\foodi\orders\";
        public string foods_path = @"E:\foodi\foods.fdi";
        public string users_path = @"E:\foodi\users.fdi";
        public string setting_path = @"E:\foodi\settings\";
        public string admins_path = @"E:\foodi\.admins.fdi";



        
        public static string myConnectionString = "server=127.0.0.1;uid=root;database=foodi2";
        public static MySqlConnection myConnection = new MySqlConnection(myConnectionString);
        //=========================================================================================
        public Form1()
        {
            InitializeComponent();
        }
        //=========================================================================================
        //when the form loads the text of login button changes
        public void Form1_Load(object sender, EventArgs e)
        {
            if (this.admin)
            {
                return;
            }
            //this menusetter checks if user has set any setting for menustrip or not
            
            try
            {
                menu_setter(sender, e);
            }
            catch
            {

            }
            try
            {
                shortcuts_setter(sender, e);
            }
            catch
            {

            }
            //try
            //{
            //    bg_color_setter();
            //}
            //catch
            //{

            //}

            if (logged_in)
            {
                label_username.Text = "Wellcome " + this.username;
                button_profile.Text = "logout";
            }
            else
            {
                label_username.Text = "you haven't logged in!";
                button_profile.Text = "login";
            }
        }
        //=========================================================================================
        public void bg_color_setter()
        {
            if (!logged_in)
                //no user is found!
                return;

            MySqlCommand mysqc = new MySqlCommand();
            mysqc.Connection = myConnection;
            mysqc.CommandText = "SELECT bg_color FROM users WHERE username = \"" + username + "\"";

            myConnection.Open();
            string data = String.Empty;

            using (var Re = mysqc.ExecuteReader())
                while (Re.Read())
                    data = Re.GetString("bg_color");

            myConnection.Close();

            if (data == String.Empty | data == " ")
                //it means that the current user has not set any setting for the menus
                return;
        }
        //=========================================================================================
        // this method sets a menustrip if user has sat any!
        public void menu_setter(object sender, EventArgs e)
        {
            if (!logged_in)
                //no user is found!
                return;

            MySqlCommand mysqc = new MySqlCommand();
            mysqc.Connection = myConnection;
            mysqc.CommandText = "SELECT special_menu FROM users WHERE username = \"" + username + "\"";
            string data = String.Empty;

            top_menu.Show();

            myConnection.Open();

            using(var Re = mysqc.ExecuteReader())
                while(Re.Read())
                    data = Re.GetString("special_menu");

            myConnection.Close();

            if (data == String.Empty | data == " ")
                //it means that the current user has not set any setting for the menus
                return;

            string[] setting;
            setting = data.Split(',');

            foreach (var a in setting)
            {
                if (a == " " | a == String.Empty)
                    continue;
                
                top_menu.Items.Add(a);
            }
        }
        //=========================================================================================
        //
        public void shortcuts_setter(object sender, EventArgs eventArgs)
        {
            Button[] btns = { button_foods, button_orders, };


            if (!logged_in)//no user is found!
                return;

            string path = this.setting_path + this.username + ".set";
            string[] sett;
            string[] shortcuts;

            if (!File.Exists(path))
                //it means that the current user has not set any setting for the menus
                return;

            using (StreamReader sr = new StreamReader(path))
                sett = sr.ReadLine().Split('-');

            shortcuts = sett[1].Split(' '); // the second part is for the shortcut keys 

            foreach (var a in shortcuts)
            {
                if (a == " ")
                    continue;

                foreach (var btn in this.Controls.OfType<Button>())
                {
                    if (btn.Name == a)
                    {
                        btn.Name = "&" + btn.Name;
                    }
                }
            }
        }
        //=========================================================================================
        //due to the clicked button in the menustrip if exists it does something
        private void top_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "logout")
                this.button_profile_Click(sender, e);
            else if (e.ClickedItem.Text == "orders")
                this.button_orders_Click(sender, e);
            else if (e.ClickedItem.Text == "foods")
                this.button_foods_Click(sender, e);
            else if (e.ClickedItem.Text == "setting")
                this.button_setting_Click(sender, e);
            else if (e.ClickedItem.Text == "exit")
            {
                DialogResult a = MessageBox.Show(
                    "are you sure you want to exit?",
                    "exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (a== DialogResult.Yes)
                {
                    Form.ActiveForm.Close();
                    Environment.Exit(0);
                }
                
            }
        }
        //===================================   button   ==========================================
        //if profile button or login button is clicked
        private void button_profile_Click(object sender, EventArgs e)
        {
            if (!this.logged_in)
            {
                //user has clicked the login buttun
                Form1_Load(sender, e);
                login_form f = new login_form();
                f.MdiParent = this;
                // the child form will fill all page
                f.Dock = DockStyle.Fill;
                // to remove the title bar
                f.FormBorderStyle = FormBorderStyle.None;
                f.Show();
            }
            else
            {
                //user has clicked logout buttun
                DialogResult a = MessageBox.Show(
                    "are you sure you want to logout?",
                    "logout",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (a == DialogResult.OK)
                {
                    this.logged_in = false;
                    this.username = String.Empty;
                    
                    foreach (var form in this.MdiChildren)
                        form.Close();

                    label_username.Text = "you haven't logged in yet!";
                    button_profile.Text = "login";
                    top_menu.Items.Clear();
                    this.Form1_Load(sender, e);
                }
            }
        }
        //===================================   button   ==========================================
        //if orders button is clicked
        private void button_orders_Click(object sender, EventArgs e)
        {
            if (!logged_in)
            {
                MessageBox.Show(
                    "you must login firs!",
                    "login error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                user_orders uo = new user_orders(this.username);
                uo.MdiParent = this;
                uo.Dock = DockStyle.Fill;
                uo.FormBorderStyle = FormBorderStyle.None;
                uo.Show();

            }
        }
        //===================================   button   ==========================================
        //if foods button is clicked
        public void button_foods_Click(object sender, EventArgs e)
        {
            //when the food button is clicked
            {
                if (!logged_in)
                {
                    DialogResult a = MessageBox.Show(
                    "you are not logged in yet and you foods will be gone, login first",
                    "login notice",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                    if (a == DialogResult.OK)
                    {
                        this.button_profile_Click(sender, e);
                    }
                    else
                    {
                        Foods f = new Foods(logged_in, username);
                        f.MdiParent = this;
                        // the child form will fill all page
                        f.Dock = DockStyle.Fill;
                        // to remove the title bar
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Show();
                    }
                }
                else
                {
                    Foods f = new Foods(this.logged_in, this.username);
                    f.MdiParent = this;
                    // the child form will fill all page
                    f.Dock = DockStyle.Fill;
                    // to remove the title bar
                    f.FormBorderStyle = FormBorderStyle.None;
                    f.Show();
                }
            }
        }
        //=========================================================================================
        //this method opends a login page in the app 
        // it is used in different parts
        public void open_login_menu()
        {
            login_form f = new login_form();
            f.MdiParent = this;
            // the child form will fill all page
            f.Dock = DockStyle.Fill;
            // to remove the title bar
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }
        //=========================================================================================
        //this is the same as above but it openes the register page
        public void open_reg_menu()
        {
            register_user f = new register_user();
            f.MdiParent = this;
            // the child form will fill all page
            f.Dock = DockStyle.Fill;
            // to remove the title bar
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }
        //=========================================================================================
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        //=========================================================================================
        private void button_setting_Click(object sender, EventArgs e)
        {
            Setting f = new Setting(this.logged_in, this.username);
            f.MdiParent = this;
            // the child form will fill all page
            f.Dock = DockStyle.Fill;
            // to remove the title bar
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }
        //=========================================================================================
    }
}
