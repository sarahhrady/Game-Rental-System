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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }



        private void SignUp_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesrentalDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.gamesrentalDataSet.client);
            // TODO: This line of code loads data into the 'gamesrentalDataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.gamesrentalDataSet.admin);

        }

       

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                SqlCommand sqlcommand2 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand2.Connection = sqlconnection;
                sqlcommand1.CommandText = "insert into client values ('" + admin_name.Text + "', '" + gender.Text + "', '" + country.Text + "', '" + phone.Text + "', '" + day.Text + "', '" + month.Text + "', '" + year.Text + "', '" + id.Text + "' )";
                sqlcommand2.CommandText = "insert into users (username, email, password, client_ID ) values ('" + username.Text + "','" + email.Text + "', '" + password.Text + "', '" + id.Text + "' ) ";
                sqlcommand1.ExecuteNonQuery();
                sqlcommand2.ExecuteNonQuery();
                sqlconnection.Close();
                ClientPage client = new ClientPage();
                client.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                SqlCommand sqlcommand2 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand2.Connection = sqlconnection;
                sqlcommand1.CommandText = "insert into admin values ('" + admin_name.Text + "', '" + day.Text + "', '" + month.Text + "', '" + year.Text + "', '" + id.Text + "', '" + phone.Text + "', '" + gender.Text + "', '" + country.Text + "' )";
                sqlcommand2.CommandText = "insert into users (username, email, password, admin_ID ) values ('" + username.Text + "','" + email.Text + "', '" + password.Text + "', '" + id.Text + "' ) ";
                sqlcommand1.ExecuteNonQuery();
                sqlcommand2.ExecuteNonQuery();
                sqlconnection.Close();
                AdminPage admin = new AdminPage();
                admin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Query_Statements query = new Query_Statements();
            query.Show();
            this.Hide();
        }
    }
}
