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
    public partial class FilterGames : Form
    {
        public FilterGames()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from game Where year Like'%" + textBox3.Text + "%'", sqlconnection);
            SqlDataAdapter reader = new SqlDataAdapter();
            DataTable dt = new DataTable();
            reader.SelectCommand = cmd;
            dt.Clear();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from game Where vendorname Like'%" + textBox1.Text + "%'", sqlconnection);
            SqlDataAdapter reader = new SqlDataAdapter();
            DataTable dt = new DataTable();
            reader.SelectCommand = cmd;
            dt.Clear();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from game Where category Like'%" + textBox2.Text + "%'", sqlconnection);
            SqlDataAdapter reader = new SqlDataAdapter();
            DataTable dt = new DataTable();
            reader.SelectCommand = cmd;
            dt.Clear();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }
    }
}
