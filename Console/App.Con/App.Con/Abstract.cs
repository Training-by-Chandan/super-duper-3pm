using System;

namespace App.Con
{
    public abstract class ShapeAbs
    {
        protected double area { get; set; }
        protected double perimeter { get; set; }
        protected string shapeName { get; set; }

        public void Area()
        {
            System.Console.WriteLine($"Area of {shapeName} is {area}");
        }

        public void Perimeter()
        {
            System.Console.WriteLine($"Perimeter of {shapeName} is {perimeter}");
        }

        public void GetInputAndCalculate()
        {
            GetInput();
            Calculate();
            //code to add the lodic to store the content in db/files/console etc
        }

        protected abstract void GetInput();

        protected abstract void Calculate();
    }

    public class SquareAbs : ShapeAbs
    {
        private double length;

        public SquareAbs()
        {
            shapeName = "square";
        }

        protected override void GetInput()
        {
            System.Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
        }

        protected override void Calculate()
        {
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        private double length;
        private double breadth;

        public RectangleAbs()
        {
            shapeName = "rectangle";
        }

        protected override void GetInput()
        {
            System.Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter the Breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        protected override void Calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }
}