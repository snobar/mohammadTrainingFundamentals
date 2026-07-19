using System;
using System.Collections.Generic;
using System.Text;
using mohammadTrainingFundamentals.TaskManager;

namespace mohammadTrainingFundamentals.MainMenu
{

     class clsMainMenu
    {
        List<string> tasks = [];


        public void DrawScreenHeader(string title, string subTitle = "")
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
        public void Start() 
        {

            while (true)
            {
                clsTaskManager Task = new clsTaskManager();


                ShowMainMenu();

                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task. ShowTasks(tasks);
                        break;

                    case "2":
                        Task. AddTask(tasks);
                        break;

                    case "3":
                        Task. DeleteTask(tasks);
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
        internal void ShowTasksWithoutPause(List<string> tasks)
        {
            Console.WriteLine();

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        internal void Pause()
        {
            Console.WriteLine();
            Console.Write("Press Any Key To Continue...");
            Console.ReadKey();
        }

    }
}

