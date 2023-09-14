namespace SpaceInvaders
{
    public partial class Game : Form
    {


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
    }
}