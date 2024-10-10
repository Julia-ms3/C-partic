using System;
using pr1.Interfaces;

namespace pr1.Tasks
{
    public class Task1 : ITask
    {
        public void StartTask()
        {
            Console.WriteLine("Введіть три цілі числа:");
            int[] numbers = GetNumbers(3);

            int lastDigit = 3; 
            int upperLimit = 10 + lastDigit;

            Console.WriteLine($"Числа в інтервалі [1, {upperLimit}]:");
            foreach (int num in numbers)
            {
                if (num >= 1 && num <= upperLimit)
                {
                    Console.WriteLine(num);
                }
            }
        }

        private int[] GetNumbers(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
    }
}