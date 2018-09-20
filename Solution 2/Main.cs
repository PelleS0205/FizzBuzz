using System;
using Core;

public class Program
{
	public static void Main()
	{
		// Uncomment to run full test suite
		// TestManager.RunAll();
		
		ErrorHandler errorHandler = new ErrorHandler();
		GameEngine game = new GameEngine();
		Console.WriteLine(game.GetWelcomeMessage());
		
		// How many numbers does the player want?
		int count = 0;
		bool parsed = int.TryParse(Console.ReadLine(), out count);
		if (!parsed)
		{
			// Only allow numbers, and keep them beneath int.MaxValue
			errorHandler.DisplayErrorMessage(ErrorHandler.ErrorType.InvalidInput);
			return;
		}
		game.SetCount(count);
		
		// Get things rolling
		string answer = string.Empty;
		while (!game.IsFinished())
		{
			Console.WriteLine(game.GetNextNumber());
			answer = Console.ReadLine();
			if (!game.IsCorrectAnswer(answer))
			{
				Console.WriteLine("Du tapte :(");
				return;
			}
		}

		// All numbers answered correctly
		Console.WriteLine("Du vant :)");
	}
}
