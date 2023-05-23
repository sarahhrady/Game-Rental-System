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
    public partial class Rent_And_Return : Form
    {
        public Rent_And_Return()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = "insert into rent (game_name, game_ID, client_name, client_ID, vendor_ID, vendor_name, rent_month ) values ('" + gamename.Text + "','" + gameid.Text + "', '" + cname.Text + "', '" + cid.Text + "', '" + vendorID.Text + "' , '" + vendorN.Text + "', '" + month.Text + "') ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Game Rented Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = "DELETE FROM rent WHERE game_ID='" + gameid.Text + "' AND client_ID= '" + cid.Text + "' AND vendor_ID= '" + vendorID.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Game Returned Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
