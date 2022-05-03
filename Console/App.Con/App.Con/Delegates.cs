namespace App.Con
{
    public class Delegates
    {
        public delegate void MathOps(int a, int b);

        public void Run()
        {
            MathOps m = Add;
            m(10, 5);
            m += Subtract;
            m(10, 5);
            m += Multiply;
            m(10, 5);
            m += Divide;
            m(10, 5);
        }

        public void Add(int x, int y)
        {
            System.Console.WriteLine($"Sum is {x + y}");
        }

        public void Subtract(int a, int b)
        {
            System.Console.WriteLine($"Difference is {a - b}");
        }

        public void Multiply(int a, int b)
        {
            System.Console.WriteLine($"Product is {a * b}");
        }

        public void Divide(int a, int b)
        {
            System.Console.WriteLine($"Quotient is {a / b}");
        }
    }

    public class DelegatesV2
    {
        public delegate int MathOps(int a, int b);

        public event MathOps math;

        public void Run()
        {
            try
            {
                math(10, 4);
                math += Add;
                MathOps m = Add;
                var res = m(10, 5);
                m = Subtract;
                res = m(10, 5);
                m = Multiply;
                res = m(10, 5);
                m = Divide;
                res = m(10, 5);
                m = (int a, int b) =>
                {
                    return a + b;
                };
                math.Invoke(10, 5);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Error occured");
            }
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}