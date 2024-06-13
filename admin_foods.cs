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
    public partial class admin_foods : Form
    {
        MySqlConnection myc = Form1.myConnection;

        string ftd;
        public admin_foods()
        {
            InitializeComponent();
        }

        private void foods_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_foods_Load(object sender, EventArgs e)
        {
            foods_grid.ColumnCount = 3;

            foods_grid.Columns[0].Name = "counter";
            foods_grid.Columns[0].HeaderText = "number";
            foods_grid.Columns[1].Name = "food_name";
            foods_grid.Columns[1].HeaderText = "name of food";
            foods_grid.Columns[2].Name = "food_price";
            foods_grid.Columns[2].HeaderText = "price of food";


            int counter = 1;
            MySqlCommand mysq = new MySqlCommand();
            mysq.Connection = myc;
            mysq.CommandText = "SELECT name, price FROM foods";

            myc.Open();

            using (var re = mysq.ExecuteReader())
            {
                while (re.Read())
                {
                    foods_grid.Rows.Add(counter++, re.GetString("name"), re.GetInt32("price"));
                }
            }

            myc.Close();

            foods_grid.AutoGenerateColumns = false;

            foods_grid.Dock = DockStyle.Fill;


            
        }
    }
}
