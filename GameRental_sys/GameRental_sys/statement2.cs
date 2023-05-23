using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameRental_sys
{
    public partial class statement2 : Form
    {
        public statement2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT game_name from game where game_name NOT IN(select game_name from rent where rent_month = 4 )", sqlconnection);
                SqlDataAdapter reader = new SqlDataAdapter();
                DataTable dt = new DataTable();
                reader.SelectCommand = cmd;
                dt.Clear();
                reader.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
