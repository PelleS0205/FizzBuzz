using System;

namespace Core
{
	public class ErrorHandler
	{
		public enum ErrorType
		{
			InvalidInput,
			Undefined
		}

		public void DisplayErrorMessage(ErrorType type)
		{
			switch (type)
			{
				case ErrorType.InvalidInput:
					Console.WriteLine("Ugyldig input");
					break;
				default:
					break;
			}
		}
	}
}
