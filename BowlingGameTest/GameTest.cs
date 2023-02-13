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
            RollMany(20, 0);
            actual = g.Score();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 代刚產щ瞴 20 Ω–Ω常眔 1 だ
        /// </summary>
        [TestMethod]
        public void TestAllOnes()
        {
            int expected = 20;
            int actual = 0;

            RollMany(20, 1);
            actual = g.Score();

            Assert.AreEqual(expected, actual);
        }

        private void RollMany(int times, int pins)
        {
            for (int i = 0; i < times; i++)
            {
                g.Roll(pins);
            }
        }
    }
}