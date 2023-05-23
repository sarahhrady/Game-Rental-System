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
    public partial class Query_Statements : Form
    {
        public Query_Statements()
        {
            InitializeComponent();
        }

        private void Query_Statements_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statement1 stat1 = new Statement1();
            stat1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statement2 stat2 = new statement2();
            stat2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statement3 stat3 = new statement3();
            stat3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            statement4 stat4 = new statement4();
            stat4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statemnet5 stat5 = new statemnet5();
            stat5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            statement6 stat6 = new statement6();
            stat6.Show();
            this.Hide();
        }
    }
}
