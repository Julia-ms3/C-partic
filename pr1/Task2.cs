using System;
using pr1.Interfaces;
using pr1.Models;

namespace pr1.Tasks
{
    public class Task2 : ITask
    {
        public void StartTask()
        {
            Console.WriteLine("Введіть три сторони трикутника:");

            double side1 = GetValidSide("Сторона 1:");
            double side2 = GetValidSide("Сторона 2:");
            double side3 = GetValidSide("Сторона 3:");

            try
            {
                Triangle triangle = new Triangle(side1, side2, side3);
                Console.WriteLine($"Периметр: {triangle.Perimeter()}");
                Console.WriteLine($"Площа: {triangle.Area()}");
                Console.WriteLine($"Тип трикутника: {triangle.Type()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private double GetValidSide(string prompt)
        {
            double side;
            while (true)
            {
                Console.Write(prompt + " ");
                if (double.TryParse(Console.ReadLine(), out side) && side > 0)
                {
                    return side;
                }
                Console.WriteLine("Будь ласка, введіть дійсне додатнє число.");
            }
        }
    }
}