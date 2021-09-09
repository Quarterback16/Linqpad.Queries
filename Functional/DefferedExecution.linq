<Query Kind="Program" />

void Main()
{
	DefferedExecution();
}

public static void DefferedExecution()
{
	List<Member> memberList = new List<Member>
	{
		new Member
		{
			ID = 1,
			Name = "Eddie Morgan",
			Gender = "Male",
			MemberSince = new DateTime(2016, 2, 10)
		},
		new Member
		{
			ID = 2,
			Name = "Millie Duncan",
			Gender = "Female",
			MemberSince = new DateTime(2015, 4, 3)
		},
		new Member
		{
			ID = 3,
			Name = "Thiago Hubbard",
			Gender = "Male",
			MemberSince = new DateTime(2014, 1, 8)
		},
		new Member
		{
			ID = 4,
			Name = "Emilia Shaw",
			Gender = "Female",
			MemberSince = new DateTime(2015, 11, 15)
		}};
	
	IEnumerable<Member> memberQuery =
		from m in memberList
		where m.MemberSince.Year > 2014
		orderby m.Name
		select m;
	
	//  added AFTER the query is defined	
	memberList.Add(
		new Member
		{
			ID = 5,
			Name = "Chloe Day",
			Gender = "Female",
			MemberSince = new DateTime(2016, 5, 28)
		});
		
	foreach (Member m in memberQuery)
	{
		Console.WriteLine(m.Name);
	}
}


public class Member
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string Gender { get; set; }
	public DateTime MemberSince { get; set; }
}