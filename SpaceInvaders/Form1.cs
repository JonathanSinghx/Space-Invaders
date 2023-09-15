
namespace SpaceInvaders
{
    public partial class Game : Form
    {

        private bool isGamePaused = true;
        public Game()
        {
            InitializeComponent();
            initalizeGame();
            mainTimer.Start();
            Load_aliens();
            timer1.Start();
        }


        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void playerBox_Click(object sender, EventArgs e)
        {

        }

        //Initialize the game time to 0
        int gameTimeInSeconds = 0;

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //increment the game time by 1 second
            gameTimeInSeconds++;

            //Calculate minutes and seconds
            int minutes = gameTimeInSeconds / 60;
            int seconds = gameTimeInSeconds % 60;

            //Display time in format mm:ss
            label1.Text = $"Time: {minutes:D2}:{seconds:D2}";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isGamePaused)
            {
                timer1.Enabled = true;
                button1.Text = "Pause";
                alienSpeed = 4;
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Play";
                alienSpeed = 0;

            }

            isGamePaused = !isGamePaused; //Toggle the game state
        }


    }
}