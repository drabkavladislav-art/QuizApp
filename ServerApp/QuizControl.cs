using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class QuizControl : UserControl
    {
        public QuizControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 60, 180);
        }

        private Form1 form;

        public QuizControl(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }

        private void QuizControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuesitionEdit(form));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuesitionEdit(form));
        }

        private void Q2_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuesitionEdit(form));
        }

        private void Q3_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuesitionEdit(form));
        }

        private void Q4_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuesitionEdit(form));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new StatusOfUsers(form));
        }
    }
}
