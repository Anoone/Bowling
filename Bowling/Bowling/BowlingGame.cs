using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        private List<int> _rolls = new List<int>(21);
        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }
        public int Score
        {
            get
            {
                int score = 0;
                int boxIndex = 0;
                for (int box = 0; box < 10; box++)
                {
                    if (Spare(boxIndex))
                    {
                        score += 10 + _rolls[boxIndex + 2];
                        boxIndex += 2;
                    }
                    else
                    {
                        score += _rolls[boxIndex] + _rolls [boxIndex +1];
                        boxIndex += 2;
                    }
                }
                return score;
            }          
        }
        private bool Spare (int boxIndex)
        {
            return _rolls[boxIndex] + _rolls[boxIndex + 1] == 10;
        }
        static void Main(string[] args)
        {
        }
    }
}
