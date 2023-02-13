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
            int expected = 0; // 期望結果值
            int actual; // 實際結果值

            // Act
            RollMany(20, 0);
            actual = g.Score();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 測試玩家投球 20 次，每次都只得 1 分時的總得分
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
        /// 測試玩家整局只有 1 次補中(Spare)的總得分(共 20 次投球機會，其餘 17 次皆 0 分)
        /// 1st 5/5(Spare)，2nd 3/0，其餘皆洗溝
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

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
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