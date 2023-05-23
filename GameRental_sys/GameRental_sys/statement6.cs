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
    public partial class statement6 : Form
    {
        public statement6()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("Select vendorname from vendor where vendor.vendor_ID not in (select game.vendor_ID from game where game.year = 2021 )", sqlconnection);
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
