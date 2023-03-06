namespace testunit1;
using tictactoe;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestGameCurrentPlayer()
    {
        Class game = new Class();

        int expectedPlayer = 1;
        int actualPlayer = game.getCurrentPlayer();

        Assert.AreEqual(expectedPlayer, actualPlayer);
    }
    
}