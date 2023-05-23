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
    public partial class SearchGames : Form
    {
        public SearchGames()
        {
            InitializeComponent();
        }

        private void SearchGames_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("Select * from game Where game_name Like'%" + textBox1.Text + "%'", sqlconnection);
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
