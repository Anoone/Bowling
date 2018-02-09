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
        private int _CurrentRoll = 0;

        public BowlingGame()
        {
            for (int i = 0; i < 22; i++)
            {
                _rolls.Add(0);
            }
        }
        public void Roll(int pins)
        {
            _rolls[_CurrentRoll++] = pins;
        }
        public int Score
        {
            get
            {
                int score = 0;
                int boxIndex = 0;
                for (int box = 0; box < 10; box++)
                {
                    if (Strike(boxIndex))
                    {
                        score += 10 + _rolls[boxIndex + 1] + _rolls[boxIndex + 2];
                        boxIndex ++;
                    }
                    else if (Spare(boxIndex))
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
        private bool Strike(int boxIndex)
        {
            return _rolls[boxIndex] == 10;
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
