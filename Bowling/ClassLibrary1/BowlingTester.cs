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

        public void RollAll(BowlingGame game,int AmountOfThrows,int PinsHitOnThrow)
        {
            for (int i = 0; i < AmountOfThrows; i++)
            {
                game.Roll(PinsHitOnThrow);
            }

        }
        [Test]
        public void EveryThrowInTheGutterAndScoreZero()
        {
            RollAll(game, 20, 0);
            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void GettinOnePinOnEveryThrow()
        {
            RollAll(game, 20, 1);
            Assert.AreEqual(20, game.Score);
        }

        [Test]
        public void ThrowingOneSpare()
        {
            game.Roll(3);
            game.Roll(7);
            game.Roll(6);
            RollAll(game, 20, 0);
            Assert.AreEqual(22, game.Score);
        }
    }
}
