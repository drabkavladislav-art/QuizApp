using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class ControlGame : UserControl
    {
        public ControlGame()
        {
            InitializeComponent();
        }
        private Form1 form;

        public ControlGame(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }
        private void ControlGame_Load(object sender, EventArgs e)
        {

        }
    }
}
