namespace ServerApp
{
    partial class MainMenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Open1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(159, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 54);
            label1.TabIndex = 0;
            label1.Text = "Quiz App";
            // 
            // Open1
            // 
            Open1.BackColor = Color.GreenYellow;
            Open1.Font = new Font("Segoe UI", 12F);
            Open1.ForeColor = Color.Black;
            Open1.Location = new Point(3, 184);
            Open1.Name = "Open1";
            Open1.Size = new Size(150, 39);
            Open1.TabIndex = 1;
            Open1.Text = "Open quiz";
            Open1.UseVisualStyleBackColor = false;
            Open1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 52);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(159, 47);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Quiz name here";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(140, 133);
            button2.Name = "button2";
            button2.Size = new Size(231, 43);
            button2.TabIndex = 4;
            button2.Text = "Create new Quiz";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.GreenYellow;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(3, 235);
            button3.Name = "button3";
            button3.Size = new Size(150, 41);
            button3.TabIndex = 6;
            button3.Text = "Open quiz";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.GreenYellow;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(0, 282);
            button4.Name = "button4";
            button4.Size = new Size(150, 45);
            button4.TabIndex = 7;
            button4.Text = "Open quiz";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.GreenYellow;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(0, 333);
            button5.Name = "button5";
            button5.Size = new Size(150, 41);
            button5.TabIndex = 8;
            button5.Text = "Open quiz";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 184);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 45);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 235);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 41);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 282);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 43);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(159, 333);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 41);
            textBox5.TabIndex = 12;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Open1);
            Controls.Add(label1);
            Name = "MainMenuControl";
            Size = new Size(566, 447);
            Load += MainMenuControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Open1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
