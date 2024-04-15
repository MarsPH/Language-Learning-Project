namespace WinFormsApp3
{
    partial class Form5
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
            conjonction_Button1 = new Button();
            conjonction_Button2 = new Button();
            conjonction_Button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(48, 77);
            label1.Name = "label1";
            label1.Size = new Size(597, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // conjonction_Button1
            // 
            conjonction_Button1.Location = new Point(67, 206);
            conjonction_Button1.Name = "conjonction_Button1";
            conjonction_Button1.Size = new Size(75, 23);
            conjonction_Button1.TabIndex = 2;
            conjonction_Button1.Text = "et";
            conjonction_Button1.UseVisualStyleBackColor = true;
            conjonction_Button1.Click += conjonction_Button1_Click;
            // 
            // conjonction_Button2
            // 
            conjonction_Button2.Location = new Point(188, 206);
            conjonction_Button2.Name = "conjonction_Button2";
            conjonction_Button2.Size = new Size(75, 23);
            conjonction_Button2.TabIndex = 3;
            conjonction_Button2.Text = "mais";
            conjonction_Button2.UseVisualStyleBackColor = true;
            conjonction_Button2.Click += conjonction_Button2_Click;
            // 
            // conjonction_Button3
            // 
            conjonction_Button3.Location = new Point(308, 206);
            conjonction_Button3.Name = "conjonction_Button3";
            conjonction_Button3.Size = new Size(75, 23);
            conjonction_Button3.TabIndex = 4;
            conjonction_Button3.Text = "comme";
            conjonction_Button3.UseVisualStyleBackColor = true;
            conjonction_Button3.Click += conjonction_Button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(conjonction_Button3);
            Controls.Add(conjonction_Button2);
            Controls.Add(conjonction_Button1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button conjonction_Button1;
        private Button conjonction_Button2;
        private Button conjonction_Button3;
    }
}