using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListConsole_app
{
    class Program
    {
       
        static void Main(string[] args)
        {
             List<TaskList> taskLists = new List<TaskList>();
            int choice = 0;
            while(choice!=5)
            {
                Console.WriteLine("Enter your Choice:");
                Console.WriteLine("1.Display Tasks\n2.Add Task\n3.Edit Task\nDelete Task\n5.exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        foreach(var t in taskLists)
                        {
                            Console.WriteLine("ID: " + t.ID + "\nTask: " + t.Task + "\nDateTime: " + t.DateTime + "\nStatus: " + t.Status);
                        }
                        break;
                    case 2:
                        TaskList temp = new TaskList();
                        Console.WriteLine("Enter the id:");
                        temp.ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the task: ");
                        temp.Task = Console.ReadLine();
                        Console.WriteLine("Enter Status:\n1.Done\n2.Undone");
                        if (int.Parse(Console.ReadLine()) == 1)
                            temp.Status = TaskListStatus.DONE;
                        temp.Status = TaskListStatus.UNDONE;
                        temp.DateTime = DateTime.Now;
                        taskLists.Add(temp);
                        break;
                    case 3:
                        Console.WriteLine("Enter the ID you want to modify:");
                        int tid = int.Parse(Console.ReadLine());
                        foreach(var t in taskLists)
                        {
                            if(t.ID==tid)
                            {
                                Console.WriteLine("Enter the id:");
                                t.ID = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the task: ");
                                t.Task = Console.ReadLine();
                                Console.WriteLine("Enter Status:\n1.Done\n2.Undone");
                                if (int.Parse(Console.ReadLine()) == 1)
                                    t.Status = TaskListStatus.DONE;
                                t.Status = TaskListStatus.UNDONE;
                                t.DateTime = DateTime.Now;
                            }
                        }
                        break;
                }

            }
            Console.ReadKey();
            

        }
       

    }
    public enum TaskListStatus { DONE = 1, UNDONE }
}
