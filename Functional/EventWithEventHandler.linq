<Query Kind="Program" />

void Main()
{
	CreateAndRaiseEvent();
}

private static void CreateAndRaiseEvent()
{
	EventClassWithEventHandler ev = new EventClassWithEventHandler();
	ev.OnChange += (sender, e) => Console.WriteLine(
		"Event raised with args: {0}", e.Value); 
	ev.Raise();
}

public class MyArgs : EventArgs
{
	public int Value { get; set; }		
	public MyArgs(int value)
	{
		Value = value;
	}
}

public class EventClassWithEventHandler
{
	public event EventHandler<MyArgs> OnChange = (sender, ef) => {};
	public void Raise()
	{
		OnChange(this, new MyArgs(100));
	}
}
