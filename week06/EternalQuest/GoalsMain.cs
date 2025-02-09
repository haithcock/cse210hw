using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class GoalsMain
    {
        public List<TaskBase> tasks = new List<TaskBase>();
        public int TotalScore { get; private set; }

        public void AddTask(TaskBase task)
        {
            tasks.Add(task);
        }

        public void CompleteTask(int taskIndex)
        {
            if (taskIndex >= 0 && taskIndex < tasks.Count)
            {
                TaskBase task = tasks[taskIndex];
                task.Complete();
                TotalScore += task.Points; // Assumes TaskBase has a Points property
                Console.WriteLine($"Completed: {task.Description}. Points earned: {task.Points}");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }

        public void DisplayTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Display()}");
            }
        }
    }
}
