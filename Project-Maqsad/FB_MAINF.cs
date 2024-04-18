using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;

namespace Son_of_Duo
{
    public partial class FB_MAINF : Form
    {
        public FB_MAINF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 open = new Form2();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 open = new Form3();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 open = new Form4();
            open.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 open = new Form1();
            open.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu = new menu();
            menu.Show();


        }
    }
}
