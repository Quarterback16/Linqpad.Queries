<Query Kind="Program" />

void Main()
{
	TailCall(5);
}

public static void TailCall(
  int iTotalRecursion)
 {
 	Console.WriteLine(
		"Value: " + iTotalRecursion);
	if (iTotalRecursion == 0)
	{
		Console.WriteLine(
			"The tail is executed");
		return;
	}
	TailCall( iTotalRecursion - 1 );
 }