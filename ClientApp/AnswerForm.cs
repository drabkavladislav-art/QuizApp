using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }
        public AnswerForm(string correct, int score, int position) : this()
        {
            lScore.Text += $" {score}";
            lPosition.Text += $" {position}";
            lAnswer.Text = $"{correct}";
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.DialogResult = DialogResult.OK;
                }));
            }
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
