using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class GameTest
    {
        private Game g; // 宣告參考變數，指向 Game instance

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        /// <summary>
        /// 測試玩家投球 20 次，每次都洗溝(Gutter)
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