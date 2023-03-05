using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace university.Term4.testing_software.up1
{
    [TestClass]
    public class UnitTest1
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