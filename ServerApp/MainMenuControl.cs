using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ServerApp
{
    public partial class MainMenuControl : UserControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 60, 180);
        }

        private Form1 form;

        public MainMenuControl(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }

        private void MainMenuControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            form.ShowScreen(new QuizControl(form));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuizControl(form));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuizControl(form));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuizControl(form));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new QuizControl(form));
        }
    }
}
