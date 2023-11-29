using Microsoft.VisualBasic;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<String> list = new List<string>(); //list for store tasks
        while(true) 
        {
            Console.WriteLine("Task List Application");
            Console.WriteLine("1. Create Task");
            Console.WriteLine("2. Read Task");
            Console.WriteLine("3. Update Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");

            Console.Write("Please enter your choice : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please add your task : ");
                    string str = Console.ReadLine();
                    list.Add(str);
                    Console.WriteLine("Task Added Successfully!!!!");
                    break;
                case 2:
                    Console.WriteLine("-----------------------------");
                    int i = 1;
                    Console.WriteLine("List of Tasks");
                    foreach (string s in list)
                    {
                        Console.WriteLine($"{i}. {s}");
                        i++;
                    }
                    Console.WriteLine("-----------------------------");
                    break;
                case 3:
                    Console.Write("Please enter number of task which you want to update : ");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num <= list.Count)
                    {
                        int num1 = num - 1;
                        Console.WriteLine("Please Add Task");
                        string s1 = Console.ReadLine();
                        list[num1] = s1;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid number between 1 to {list.Count}");
                    }
                    Console.WriteLine("Task Updated Successfully");
                    break;
                case 4:
                    Console.Write("Please enter a number of task which you want to delete : ");
                    int num2 = int.Parse(Console.ReadLine());
                    int num3 = num2 - 1;
                    if(list.Count==0)
                    {
                        Console.WriteLine("No task is added please add task");
                    }
                    else if (num2 > 0 && num2 <= list.Count)
                    {
                        list.RemoveAt(num3);
                        Console.WriteLine("Task Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid number from 1 to {list.Count}");
                    }
                    break;
                case 5:
                    Console.WriteLine("You are exit");
                    return;
                default:
                    Console.WriteLine("Please enter valid number between 1 to 5");
                     break;

            }
        }
    }
}
