namespace Son_of_Duo
{
    partial class FB_MAINF
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button_Back = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(269, 210);
            button1.Name = "button1";
            button1.Size = new Size(159, 23);
            button1.TabIndex = 0;
            button1.Text = "Grammaire";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 131);
            button2.Name = "button2";
            button2.Size = new Size(159, 23);
            button2.TabIndex = 1;
            button2.Text = "Vocabulaire";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(269, 171);
            button3.Name = "button3";
            button3.Size = new Size(159, 23);
            button3.TabIndex = 2;
            button3.Text = "Verbes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Fill in the Game";
            // 
            // button4
            // 
            button4.Location = new Point(269, 249);
            button4.Name = "button4";
            button4.Size = new Size(188, 23);
            button4.TabIndex = 4;
            button4.Text = "Can you correct your mistakes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button_Back
            // 
            button_Back.Location = new Point(128, 323);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(75, 23);
            button_Back.TabIndex = 5;
            button_Back.Text = "Back";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // FB_MAINF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Back);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FB_MAINF";
            Text = "FB_MAINF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button_Back;
    }
}