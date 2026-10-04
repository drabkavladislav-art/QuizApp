namespace ServerApp
{
    partial class QuizControl
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Q1 = new Button();
            Q2 = new Button();
            Q3 = new Button();
            Q4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 0;
            button1.Text = "Add Quesition";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(297, 13);
            button2.Name = "button2";
            button2.Size = new Size(119, 40);
            button2.TabIndex = 1;
            button2.Text = "Start  Quiz";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(123, 56);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 2;
            label1.Text = "Select Quetion here";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(338, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(338, 27);
            textBox4.TabIndex = 6;
            // 
            // Q1
            // 
            Q1.BackColor = Color.Red;
            Q1.Font = new Font("Segoe UI", 12F);
            Q1.Location = new Point(344, 85);
            Q1.Name = "Q1";
            Q1.Size = new Size(72, 37);
            Q1.TabIndex = 7;
            Q1.Text = "OpenQ1";
            Q1.UseVisualStyleBackColor = false;
            Q1.Click += button3_Click;
            // 
            // Q2
            // 
            Q2.BackColor = Color.Red;
            Q2.Font = new Font("Segoe UI", 12F);
            Q2.Location = new Point(344, 132);
            Q2.Name = "Q2";
            Q2.Size = new Size(72, 37);
            Q2.TabIndex = 8;
            Q2.Text = "OpenQ2";
            Q2.UseVisualStyleBackColor = false;
            Q2.Click += Q2_Click;
            // 
            // Q3
            // 
            Q3.BackColor = Color.Red;
            Q3.Font = new Font("Segoe UI", 12F);
            Q3.Location = new Point(347, 175);
            Q3.Name = "Q3";
            Q3.Size = new Size(72, 37);
            Q3.TabIndex = 9;
            Q3.Text = "OpenQ3";
            Q3.UseVisualStyleBackColor = false;
            Q3.Click += Q3_Click;
            // 
            // Q4
            // 
            Q4.BackColor = Color.Red;
            Q4.Font = new Font("Segoe UI", 12F);
            Q4.Location = new Point(344, 223);
            Q4.Name = "Q4";
            Q4.Size = new Size(72, 37);
            Q4.TabIndex = 10;
            Q4.Text = "OpenQ4";
            Q4.UseVisualStyleBackColor = false;
            Q4.Click += Q4_Click;
            // 
            // QuizControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(Q4);
            Controls.Add(Q3);
            Controls.Add(Q2);
            Controls.Add(Q1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "QuizControl";
            Size = new Size(430, 263);
            Load += QuizControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Q1;
        private Button Q2;
        private Button Q3;
        private Button Q4;
    }
}
