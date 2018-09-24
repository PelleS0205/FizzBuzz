using System;
using System.Diagnostics;
using Tests;

namespace Core
{
	public class TestManager
	{
		public static void AssertIsTrue(bool expression)
		{
			StackTrace stackTrace = new StackTrace();
			if (expression)
				Console.WriteLine("Test succeeded");
			else
				Console.WriteLine("Test failed: " + stackTrace.GetFrame(1).GetMethod().Name);
		}

		public static void AssertIsFalse(bool expression)
		{
			AssertIsTrue(!expression);
		}

		public static void RunAll()
		{
			GameEngineTests.WelcomePlayer_ParametersValid_Welcomed();
			GameEngineTests.SetCount_ParametersValid_Success();
			GameEngineTests.GetNextNumber_ParametersValid_ReturnedNext();
			GameEngineTests.CheckIfFinished_ParametersValid_ReturnTrue();
			GameEngineTests.CheckAnswer_ParametersValid_ReturnTrue();
			Console.WriteLine("All tests are done");
		}
	}
}
