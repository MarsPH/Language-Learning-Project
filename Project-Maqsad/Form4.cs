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
    public partial class Form4 : Form
    {
        private string[] questions = { "Je ____ un etudiant.", "J'____ des amis au Quebec.", "Je n'---- jamais vu un ours.", "Il ____ a l'aeroport" };
        private string[] answers = { "suis", "ai", "ai" };
        private int currentQuestionIndex = 0;
        public Form4()
        {
            InitializeComponent();
            DisplayQuestion();
        }
        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                labelQuestions.Text = questions[currentQuestionIndex].Trim();

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

        private void verbe_Option1_Click(object sender, EventArgs e)
        {
            if (labelQuestions.Text == questions[0])
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

        private void verbe_Option2_Click(object sender, EventArgs e)
        {
            if (labelQuestions.Text == questions[1])
            {
                MessageBox.Show("Correct!");

            }
            else if (labelQuestions.Text == questions[2])
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

        private void verbe_Option3_Click(object sender, EventArgs e)
        {
            if (labelQuestions.Text == questions[3])
            {
                MessageBox.Show("Correct!");

            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }
    }
}
