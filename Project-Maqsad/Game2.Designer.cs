namespace Son_of_Duo
{
    partial class Game2
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
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            lblMessage = new Label();
            btnSubmit = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 20F);
            lblQuestion.Location = new Point(267, 152);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(425, 54);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question appears here";
            lblQuestion.Click += label1_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Segoe UI", 25F);
            txtAnswer.Location = new Point(259, 349);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(667, 74);
            txtAnswer.TabIndex = 1;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 15F);
            lblMessage.Location = new Point(143, 621);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(923, 90);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Feedback appears heressss\r\n\r\n\r\n\r\n";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 50F);
            btnSubmit.Location = new Point(129, 724);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(937, 199);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Segoe UI", 35F);
            BtnBack.Location = new Point(129, 724);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(937, 199);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += button1_Click;
            // 
            // Game2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 985);
            ControlBox = false;
            Controls.Add(BtnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Name = "Game2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtAnswer;
        private Label lblMessage;
        private Button btnSubmit;
        private Button BtnBack;
    }
}