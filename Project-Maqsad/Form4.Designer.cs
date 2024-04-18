namespace WinFormsApp3
{
    partial class Form4
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
            button1 = new Button();
            label1 = new Label();
            textBox_Questions = new TextBox();
            verbe_Option1 = new Button();
            verbe_Option2 = new Button();
            verbe_Option3 = new Button();
            verbe_Option4 = new Button();
            verbe_Option5 = new Button();
            labelQuestions = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(568, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 22);
            label1.TabIndex = 1;
            label1.Text = "Choose the right verbe";
            // 
            // textBox_Questions
            // 
            textBox_Questions.Location = new Point(222, 260);
            textBox_Questions.Name = "textBox_Questions";
            textBox_Questions.Size = new Size(281, 23);
            textBox_Questions.TabIndex = 2;
            // 
            // verbe_Option1
            // 
            verbe_Option1.Location = new Point(127, 193);
            verbe_Option1.Name = "verbe_Option1";
            verbe_Option1.Size = new Size(75, 23);
            verbe_Option1.TabIndex = 3;
            verbe_Option1.Text = "suis";
            verbe_Option1.UseVisualStyleBackColor = true;
            verbe_Option1.Click += verbe_Option1_Click;
            // 
            // verbe_Option2
            // 
            verbe_Option2.Location = new Point(243, 193);
            verbe_Option2.Name = "verbe_Option2";
            verbe_Option2.Size = new Size(75, 23);
            verbe_Option2.TabIndex = 4;
            verbe_Option2.Text = "ai";
            verbe_Option2.UseVisualStyleBackColor = true;
            verbe_Option2.Click += verbe_Option2_Click;
            // 
            // verbe_Option3
            // 
            verbe_Option3.Location = new Point(361, 193);
            verbe_Option3.Name = "verbe_Option3";
            verbe_Option3.Size = new Size(75, 23);
            verbe_Option3.TabIndex = 5;
            verbe_Option3.Text = "part";
            verbe_Option3.UseVisualStyleBackColor = true;
            verbe_Option3.Click += verbe_Option3_Click;
            // 
            // verbe_Option4
            // 
            verbe_Option4.Location = new Point(491, 193);
            verbe_Option4.Name = "verbe_Option4";
            verbe_Option4.Size = new Size(75, 23);
            verbe_Option4.TabIndex = 6;
            verbe_Option4.Text = "va";
            verbe_Option4.UseVisualStyleBackColor = true;
            // 
            // verbe_Option5
            // 
            verbe_Option5.Location = new Point(629, 193);
            verbe_Option5.Name = "verbe_Option5";
            verbe_Option5.Size = new Size(75, 23);
            verbe_Option5.TabIndex = 7;
            verbe_Option5.Text = "peut";
            verbe_Option5.UseVisualStyleBackColor = true;
            // 
            // labelQuestions
            // 
            labelQuestions.Location = new Point(243, 100);
            labelQuestions.Name = "labelQuestions";
            labelQuestions.Size = new Size(274, 26);
            labelQuestions.TabIndex = 8;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelQuestions);
            Controls.Add(verbe_Option5);
            Controls.Add(verbe_Option4);
            Controls.Add(verbe_Option3);
            Controls.Add(verbe_Option2);
            Controls.Add(verbe_Option1);
            Controls.Add(textBox_Questions);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Verbes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox_Questions;
        private Button verbe_Option1;
        private Button verbe_Option2;
        private Button verbe_Option3;
        private Button verbe_Option4;
        private Button verbe_Option5;
        private Label labelQuestions;
    }
}