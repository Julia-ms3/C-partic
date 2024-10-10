using System;
using pr1.Interfaces;

namespace pr1.Tasks
{
    public class Task3 : ITask
    {
        public void StartTask()
        {
            int lastDigit = 3; 
            int size = 10 + lastDigit;

            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-100, 101);
            }

            Console.WriteLine("Масив:");
            Console.WriteLine(string.Join(" ", array));

            var (min, max) = GetMinMax(array);
            Console.WriteLine("Мінімальне значення: {0}", min);
            Console.WriteLine("Максимальне значення: {0}", max);
        }

        private (int min, int max) GetMinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];

            foreach (var item in array)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }

            return (min, max);
        }
    }
}