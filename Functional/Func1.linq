<Query Kind="Program" />

//  a function variable can be assigned to an existing method inside a class by its name using a reference

delegate int DoubleAction(int input);

void Main()
{
	//  Func<T1, T2, T3, T4, ..., T16, TResult>
	
	Func<int, int> f = (x) => x +2;
	
	int i = f(1);
	Console.WriteLine(i);
	
	f = (x) => (2 * x) + 1;
	i = f(1);
	Console.WriteLine(i);
	
	DoubleAction da = Double;  //  set the delegate to point at the Double FN
	int doubledValue = da(2);
	Console.WriteLine($"delegate doubledValue {doubledValue}");
	
	Func<int,int> fda = x => x * 2;  //  lambda
	int fDoubledValue = fda(2);
	Console.WriteLine($"Func doubledValue {fDoubledValue}");

}

static int Double(int inp)
{
	return inp * 2;
}
