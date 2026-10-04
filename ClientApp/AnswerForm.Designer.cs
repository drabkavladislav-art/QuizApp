namespace ClientApp
{
    partial class AnswerForm
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
            lCorrect = new Label();
            panel1 = new Panel();
            lScore = new Label();
            lAnswer = new Label();
            lPosition = new Label();
            lGood = new Label();
            lVeryGoodYed = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lCorrect
            // 
            lCorrect.AutoSize = true;
            lCorrect.BackColor = Color.Transparent;
            lCorrect.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lCorrect.ForeColor = Color.Black;
            lCorrect.Location = new Point(3, 0);
            lCorrect.Name = "lCorrect";
            lCorrect.Size = new Size(226, 37);
            lCorrect.TabIndex = 8;
            lCorrect.Text = "Correct answer:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lAnswer);
            panel1.Controls.Add(lCorrect);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 89);
            panel1.TabIndex = 13;
            // 
            // lScore
            // 
            lScore.AutoSize = true;
            lScore.BackColor = Color.Transparent;
            lScore.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lScore.ForeColor = Color.White;
            lScore.Location = new Point(7, 227);
            lScore.Name = "lScore";
            lScore.Size = new Size(192, 37);
            lScore.TabIndex = 9;
            lScore.Text = "You're score:";
            // 
            // lAnswer
            // 
            lAnswer.AutoSize = true;
            lAnswer.BackColor = Color.Transparent;
            lAnswer.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lAnswer.ForeColor = Color.Black;
            lAnswer.Location = new Point(3, 37);
            lAnswer.Name = "lAnswer";
            lAnswer.Size = new Size(184, 28);
            lAnswer.TabIndex = 9;
            lAnswer.Text = "Answer be here...";
            // 
            // lPosition
            // 
            lPosition.AutoSize = true;
            lPosition.BackColor = Color.Transparent;
            lPosition.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lPosition.ForeColor = Color.White;
            lPosition.Location = new Point(7, 316);
            lPosition.Name = "lPosition";
            lPosition.Size = new Size(230, 37);
            lPosition.TabIndex = 14;
            lPosition.Text = "You're position:";
            // 
            // lGood
            // 
            lGood.AutoSize = true;
            lGood.BackColor = Color.Transparent;
            lGood.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lGood.ForeColor = Color.White;
            lGood.Location = new Point(305, 104);
            lGood.Name = "lGood";
            lGood.Size = new Size(212, 37);
            lGood.TabIndex = 15;
            lGood.Text = "You very good";
            // 
            // lVeryGoodYed
            // 
            lVeryGoodYed.AutoSize = true;
            lVeryGoodYed.BackColor = Color.Transparent;
            lVeryGoodYed.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lVeryGoodYed.ForeColor = Color.White;
            lVeryGoodYed.Location = new Point(395, 141);
            lVeryGoodYed.Name = "lVeryGoodYed";
            lVeryGoodYed.Size = new Size(39, 19);
            lVeryGoodYed.TabIndex = 16;
            lVeryGoodYed.Text = "Yes?";
            // 
            // AnswerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(lVeryGoodYed);
            Controls.Add(lGood);
            Controls.Add(lPosition);
            Controls.Add(lScore);
            Controls.Add(panel1);
            Name = "AnswerForm";
            Text = "AnswerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lCorrect;
        private Panel panel1;
        private Label lScore;
        private Label lAnswer;
        private Label lPosition;
        private Label lGood;
        private Label lVeryGoodYed;
    }
}