<Query Kind="Program" />

void Main()
{
	JoinOperator();
}

public static void JoinOperator()
{
	Course hci = new Course
	{
		Title = "Human Computer Interaction",
		CreditHours = 3
	};
	Course iis = new Course
	{
		Title = "Information in Society",
		CreditHours = 2
	};
	Course modr = new Course
	{
		Title = "Management of Digital Records",
		CreditHours = 3
	};
	Course micd = new Course
	{
		Title = "Moving Image Collection Development",
		CreditHours = 2
	};
	Student carol = new Student
	{
		Name = "Carol Burks",
		CourseTaken = modr
	};
	Student river = new Student
	{
		Name = "River Downs",
		CourseTaken = micd
	};
	Student raylee = new Student
	{
		Name = "Raylee Price",
		CourseTaken = hci
	};
	Student jordan = new Student
	{
		Name = "Jordan Owen",
		CourseTaken = modr
	};
	Student denny = new Student
	{
		Name = "Denny Edwards",
		CourseTaken = hci
	};
	Student hayden = new Student
	{
		Name = "Hayden Winters",
		CourseTaken = iis
	};
	List<Course> courses = new List<Course>
	{
		hci,
		iis,
		modr,
		micd
	};
	List<Student> students = new List<Student>
	{
		carol,
		river,
		raylee,
		jordan,
		denny,
		hayden
	};
	
	var query = courses.Join(
		students,
		course => course,
		student => student.CourseTaken,
		(course, student) =>
		   new 
		   {
		   		StudentName = student.Name,
				CourseTaken = course.Title
		   });
		   
	foreach (var item in query)
	{
		Console.WriteLine(
			"{0} - {1}",
			item.StudentName,
			item.CourseTaken);
	}
}

public class Student
{
	public string Name { get; set; }
	public Course CourseTaken { get; set; }
}
public class Course
{
	public string Title { get; set; }
	public int CreditHours { get; set; }
}