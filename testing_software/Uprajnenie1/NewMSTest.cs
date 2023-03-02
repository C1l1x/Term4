using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace Uprajnenie1
{
    [TestClass]
    public class NewMSTest
    {
        [TestMethod]
        public void TestGameCurrentPlayer()
        {
            game game = new game();

            int expectedPlayer = 1;
            int actualPlayer = game.getCurrentPlayer();

            Assert.AreEqual(expectedPlayer, actualPlayer);
        }
    }
}