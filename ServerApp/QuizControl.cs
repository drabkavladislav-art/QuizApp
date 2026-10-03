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
        }

        private Form1 form;

        public QuizControl(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }
    }
}
