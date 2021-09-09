<Query Kind="Program" />

void Main()
{
	var project = new Project
	{
		Name = "Activity Redevelopment",
		Areas = new List<Area>
		{
			new Area
			{
				Name = "CDP Integration",
				UserStories = new List<UserStory>
				{
					new UserStory
					{
						Name = "Create Attendances",
						Sections = new List<Section>
						{
							new Section
							{
								Name = "For Attendance Type Activity Placement",
								Tasks = new List<Task>
								{
									new Task
									{
										Name = "Create Attendance",
										EstimatedHours = 2,
										Completed = true
									},
									new Task
									{
										Name = "Update Attendance",
										EstimatedHours = 2,
										Completed = true
									},
									new Task
									{
										Name = "Delete Attendance",
										EstimatedHours = 2,
										Completed = true
									},
									new Task
									{
										Name = "Create Attendance Result",
										EstimatedHours = 2,
										Completed = true
									},
									new Task
									{
										Name = "Update Attendance Result",
										EstimatedHours = 2,
										Completed = true
									},
									new Task
									{
										Name = "Delete Attendance Result",
										EstimatedHours = 2,
										Completed = true
									},
									new Task
									{
										Name = "Create Partial Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Update Partial Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Delete Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
								}
							},
							new Section
							{
								Name = "For Attendance Type Job Plan Item",
								Tasks = new List<Task>
								{
									new Task
									{
										Name = "Create Attendance",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Update Attendance",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Delete Attendance",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Create Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Update Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Delete Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Create Partial Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Update Partial Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
									new Task
									{
										Name = "Delete Attendance Result",
										EstimatedHours = 2,
										Completed = false
									},
								}
							},
						}
					}
				}
			}
		}
	};
	project.Areas.Add( 
		new Area
		{
			Name = "Batches"
		});
	DisplayTaskList(project);
}

private void DisplayTaskList(
	Project project)
{
	Console.WriteLine($"=== Project: {project.Name} ===");
	foreach (var area in project.Areas)
	{
		DisplayArea(area);
	}
	Console.WriteLine();
}

private void DisplayArea(
	Area area)
{
	Console.WriteLine($"==== Area: {area.Name} ====");
	foreach (var story in area.UserStories)
	{
		DisplayUserStory(story);
	}
	Console.WriteLine();
}

private void DisplayUserStory(
	UserStory story)
{
	Console.WriteLine($"  1. User Story: {story.Number} {story.Name}");
	if (story.HasSections())
	{
		foreach (var section in story.Sections)
			DisplaySection(section);
		return;
	}
	foreach (var task in story.Tasks)
	{
		DisplayTask(task);
	}
	Console.WriteLine();
}

private void DisplayTask(
	Task task)
{
	Console.WriteLine($"      1. ({task.DoneIndicator()}) {task.EstimatedHoursOut()} : {task.Name}");
}

private void DisplaySection(
	Section section)
{
	Console.WriteLine($"    1. Section: {section.Name}");
	foreach (var task in section.Tasks)
	{
		DisplayTask(task);
	}
}

public class Project
{
	public string Name { get; set; }
	public List<Area> Areas { get; set; }
}

public class Area
{
	public string Name { get; set; }
	public List<UserStory> UserStories { get; set; }
}

public class UserStory
{
	public string Name { get; set; }
	public int Number { get; set; }
	public List<Task> Tasks { get; set; }
	public List<Section> Sections { get; set; }
	public string url { get; set; }
	public bool HasSections()
	{
		return Sections != null;
	}
}

public class Section
{
	public string Name { get; set; }
	public List<Task> Tasks { get; set; }
}

public class Task
{
	public string Name { get; set; }
	public int EstimatedHours { get; set; }
	public int ActualHours { get; set; }
	public bool Completed {get; set; }
	public string DoneIndicator()
	{
		return Completed ? "y" : "n";
	}
	public string EstimatedHoursOut()
	{
		return $"{EstimatedHours,3}";
	}
}