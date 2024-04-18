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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private string[] questions = { "House:_________", "Window:_______", "Car:________", "Computer:_________",
        "Pencil:_________", "Friend:_________", "Water:_________", "Hair:_________","Eyes:__________", "Horse:__________"};
        private string[] answers = { "Maison", "Fenêtre", "Voiture", "Ordinateur", "Crayon", "Ami", "Eau", "Cheveux", "Yeux", "Cheval" };
        private int currentQuestionIndex = 0;
        int correct = 0;
        int incorrect = 0;

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
                MessageBox.Show("All questions answered!" + $"\nPoints:{correct}");

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
                    correct++;
                }
                else
                {
                    MessageBox.Show("Incorrect. The correct answer is: " + correctAnswer);
                    correct--;
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

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            textBoxAnswer.Text = textBoxAnswer.Text.ToUpper();

            textBoxAnswer.SelectionStart = textBoxAnswer.Text.Length;
        }
    }
}
