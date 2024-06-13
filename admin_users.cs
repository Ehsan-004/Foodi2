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
    public partial class admin_users : Form
    {
        MySqlConnection myc = administrator.myConnection;

        public admin_users()
        {
            InitializeComponent();
        }

        private void admin_users_Load(object sender, EventArgs e)
        {
            int counter = 1;

            users_grid.ColumnCount = 3;

            users_grid.Columns[0].Name = "counter";
            users_grid.Columns[0].HeaderText = "number";
            users_grid.Columns[1].Name = "user_name";
            users_grid.Columns[1].HeaderText = "username";
            users_grid.Columns[2].Name = "user_password";
            users_grid.Columns[2].HeaderText = "password of user";


            users_grid.AutoGenerateColumns = false;

            users_grid.Dock = DockStyle.Fill;

            MySqlCommand mysq = new MySqlCommand();
            mysq.Connection = myc;
            mysq.CommandText = "SELECT username FROM users";

            myc.Open();

            using (var re = mysq.ExecuteReader())
            {
                while(re.Read())
                {
                    users_grid.Rows.Add(counter++, re.GetString("username") );
                }    
            }

            myc.Close();
        }

        private void users_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
