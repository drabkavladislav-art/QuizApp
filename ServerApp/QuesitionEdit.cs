using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class QuesitionEdit : UserControl
    {
        public QuesitionEdit()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 60, 180);
        }
        private Form1 form;

        public QuesitionEdit(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
