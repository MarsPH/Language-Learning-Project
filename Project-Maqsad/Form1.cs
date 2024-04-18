using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Son_of_Duo
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
    public partial class Form1 : Form
    {
        private string[] element = { "J'adore me promener dans les rues étroite de Paris.", "Hier soir, j'ai manger une délicieuse baguette avec du fromage.", "J'aime écouter de la musique français, ça me fait voyager.", "Je prévois de partir en vacances en Provence cette été." };
        private string[] correction = { "J'adore me promener dans les rues étroites de Paris.", "Hier soir, j'ai mangé une délicieuse baguette avec du fromage.", "J'aime écouter de la musique française, ça me fait voyager.", "Je prévois de partir en vacances en Provence cet été." };
        private int currentQuestionIndex = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < element.Length)
            {
                labelQuestion.Text = element[currentQuestionIndex];
                textBoxAnswer.Text = "";
            }
            else
            {
                MessageBox.Show("All questions answered!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < element.Length)
            {
                string userAnswer = textBoxAnswer.Text.Trim();
                string correctAnswer = correction[currentQuestionIndex];

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

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
