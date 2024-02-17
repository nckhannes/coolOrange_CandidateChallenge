using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    internal class TaskDriver
    {

        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task task1 = new Task("Doing Homework");
            Task task2 = new Task("Eating Lunch");
            Task task3 = new Task("Programming");

            task1.SetPriority(Task.Priority.MAX_PRIORITY);
            task2.SetPriority(Task.Priority.MIN_PRIORITY);
            

            task1.SetComplexity(8);
            task2.SetComplexity(2);
            task3.SetComplexity(5);

            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);

            tasks.Sort((x, y) => y.CompareTo(x));


            Console.WriteLine("TO-DO\n---------");
            foreach (Task task in tasks)
            {
                Console.WriteLine($"Name: {task.GetName()}, Priority: {task.GetPriority()}, Complexity: {task.GetComplexity()}");
            }
            Console.WriteLine(tasks[0].GetName() + " is one of the most important tasks");
        }
    }
}
