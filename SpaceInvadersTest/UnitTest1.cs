using SpaceInvaders;
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
}