void Start()
{
    List<string> tasks = [];

    while (true)
    {

        ShowMainMenu();

        Console.Write("\nChoose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ShowTasks(tasks);
                break;

            case "2":
                AddTask(tasks);
                break;

            case "3":
                DeleteTask(tasks);
                break;

            case "4":
                Console.Clear();
                DrawScreenHeader("Thank You");
                Console.WriteLine("\t\t\t\t\tGood Bye...");
                Pause();
                return;

            default:
                Console.WriteLine("\nInvalid Choice!");
                Pause();
                break;
        }
    }
}
void DrawScreenHeader(string title, string subTitle = "")
{
    Console.WriteLine();
    Console.WriteLine("\t\t\t\t\t______________________________________");
    Console.WriteLine();
    Console.WriteLine($"\t\t\t\t\t  {title}");

    if (!string.IsNullOrWhiteSpace(subTitle))
        Console.WriteLine($"\t\t\t\t\t  {subTitle}");

    Console.WriteLine("\t\t\t\t\t______________________________________");
    Console.WriteLine();
}

void ShowMainMenu()
{
    Console.Clear();

    DrawScreenHeader("To Do List");

    Console.WriteLine("\t\t\t\t\t[1] Show Task List");
    Console.WriteLine("\t\t\t\t\t[2] Add New Task");
    Console.WriteLine("\t\t\t\t\t[3] Delete Task");
    Console.WriteLine("\t\t\t\t\t[4] Exit");
}

void AddTask(List<string> tasks)
{
    Console.Clear();

    DrawScreenHeader("Add New Task");

    Console.Write("Enter Task: ");
    string task = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(task))
    {
        tasks.Add(task);
        Console.WriteLine("\nTask Added Successfully.");
    }
    else
    {
        Console.WriteLine("\nTask cannot be empty.");
    }

    Pause();
}

void ShowTasks(List<string> tasks)
{
    Console.Clear();

    DrawScreenHeader("Task List");

    if (tasks.Count == 0)
    {
        Console.WriteLine("No Tasks Found.");
    }
    else
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    Pause();
}

void DeleteTask(List<string> tasks)
{
    Console.Clear();

    DrawScreenHeader("Delete Task");

    if (tasks.Count == 0)
    {
        Console.WriteLine("No Tasks To Delete.");
        Pause();
        return;
    }

    ShowTasksWithoutPause(tasks);

    Console.Write("\nEnter Task Number: ");

    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number >= 1 && number <= tasks.Count)
        {
            tasks.RemoveAt(number - 1);
            Console.WriteLine("\nTask Deleted Successfully.");
        }
        else
        {
            Console.WriteLine("\nInvalid Task Number.");
        }
    }
    else
    {
        Console.WriteLine("\nPlease Enter A Valid Number.");
    }

    Pause();
}

void ShowTasksWithoutPause(List<string> tasks)
{
    Console.WriteLine();

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}

void Pause()
{
    Console.WriteLine();
    Console.Write("Press Any Key To Continue...");
    Console.ReadKey();
}
Start();