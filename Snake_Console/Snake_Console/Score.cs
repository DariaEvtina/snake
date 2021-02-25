using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    public class Score
    {
        private int scores;
        public int level;
        public int speed;
        public Score(int score, int level)
        {
            this.scores = score;
            this.level = level;
        }
        public void plusScore()
        {
            scores += 1;
        }
        public bool ScoreUp()
        {
            if (scores % 10 == 0)
            {
                level += 1;
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(70, 15);
            Console.WriteLine("Score:" + scores.ToString());
            Console.SetCursorPosition(70, 14);
            Console.WriteLine("Level:" + level.ToString());
        }
    }
}
