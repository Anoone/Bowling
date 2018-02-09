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
        public void ThrowAll(BowlingGame game,int Throws,int PinsHit)
        {
            for (int i = 0; i < Throws; i++)
            {
                game.Throw(PinsHit);
            }
        }
        [Test]
        public void ThrowBallAndHitOnePin()
        {
            game.Throw(1);

            Assert.AreEqual(1, game.Score);
        }
        [Test]
        public void GettinOnePinOnEveryThrow()
        {
            ThrowAll(game, 20, 1);
            Assert.AreEqual(20, game.Score);
        }
        [Test]
        public void ThrowingOneSpare()
        {
            game.Throw(3);
            game.Throw(7);
            game.Throw(6);
            ThrowAll(game, 17, 0);
            Assert.AreEqual(22, game.Score);
        }
        [Test]
        public void ThrowingOneStrike()
        {
            game.Throw(10);
            game.Throw(2);
            game.Throw(2);

            ThrowAll(game, 17, 0);
            Assert.AreEqual(18, game.Score);
        }
        [Test]
        public void StrikeAndSpare()
        {
            game.Throw(10);
            game.Throw(5);
            game.Throw(5);
            game.Throw(3);
            game.Throw(4);

            ThrowAll(game, 17, 0);

            Assert.AreEqual(40, game.Score);
        }
    }
}

