using System;
using System.Collections.Generic;
using pr1.Interfaces;

namespace pr1.Tasks
{
    public class Task4 : ITask
    {
        public void StartTask()
        {
            int lastDigit = 3; 
            int size = 10 + lastDigit;

            int[] X = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                X[i] = rand.Next(-100, 101);
            }

            Console.WriteLine("Введіть число M:");
            int M = int.Parse(Console.ReadLine());

            List<int> Y = new List<int>();
            foreach (var item in X)
            {
                if (Math.Abs(item) > M)
                {
                    Y.Add(item);
                }
            }

            Console.WriteLine("Масив X:");
            Console.WriteLine(string.Join(", ", X));
            Console.WriteLine("Масив Y (елементи більше по модулю ніж M):");
            Console.WriteLine(string.Join(", ", Y));
        }
    }
}