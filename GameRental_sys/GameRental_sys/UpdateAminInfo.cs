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
    public partial class UpdateAminInfo : Form
    {
        public UpdateAminInfo()
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
                sqlcommand1.CommandText = " update admin set admin_name = '" + name.Text + "' where admin_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Name Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = " update admin set admin_phonenum = '" + phone.Text + "' where admin_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Phone Number Updated Successfully");
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
                sqlcommand1.CommandText = " update users set username = '" + username.Text + "' where admin_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("User name Updated Successfully");
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
                sqlcommand1.CommandText = " update users set email = '" + email.Text + "' where admin_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("email Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-DFCPRCE;Initial Catalog=gamesrental;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = " update users set password = '" + password.Text + "' where admin_ID = '" + id.Text + "' ";
                sqlcommand1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Password Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
