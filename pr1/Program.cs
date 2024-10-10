// See https://aka.ms/new-console-template for more information

using System;
using pr1.Interfaces;
using pr1.Tasks;

class Program
{
    static void Main()
    {
        ITask[] tasks = new ITask[]
        {
            new Task1(),
            new Task2(),
            new Task3(),
            new Task4()
        };

        foreach (var task in tasks)
        {
            task.StartTask();
        }
    }
}
