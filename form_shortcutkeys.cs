using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Foodi
{
    public partial class form_shortcutkeys : Form
    {
        public Dictionary<string, bool> shortcuts = new Dictionary<string, bool>(5);
        public string username;
        //=========================================================================================
        public form_shortcutkeys(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        //=========================================================================================
        private void form_shortcutkeys_Load(object sender, EventArgs e)
        {

        }
        //=========================================================================================
        private void save_button_Click(object sender, EventArgs e)
        {
            CheckBox[] chs = { button_foods, button_profile, button_orders, button_exit, button_setting };


            foreach (CheckBox a in chs)
                if (a.Checked)
                    shortcuts[a.Name] = true;


                this.DialogResult = DialogResult.OK;
        }
        //=========================================================================================
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //=========================================================================================
    }
}
