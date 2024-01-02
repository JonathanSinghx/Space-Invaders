using SpaceInvaders;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvadersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void givenSpaceInvaders_whenLoadAliensrun_thenAliensAreCreated()
        {

            // Arrange
            Game game = new Game();

            // Act
            game.Load_aliens();

            // Assert
            Assert.AreEqual(4, game.alienSpeed);
        
        }
    }

    public class PlayerCollisionTest
    {
        public static void Main()
        {
            // Create a player object for testing
            Player player = new Player(3); // Assuming 3 hit points/
            player.SpriteBox.Bounds = new Rectangle(100, 100, Player.DEFAULT_WIDTH, 46); // Set player's position and size

            // Create a PictureBox for simulating alien
            PictureBox alien = new PictureBox();
            alien.Bounds = new Rectangle(100, 100, 50, 50); // alien's position and size

            // Test when the alien and player collide
            alien.Visible = true;
            bool collisionResult = player.IsColliding(alien);
            Console.WriteLine("Collision when alien is visible: " + collisionResult); // Should be true

            // Test when the alien and player don't collide
            alien.Visible = false;
            collisionResult = player.IsColliding(alien);
            Console.WriteLine("Collision when alien is not visible: " + collisionResult); // Should be false
        }
    }
}