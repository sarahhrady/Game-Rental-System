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
    public partial class Statement1 : Form
    {
        public Statement1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP  1 game_name from rent group by game_name order by count(*) DESC", sqlconnection);
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
