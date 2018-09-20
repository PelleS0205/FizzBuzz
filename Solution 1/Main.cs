using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		// One-liner ... if your client is mean, you can do this (Don't tell your boss).
		// If you have the time, change '100' to '100000', then check result just to make sure code is correct.
		Enumerable.Range(1, 100).Select((r) => r % 3 == 0 && r % 5 == 0 ? "FizzBuzz" : r % 3 == 0 ? "Fizz" : r % 5 == 0 ? "Buzz" : r.ToString()).ToList().ForEach((res) => Console.WriteLine(res));
	}
}
