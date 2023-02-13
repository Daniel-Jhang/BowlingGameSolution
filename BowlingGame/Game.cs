namespace BowlingGame
{
    public class Game
    {
        private int totalScore;

        public void Roll(int pins) // 投球
        {
            totalScore += pins;
        }

        public int Score() // 計分
        {
            return totalScore;
        }
    }
}