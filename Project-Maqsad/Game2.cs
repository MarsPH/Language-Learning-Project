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
    public partial class Game2 : Form
    {
        private Dictionary<string, string> vocabPairs = new Dictionary<string, string>
    {
        {"chat", "cat"},
        {"chien", "dog"},
        {"maison", "house"},
        {"livre", "book"}
    };
        private List<string> words;
        private Button firstClicked = null;
        private Button secondClicked = null;

        public Game2()
        {
            InitializeComponent();
            AssignWordsToButtons();
        }

        private void AssignWordsToButtons()
        {
            words = vocabPairs.Keys.Concat(vocabPairs.Values).ToList();
            Random rand = new Random();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Button wordButton = control as Button;
                if (wordButton != null)
                {
                    int randomIndex = rand.Next(words.Count);
                    wordButton.Text = words[randomIndex];
                    words.RemoveAt(randomIndex);
                    wordButton.BackColor = Color.Silver;
                    wordButton.Click += button_Click;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            if (clickedButton.BackColor == Color.White)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedButton;
                firstClicked.BackColor = Color.White;
                return;
            }

            secondClicked = clickedButton;
            secondClicked.BackColor = Color.White;

            CheckForMatch();
        }

        private void CheckForMatch()
        {
            if (firstClicked.Text == vocabPairs.FirstOrDefault(x => x.Value == secondClicked.Text).Key ||
                secondClicked.Text == vocabPairs.FirstOrDefault(x => x.Value == firstClicked.Text).Key)
            {
                firstClicked = null;
                secondClicked = null;
                MessageBox.Show("Match!");
            }
            else
            {
                MessageBox.Show("Try again!");
                firstClicked.BackColor = Color.Silver;
                secondClicked.BackColor = Color.Silver;
                firstClicked = null;
                secondClicked = null;
            }
        }
    }
}
