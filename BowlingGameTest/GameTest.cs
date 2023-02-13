using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class GameTest
    {
        private Game g; // �ŧi�Ѧ��ܼơA���V Game instance

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        /// <summary>
        /// ���ժ��a��y 20 ���A�C�����~��(Gutter)
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