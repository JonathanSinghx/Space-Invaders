
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

        }


        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void playerBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isGamePaused)
            {
                button1.Text = "Pause";
                alienSpeed = 4;
            }
            else
            {
                button1.Text = "Play";
                alienSpeed = 0;

            }

            isGamePaused = !isGamePaused; //Toggle the game state
        }
    }
}