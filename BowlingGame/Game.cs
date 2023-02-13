namespace BowlingGame
{
    public class Game
    {
        private int[] rolls = new int[20];
        private int currentRoll = 0;

        public void Roll(int pins) // 投球
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int Score() // 計分
        {
            int totalSocre = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex)) // Strike
                {
                    totalSocre += rolls[frameIndex] + StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex)) // Spare
                {
                    totalSocre += rolls[frameIndex] + rolls[frameIndex + 1] + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    totalSocre += SumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return totalSocre;
        }

        /// <summary>
        /// 判斷是否為補中(Spare)
        /// </summary>
        /// <param name="frameIndex">目前局數</param>
        /// <returns>True 代表補中，反之為 False</returns>
        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        /// <summary>
        /// 判斷是否為全倒(Strike)
        /// </summary>
        /// <param name="frameIndex">目前局數</param>
        /// <returns>True 代表全倒，反之為 False</returns>
        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        private int StrikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int SumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }
    }
}