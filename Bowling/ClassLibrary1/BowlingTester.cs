using Bowling;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingTester
{
    [TestFixture]
    public class BowlingTester
    {
        BowlingGame game;

        [SetUp]
        public void TestSetUp()
        {
            game = new BowlingGame();
        }
        [Test]
        public void EveryThrowInTheGutterAndScoreZero()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void GettinOnePinOnEveryThrow()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.AreEqual(20, game.Score);
        }
    }
}
