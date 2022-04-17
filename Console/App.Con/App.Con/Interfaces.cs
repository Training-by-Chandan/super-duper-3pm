using System;

namespace App.Con
{
    //we have different types of shapes circle, rectangle, square
    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IShape : IArea, IPerimeter
    {
        void GetInput();
    }

    public class Square : IShape
    {
        private double Length { get; set; }

        public void GetInput()
        {
            Console.WriteLine("For Square");
            System.Console.WriteLine("Enter the length");
            Length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            var area = Math.Pow(Length, 2);
            Console.WriteLine($"Area of Square is {area}");
        }

        public void Perimeter()
        {
            var perimeter = 4 * Length;
            Console.WriteLine($"Perimeter of Square is {perimeter}");
        }
    }

    public class Rectangle : IShape
    {
        private double Length { get; set; }
        private double Breadth { get; set; }

        public void GetInput()
        {
            Console.WriteLine("For Rectangle");
            Console.WriteLine("Enter the length");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            var area = Length * Breadth;
            Console.WriteLine($"Area of Rectangle is {area}");
        }

        public void Perimeter()
        {
            var perimeter = 2 * (Length + Breadth);
            Console.WriteLine($"Perimeter of rectangle is {perimeter}");
        }
    }

    public class Circle : IShape
    {
        private double Radius { get; set; }

        public void GetInput()
        {
            Console.WriteLine("For Circle");
            System.Console.WriteLine("Enter the Radius");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            var area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Area of Circle is {area}");
        }

        public void Perimeter()
        {
            var perimeter = 2 * Math.PI * Radius;
            Console.WriteLine($"Perimeter of Circle is {perimeter}");
        }
    }

    public class Triangle : IShape
    {
        public void Area()
        {
            throw new NotImplementedException();
        }

        public void GetInput()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}