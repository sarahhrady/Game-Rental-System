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
    public partial class AddGame : Form
    {
        public AddGame()
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
                SqlCommand sqlcommand2 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand2.Connection = sqlconnection;
                sqlcommand1.CommandText = "insert into game values ('" + gameN.Text + "', '" + gameID.Text + "', '" + category.Text + "', '" + day.Text + "', '" + month.Text + "', '" + year.Text + "', '" + vendorN.Text + "' , '" + vendorID.Text + "' )";
                sqlcommand2.CommandText = "insert into vendor values ('" + vendorN.Text + "', '" + vendorID.Text + "', '" + country.Text + "' )";
                sqlcommand1.ExecuteNonQuery();
                sqlcommand2.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Game Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesrentalDataSet.game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.gamesrentalDataSet.game);

        }
    }
}
