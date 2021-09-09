<Query Kind="Program" />

void Main()
{
	CreateAndRaiseEvent();
}

private static void CreateAndRaiseEvent2()
{
	EventClassWithEvent ev = new EventClassWithEvent();
	ev.OnChange += () => Console.WriteLine("1st: Event raised");
	ev.OnChange += () => Console.WriteLine("2nd: Event raised");
	ev.OnChange += () => Console.WriteLine("3rd: Event raised");
	// ev.OnChange();  //  this becomes a vcompiler error
	ev.OnChange += () => Console.WriteLine("4th: Event raised");
	ev.OnChange += () => Console.WriteLine("5th: Event raised");
	ev.Raise();
}

public class EventClassWithEvent
{
	//  property has changed to a field
	public event Action OnChange = () => {};

	public void Raise()
	{
		OnChange();
	}
}

private static void CreateAndRaiseEvent()
{
	EventClassWithoutEvent ev = new EventClassWithoutEvent();
	ev.OnChange += () => Console.WriteLine("1st: Event raised");
	ev.OnChange += () => Console.WriteLine("2nd: Event raised");
	ev.OnChange += () => Console.WriteLine("3rd: Event raised");
	ev.OnChange += () => Console.WriteLine("4th: Event raised");
	ev.OnChange += () => Console.WriteLine("5th: Event raised");
	ev.Raise();
}

public class EventClassWithoutEvent
{
	public Action OnChange { get; set; }
	
	public void Raise()
	{
		if (OnChange != null)
		{
			OnChange();
		}
	}
}