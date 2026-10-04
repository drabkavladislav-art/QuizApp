namespace ClientApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            string gameCode = "-";
            string playerName = "Player--";
            string question = "Question must be here...";
            string optionA = "optionA";
            string optionB = "optionB";
            string optionC = "optionC";
            string optionD = "optionD";
            string correct = "Correct answer must be here...";
            int score = -1;
            int position = -1;
            int seconds = 5;
            bool waitRoom = true;

            using (JoinForm joinForm = new())
            {
                if (joinForm.ShowDialog() == DialogResult.OK)
                {
                    gameCode = joinForm.GameCode;
                    playerName = joinForm.PlayerName;
                }
                else
                {
                    this.Close();
                    return;
                }
            }
            using (WaitForm waitForm = new(playerName))
            {
                waitForm.Show();          
                await Task.Delay(5000);  
                waitForm.Close();       
            }
            using (QuestionForm questionForm = new(question, seconds, optionA, optionB, optionC, optionD))
            {
                if (questionForm.ShowDialog() == DialogResult.OK)
                {
                    string playerChoice = questionForm.SelectedOption;
                    await Task.Delay(5000); // delete this
                    questionForm.SetEndStatus();
                    // logic be here
                }
                else
                {
                    this.Close();
                    return;
                }
            }
            using (AnswerForm answerForm = new(correct, score, position))
            {
                if (answerForm.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                    return;
                }
            }
            this.Close();
        }

    }
}
