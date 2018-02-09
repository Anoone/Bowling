using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bowling
{
    public class BowlingGame
    {
        private List<int> _Throw = new List<int>(21);
        private int _CurrentThrow = 0;
        public BowlingGame()
        {
            for (int i = 0; i < 22; i++)
            {
                _Throw.Add(0);
            }
        }
        public void Throw(int pins)
        {
            _Throw[_CurrentThrow++] = pins;
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
                        score += 10 + _Throw[boxIndex + 1] + _Throw[boxIndex + 2];
                        boxIndex ++;
                    }
                    else if (Spare(boxIndex))
                    {
                        score += 10 + _Throw[boxIndex + 2];
                        boxIndex = boxIndex + 2;
                    }
                    else
                    {
                        score += _Throw[boxIndex] + _Throw [boxIndex +1];
                        boxIndex = boxIndex + 2;
                    }
                }
                return score;
            }          
        }
        private bool Strike(int boxIndex)
        {
            return _Throw[boxIndex] == 10;
        }
        private bool Spare (int boxIndex)
        {
            return _Throw[boxIndex] + _Throw[boxIndex + 1] == 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bowling game");
            Console.WriteLine("\nAdd your points\n");

            BowlingGame game = new BowlingGame();

            string Throw = Console.ReadLine();

            Console.WriteLine("pisteita tahan mennessa"+ game.Score);
        }
    }
}
