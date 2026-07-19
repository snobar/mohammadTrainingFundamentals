using System;
using System.Collections.Generic;
using System.Text;
using mohammadTrainingFundamentals.MainMenu;
namespace mohammadTrainingFundamentals.TaskManager
{

     class clsTaskManager
    {
        List<string> tasks = [];


        public void AddTask(List<string> tasks)
        {
            Console.Clear();
            clsMainMenu UseclsMainMenu = new clsMainMenu();



            UseclsMainMenu.DrawScreenHeader("Add New Task", "");

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

            UseclsMainMenu.Pause();
        }

        public void ShowTasks(List<string> tasks)
        {
            clsMainMenu UseclsMainMenu = new clsMainMenu();

            Console.Clear();

            UseclsMainMenu.DrawScreenHeader("Task List");

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

            UseclsMainMenu. Pause();
        }

        public void DeleteTask(List<string> tasks)
        {
            clsMainMenu UseclsMainMenu = new clsMainMenu();

            Console.Clear();

            UseclsMainMenu.DrawScreenHeader("Delete Task");

            if (tasks.Count == 0)
            {
                Console.WriteLine("No Tasks To Delete.");
                UseclsMainMenu. Pause();
                return;
            }

            UseclsMainMenu.ShowTasksWithoutPause(tasks);

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

            UseclsMainMenu.Pause();
        }

    }
}
