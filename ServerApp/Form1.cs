namespace ServerApp
{
    public partial class Form1 : Form
    {
        //here
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 60, 180);
            ShowScreen(new MainMenuControl(this));
        }

        public void ShowScreen(UserControl screen)
        {
            PanelMain.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            PanelMain.Controls.Add(screen);
        }





    }
}
