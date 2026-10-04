using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class StatusOfUsers : UserControl
    {
        public StatusOfUsers()
        {
            InitializeComponent();
        }
        private Form1 form;

        public StatusOfUsers(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new MainMenuControl(form));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.ShowScreen(new ControlGame(form));
        }
    }
}
