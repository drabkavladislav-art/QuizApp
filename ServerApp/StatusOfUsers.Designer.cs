namespace ServerApp
{
    partial class StatusOfUsers
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
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 0;
            button1.Text = "End Quiz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(407, 144);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Location = new Point(344, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 44);
            button2.TabIndex = 2;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // StatusOfUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "StatusOfUsers";
            Size = new Size(476, 253);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
    }
}
