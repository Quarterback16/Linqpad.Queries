<Query Kind="Program" />

void Main()
{
	GetFibonnacciNumbers(40);
}

private static void GetFibonnacciNumbers(
	int totalNumber)
{
	FibonacciNumbers fibNumbers = new FibonacciNumbers();
	foreach (Int64 number in fibNumbers.Take(totalNumber))
	{
		Console.Write(number);
		Console.Write("\t");
	}
	Console.WriteLine();
}

public class FibonacciNumbers  : IEnumerable<Int64>
{
	public IEnumerator<Int64> GetEnumerator()
	{
		return new FibEnumerator();
	}
	
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

public class FibEnumerator : IEnumerator<Int64>
{
	public Int64 Current { get; private set;}
	
	Int64 Last {get; set; }
	
	object IEnumerator.Current
	{
		get
		{
			return Current;
		}
	}
	
	public FibEnumerator()
	{
		Reset();	
	}
	
	public void Reset()
	{
		Current = -1;
	}
	
	public bool MoveNext()
	{
		if (Current == -1)
		{
			//  F0
			Current = 0;
		}
		else if (Current == 0)
		{
			//  F1
			Current = 1;
		}
		else
		{
			//  Fibonaci algortithm
			//  Fn = F(n-1) + F(n-2)
			Int64 next = Current + Last;
			Last = Current;
			Current = next;
		}
		//  it never ends so the result of MoveNext is always TRUE
		return true;
	}
	
	public void Dispose()
	{
		;  // do nothing
	}
	
}
