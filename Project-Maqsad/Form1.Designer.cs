namespace Son_of_Duo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelQuestion = new Label();
            textBoxAnswer = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Location = new Point(67, 71);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(585, 23);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "label1";
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(255, 311);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(195, 23);
            textBoxAnswer.TabIndex = 1;
            textBoxAnswer.TextChanged += textBoxAnswer_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(456, 311);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuestion;
        private TextBox textBoxAnswer;
        private Button button1;
    }
}