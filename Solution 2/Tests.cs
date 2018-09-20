using System;
using Core;

Namespace Tests
{
    public static class GameEngineTests
    {
	    public static void WelcomePlayer_ParametersValid_Welcomed()
	    {
		    GameEngine game = new GameEngine();
		    string actual = game.GetWelcomeMessage();
		    string expected = "Velkommen til FizzBuzz! Angi antall tall:";
		    TestManager.AssertIsTrue(actual == expected);
	    }

	    public static void SetCount_ParametersValid_Success()
	    {
		    GameEngine game = new GameEngine();
		    game.SetCount(5);
		    int actual = game.Count;
		    int expected = 5;
		    TestManager.AssertIsTrue(actual == expected);
	    }

	    public static void GetNextNumber_ParametersValid_ReturnedNext()
	    {
		    GameEngine game = new GameEngine();
		    game.SetCount(2);
		    int actual = game.GetNextNumber();
		    int actual2 = game.GetNextNumber();
		    int expected = 1;
		    int expected2 = 2;
		    TestManager.AssertIsTrue(actual == expected && actual2 == expected2);
	    }

	    public static void CheckIfFinished_ParametersValid_ReturnTrue()
	    {
		    GameEngine game = new GameEngine();
		    game.SetCount(2);
		    game.GetNextNumber();
		    game.GetNextNumber();
		    TestManager.AssertIsTrue(game.IsFinished());
	    }

	    public static void CheckAnswer_ParametersValid_ReturnTrue()
	    {
		    GameEngine game = new GameEngine();
		    game.SetCount(3);
		    game.GetNextNumber();
		    bool actual = game.IsCorrectAnswer("1");
		    game.GetNextNumber();
		    game.GetNextNumber();
		    bool actual2 = game.IsCorrectAnswer("Fizz");
		    bool expected = true;
		    bool expected2 = true;
		    TestManager.AssertIsTrue(actual == expected && actual2 == expected2);
	    }
    } 
}
