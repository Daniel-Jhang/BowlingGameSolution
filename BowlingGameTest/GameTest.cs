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
            int expected = 0; // ���浲�G��
            int actual; // ��ڵ��G��

            // Act
            RollMany(20, 0);
            actual = g.Score();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ���ժ��a��y 20 ���A�C�����u�o 1 ���ɪ��`�o��
        /// </summary>
        [TestMethod]
        public void TestAllOnes()
        {
            int expected = 20;
            int actual;

            RollMany(20, 1);
            actual = g.Score();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ���ժ��a�㧽�u�� 1 ���ɤ�(Spare)���`�o��(�@ 20 ����y���|�A��l 17 ���� 0 ��)
        /// 1st 5/5(Spare)�A2nd 3/0�A��l�Ҭ~��
        /// 5 + 5 = 10 (1st)
        /// 10 + 3 = 13 (Spare Bouns)
        /// 13 + 3 + 0 = 16 (2nd)
        /// </summary>
        [TestMethod]
        public void TestOneSpare()
        {
            int expected = 16;
            int actual;

            RollSpare();
            g.Roll(3);
            RollMany(17, 0);
            actual = g.Score();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ���ժ��a�㧽�u�� 1 ������(Strike)���`�o��(�@ 20 ����y���|�A��l 16 ���� 0 ��)
        /// 1st 10/0����(Strike)�A2nd 3/4�A��l�Ҭ~��
        /// ����(Strike) (1st)
        /// 10 + 3 + 4 = 17 (Strike Bouns)
        /// 17 + 3 + 4 = 24 (2nd)
        /// </summary>
        [TestMethod]
        public void TestOneStrike()
        {
            int excepted = 24;
            int actual;

            RollStrike(); // ����(Strike)
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            actual = g.Score();

            Assert.AreEqual(excepted, actual);
        }

        /// <summary>
        /// ���ժ��a�C�������˪��o���� (���� 300 ��)
        /// </summary>
        [TestMethod]
        public void TestPerfectGame()
        {
            int expected = 300;
            int actual;

            RollMany(12, 10);
            actual = g.Score();

            Assert.AreEqual(expected, actual);
        }
        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void RollStrike()
        {
            g.Roll(10);
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