namespace WinFormsApp3
{
    partial class Form3
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
            labelQuestion = new Label();
            textBoxAnswer = new TextBox();
            submit_Button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(541, 325);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(249, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "fill in the blank";
            // 
            // labelQuestion
            // 
            labelQuestion.Location = new Point(183, 92);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(297, 23);
            labelQuestion.TabIndex = 2;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(249, 180);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(100, 23);
            textBoxAnswer.TabIndex = 3;
            // 
            // submit_Button1
            // 
            submit_Button1.Location = new Point(233, 269);
            submit_Button1.Name = "submit_Button1";
            submit_Button1.Size = new Size(75, 23);
            submit_Button1.TabIndex = 4;
            submit_Button1.Text = "Submit";
            submit_Button1.UseVisualStyleBackColor = true;
            submit_Button1.Click += submit_Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 188);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Answer:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(submit_Button1);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelQuestion);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Vocabulaire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label labelQuestion;
        private TextBox textBoxAnswer;
        private Button submit_Button1;
        private Label label2;
    }
}