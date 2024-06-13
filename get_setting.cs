using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Foodi
{
    public partial class get_setting : Form
    {
        string username;
        public string order;
        //public int[] num_orders = new int[5];
        Dictionary<string, string> num_orders = new Dictionary<string, string>();
        //=========================================================================================
        public get_setting(string username)
        {
            InitializeComponent();
            this.order = "";
            this.username = username;

            num_orders[label_exit.Text] = "exit";
            num_orders[label_foods.Text] = "foods";
            num_orders[label_login.Text] = "login";
            num_orders[label_orders.Text] = "orders";
            num_orders[label_setting.Text] = "setting";

        }
        //=========================================================================================
        private void get_setting_Load(object sender, EventArgs e)
        {
            
        }
        //=========================================================================================
        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("your changes will be saved",
                "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (a == DialogResult.Cancel)
                return;


            num_orders[order_exit.Text] = "exit";
            num_orders[order_food.Text] = "foods";
            num_orders[order_login.Text] = "login";
            num_orders[order_order.Text] = "orders";
            num_orders[order_setting.Text] = "setting";

            
            for (int i = 1; i < 6; i++)
            {
                try
                {
                    this.order += num_orders[i.ToString()] + ",";
                }
                catch
                {
                    continue;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
        //=========================================================================================
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.order = null;
        }
        //=========================================================================================
    }
}
