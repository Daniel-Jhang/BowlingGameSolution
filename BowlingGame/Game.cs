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
                if (isSpare(frameIndex)) // Spare
                {
                    totalSocre += (rolls[frameIndex] + rolls[frameIndex + 1] + rolls[frameIndex + 2]);
                    frameIndex += 2;
                }
                else
                {
                    totalSocre += rolls[frameIndex] + rolls[frameIndex + 1];
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
    }
}