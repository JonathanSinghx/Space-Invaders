namespace SpaceInvaders
{
    public partial class Game : Form
    {


        public Game()
        {
            InitializeComponent();
            initalizeGame();
            mainTimer.Start();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}