using System;

namespace pr1.Models
{
    public class Triangle
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("Сторони не можуть утворити трикутник.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double Perimeter() => side1 + side2 + side3;

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public string Type()
        {
            if (side1 == side2 && side2 == side3) return "Рівносторонній";
            if (side1 == side2 || side2 == side3 || side1 == side3) return "Рівнобедрений";
            return "Різносторонній";
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}