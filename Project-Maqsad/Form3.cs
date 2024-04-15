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

    struct MultichoiceQuestion
    {
        public string question;
        public string[] possibleAnswers;
        public int trueAnswerIndex;

        public bool ValidateChoice(string choice)
        {
            return choice.Trim() == possibleAnswers[trueAnswerIndex];
        }
    }

    public partial class Form3 : Form
    {
        private string[] questions = { "How do you say house in french:_________", "How do you say window in french:_______" };
        private string[] answers = { "Maison", "Fenetre" };
        private int currentQuestionIndex = 0;

        public Form3()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                labelQuestion.Text = questions[currentQuestionIndex];
                textBoxAnswer.Text = "";
            }
            else
            {
                MessageBox.Show("All questions answered!");
            }
        }

        private void submit_Button1_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Length)
            {
                string userAnswer = textBoxAnswer.Text.Trim();
                string correctAnswer = answers[currentQuestionIndex];

                if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Incorrect. The correct answer is: " + correctAnswer);
                }

                currentQuestionIndex++;
                DisplayQuestion();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FB_MAINF FillingBrank = new FB_MAINF();
            FillingBrank.Show();
        }
    }
}
