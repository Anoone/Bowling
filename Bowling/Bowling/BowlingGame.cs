using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        public BowlingGame()
        {
            Score = 0; 
        }
        public double Score { get; set; }

            public void Roll(int pins)
            {
            Score += pins;
            }

        static void Main(string[] args)
        {
        }

    }
}
