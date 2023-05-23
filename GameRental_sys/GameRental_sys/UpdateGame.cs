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
    public partial class UpdateGame : Form
    {
        public UpdateGame()
        {
            InitializeComponent();
        }

        private void UpdateGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = " update game set game_name = '" + gameN.Text + "' where game_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                if (gameN.Text != "" && id.Text != "")
                    MessageBox.Show("Game name Updated Successfully");
                else
                {
                    MessageBox.Show("ID or game name is not filled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = " update game set category = '" + category.Text + "' where game_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                if (category.Text != "" && id.Text != "")
                    MessageBox.Show("Game category Updated Successfully");
                else
                {
                    MessageBox.Show("ID or category name is not filled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = " update game set vendorname = '" + vendor.Text + "' where game_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                if (vendor.Text != "" && id.Text != "")
                    MessageBox.Show("Vendor name Updated Successfully");
                else
                {
                    MessageBox.Show("ID or vendor name is not filled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
