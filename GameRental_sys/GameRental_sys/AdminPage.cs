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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGame game = new AddGame();
            game.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAminInfo updateadmin = new UpdateAminInfo();
            updateadmin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGame updategame = new UpdateGame();
            updategame.Show();
            this.Hide();
        }
    }
}
