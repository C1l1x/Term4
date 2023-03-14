namespace TicTacToeTest;
using TicTacToe;
using System;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestGameCurrentPlayer()
    {
        TicTacToeGame game = new TicTacToeGame();

        int actualPlayer = game.getCurrentPlayer();

        Assert.AreEqual(TicTacToeGame.PLAYER_O, actualPlayer);
    }

    [TestMethod]
    public void TestGameNextPlayer_X()
    {
        TicTacToeGame game = new TicTacToeGame();

        game.play(1, 1);

        int actualPlayer = game.getCurrentPlayer();

        Assert.AreEqual(TicTacToeGame.PLAYER_X, actualPlayer);
    }

    [TestMethod]
    public void TestGameNextPlayer_O()
    {
        TicTacToeGame game = new TicTacToeGame();

        game.play(1, 2);
        game.play(2, 2);

        int actualPlayer = game.getCurrentPlayer();

        Assert.AreEqual(TicTacToeGame.PLAYER_O, actualPlayer);
    }
    [TestMethod]
    public void TestGameValidMove()
    {
        TicTacToeGame game = new TicTacToeGame();

        game.play(2, 1);
        game.play(0, 2);
        game.play(1, 2);
        game.play(2, 2);

        string actualGameStatus = game.getCurrentGameStatus();

        Assert.AreEqual(TicTacToeGame.WINNER_TEXT_NO_WINNER_YET, actualGameStatus);
        
    }

    [TestMethod]
    public void TestGamePlayer_OWin()
    {
        TicTacToeGame game = new TicTacToeGame();

        game.play(0, 0);
        game.play(0, 2);
        game.play(1, 0);
        game.play(2, 2);
        game.play(2, 0);

        string actualGameStatus = game.getCurrentGameStatus();

        Assert.AreEqual(TicTacToeGame.WINNER_TEXT_X, actualGameStatus);
        
    }



}