using System;

namespace Core
{
    public class GameEngine
    {
	    private int _counter = 0;
	    public int Count
	    {
		    get;
		    private set;
	    }

	    public string GetWelcomeMessage()
	    {
		    return "Velkommen til FizzBuzz! Angi antall tall:";
	    }

	    public void SetCount(int count)
	    {
		    Count = count;
	    }

	    public bool IsFinished()
	    {
		    return _counter == Count;
	    }

	    public int GetNextNumber()
	    {
		    _counter++;
		    return _counter;
	    }

	    public bool IsCorrectAnswer(string answer)
	    {
    		string expected = 
				_counter % 3 == 0 && _counter % 5 == 0 
				? "fizzbuzz" 
				: _counter % 3 == 0 
				? "fizz" 
				: _counter % 5 == 0 
				? "buzz" : _counter
				.ToString();
			return answer.ToLower() == expected;
	    }
    }
}
