using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRental_sys
{
    public partial class ClientPage : Form
    {
        public ClientPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateClientInfo updateclient = new UpdateClientInfo();
            updateclient.Show();
            this.Hide();
        }

        private void Bro_Click(object sender, EventArgs e)
        {
            SearchGames searchgames = new SearchGames();
            searchgames.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterGames filter = new FilterGames();
            filter.Show();
            this.Hide();
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rent_And_Return rent = new Rent_And_Return();
            rent.Show();
            this.Hide();
        }
    }
}
