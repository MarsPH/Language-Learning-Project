using Son_of_Duo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form5 : Form
    {

        string conjunction = "La conjonction de coordination est l’une des deux sortes de conjonctions. Elle sert à joindre des groupes de mots ayant la même fonction syntaxique ou des phrases.";
        private string[] conjonction = { "Il a acheter des bonbons ____ les ballons.", "Il voulait partir au centre d'achat _____ il a des cours cette apres midi.", "Je suis un etudiant du college Lasalle ______ mon ami." };
        private int currentQuestionIndex = 0;



        public Form5()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < conjonction.Length)
            {
                label1.Text = conjonction[currentQuestionIndex].Trim();

            }
            else
            {
                MessageBox.Show("All questions answered!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FB_MAINF FillingBrank = new FB_MAINF();
            FillingBrank.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(conjunction);

        }

        private void conjonction_Button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == conjonction[0])
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            currentQuestionIndex++;
            DisplayQuestion();


        }

        private void conjonction_Button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == conjonction[1])
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void conjonction_Button3_Click(object sender, EventArgs e)
        {
            if(label1.Text == conjonction[2])
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("incorrect!");
            }
            currentQuestionIndex++;
            DisplayQuestion();

        }
    }
}
