using System;
using System.Drawing;
using System.Windows.Forms;

namespace Games
{
    /// <summary>
    /// разработать игру «Угадай число».
    /// </summary>
    public partial class GuessTheNumber : BaseFormGame
    {

        int gameNumber, attempts;

        public GuessTheNumber()
        {
            SizeSettings();
            InitializeComponent();
            StartGame();
        }


        private void SizeSettings()
        {
            Size size = new Size(800, 625);
            this.MaximumSize = size;
            this.MinimumSize = size;
            this.ClientSize = size;
        }

        public override void StartGame()
        {
            attempts = 10;
            gameNumber = new Random().Next(1, 100);

            this.NameText.Text = "Guess the number from 1 to 100\n Good Luck :-)";
            UpdateCount();
            this.NumberView.Text = "";
            
        }

        public void Turn(int userNumber)
        {
            attempts -= 1;

            CheckEndGame(userNumber);
            UpdateNumber(userNumber);
            UpdateCount();
        }

        private void UpdateNumber(int userNumber) 
        {

            string update;
            if (userNumber > gameNumber)
            {
                update = $"X less than {userNumber}";
            }
            else
            {
                update = $"X is greater than {userNumber}";
            }
            this.NumberView.Text = update; 
        }
        private void UpdateCount() => this.CountView.Text = $"{attempts} attempts left";

        private void CheckEndGame(int i)
        {
            if (i == gameNumber)
            {
                new MessageWindow(this, "WIN").Show();
            }

            if(attempts == 0)
            {
                new MessageWindow(this, "LOSE").Show();
            }
        }

        private void SayButton_Click(object sender, EventArgs e)
        {
            new SayNumber(this).Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
