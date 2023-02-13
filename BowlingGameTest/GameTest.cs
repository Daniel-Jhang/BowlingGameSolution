using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class GameTest
    {
        private Game g; // 把σ跑计 Game instance

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        /// <summary>
        /// 代刚產щ瞴 20 Ω–Ω常瑍肪(Gutter)
        /// </summary>
        [TestMethod]
        public void TestGutterGame()
        {
            // 3A Patten

            // Arrange
            int expected = 0;
            int actual;

            // Act
            for (int i = 0; i < 20; i++)
            {
                g.Roll(0);
            }
            actual = g.Score();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}