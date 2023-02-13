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
            RollMany(20, 0);
            actual = g.Score();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ���ժ��a��y 20 ���A�C�����u�o 1 ��
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