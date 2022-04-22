using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Con
{
    public class Program
    {
        public static void Main()
        {
            var res = "N";
            do
            {
                Console.Clear();
                //Basic();
                //ifElse();
                //Looping();
                //ArrayExample();
                //StructExample();
                //StringConcatenation();
                //ClassAndObjects();
                //ClassAndObjectsV2();
                //DateTimeFunction();
                //OperatorOverloadingExample();
                //OperatorOverloadingV2();
                //StaticAndNonStaticExample();
                //ExtensionFunctionExamples();
                //InheritanceExample();
                //InterfaceExample();
                //InterfaceExample2();
                //AbstractShapesExample();
                //CustomStackExample();
                //AbstractShapesExample();
                //AbstractCarExample();
                //CustomQueueImplementation();
                CustomQueueImplementationV2();

                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }

        private static void TemplatedExample()
        {
            var obj1 = new TemplatedClass<string, bool, Circle, Human>();
        }

        private static void TemplatedSTack()
        {
            var stack = new CustomStackTemplated<int>();
            stack.Push(12);
            stack.Push(23);
            var stack2 = new CustomStackTemplated<string>();
            stack2.Push("12");
            stack2.Push("23");
            var stack3 = new CustomStackTemplated<float>();
            stack3.Push(12.34f);
            stack3.Push(12.34f);
            var stack4 = new CustomStackTemplated<IShape>();
            stack4.Push(new Circle());
            stack4.Push(new Square());
            stack4.Push(new Rectangle());
        }

        private static void CustomQueueImplementationV2()
        {
            CustomQueueV2 cq = new CustomQueueV2();
            cq.Enqueue("53");
            cq.Enqueue("45");
            cq.Enqueue("65");
            cq.Enqueue("43");
            cq.Enqueue("67");
            cq.DisplayAll();

            cq.Dequeue();
            cq.Dequeue();
            cq.DisplayAll();

            cq.Enqueue("78");
            cq.Enqueue("56");
            cq.DisplayAll();

            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.Dequeue();
            cq.DisplayAll();
        }

        private static void CustomQueueImplementation()
        {
            CustomQueue cq = new CustomQueue();
            cq.Enqueue("53");
            cq.Enqueue("45");
            cq.Enqueue("65");
            cq.DisplayAll();

            cq.Dequeue();
            cq.Dequeue();
            cq.DisplayAll();

            cq.Enqueue("78");
            cq.Enqueue("56");
            cq.DisplayAll();
        }

        private static void AbstractCarExample()
        {
            Console.WriteLine("Enter your choice");
            var choice = Convert.ToInt32(Console.ReadLine());
            //var car = GetAbstractCar(choice);

            // car.DisplayCharacter();
        }

        private static void CustomStackExample()
        {
            CustomStack cs = new CustomStack();
            Console.WriteLine("After adding book 1, 2 and 3");
            cs.Push("Book 1");
            cs.Push("Book 2");
            cs.Push("Book 3");
            cs.DisplayAll();

            Console.WriteLine("After popping 2 times");
            cs.Pop();
            cs.Pop();
            cs.DisplayAll();

            Console.WriteLine("After adding book 4, 5, 6, 7, 8, 9, 10");
            cs.Push("Book 4");
            cs.Push("Book 5");
            cs.Push("Book 6");
            cs.Push("Book 7");
            cs.Push("Book 8");
            cs.Push("Book 9");
            cs.Push("Book 10");
            cs.DisplayAll();

            Console.WriteLine("After popping 10 times");
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.DisplayAll();
        }

        private static void AbstractShapesExample()
        {
            Console.WriteLine("Enter the choice");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = GetAbstractShape(choice);

            shape.GetInputAndCalculate();
            shape.Area();
            shape.Perimeter();
        }

        //factory method for getting the shape
        private static ShapeAbs GetAbstractShape(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new RectangleAbs();

                default:
                    return new SquareAbs();
            }
        }

        private static void InterfaceExample()
        {
            Console.WriteLine("Enter the choice");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = GetShape(choice);

            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }

        //factory method for getting the shape
        private static IShape GetShape(int choice)
        {
            IShape sh = new Rectangle();

            switch (choice)
            {
                case 1:
                    return new Rectangle();

                case 2:
                    return new Circle();

                case 3:
                    return new Triangle();

                default:
                    return new Square();
            }
        }

        public static void InterfaceExample2()
        {
            Console.WriteLine("Enter your car brand");
            var choice = Convert.ToInt32(Console.ReadLine());

            var cr = IdentifyCar(choice);

            cr.Model();
            cr.Speed();
        }

        private static ICar IdentifyCar(int c)
        {
            ICar ic = new BMW();

            switch (c)
            {
                case 1:
                    return new BMW();

                case 2:
                    return new Toyota();

                default:
                    return new Suzuki();
            }
        }

        private static void InheritanceExample()
        {
            LivingThings l1 = new LivingThings();
            LivingThings a1 = new Animal();
            LivingThings a2 = new Animal(12);
            l1.Eat();
            a1.Eat();

            LivingThings p1 = new Plant();
            p1.Eat();

            LivingThings h1 = new Human();
            h1.Eat();
        }

        private static void ExtensionFunctionExamples()
        {
            int x = 10;
            x = x.Add(5);
            string x1 = x.ToString();
            string a = "123";
            var i = a.ToInt();
            DateTime d1 = new DateTime(1958, 2, 10);
            Console.WriteLine($"Age is {d1.Age()} years old");
            a.Console();
            d1.ToString().Console();
            DateTimeExtensions.Console(d1);
            d1.Console();
            //var diff=DateTime.Now-d1 ;
            //var years = diff.TotalDays / 365;
        }

        private static void StaticAndNonStaticExample()
        {
            //StaticClass s1 = new StaticClass(); // We cannot create the object of static class nor we can declare the variable of type Static class
            NonStaticClass ns1 = new NonStaticClass();
            NonStaticClass ns2 = new NonStaticClass();
            NonStaticClass ns3 = new NonStaticClass();

            //StaticClass.Number = 10;
            //StaticClass.Function();

            //NonStaticClass.StaticFunction();
            //NonStaticClass.StaticNumber = 10;

            //ns1.Number = 10;

            ns1.Function();
            ns2.Function();
            ns3.Function();

            ns1.Function();
            ns2.Function();
            ns3.Function();
        }

        private static void OperatorOverloadingV2()
        {
            StudentInfo s1 = new StudentInfo("Samir", "", "Maharjan");
            s1.MathMarks = 40;
            s1.ScienceMarks = 40;
            s1.ComputereMarks = 40;
            StudentInfo s2 = new StudentInfo("Samir", "", "Maharjan");
            s2.MathMarks = 50;
            s2.ScienceMarks = 50;
            s2.ComputereMarks = 50;

            StudentInfo s3 = new StudentInfo("Samir", "", "Maharjan");
            s3.MathMarks = 50;
            s3.ScienceMarks = 50;
            s3.ComputereMarks = 50;

            StudentInfo s4 = new StudentInfo("Samir", "", "Maharjan");
            s4.MathMarks = 50;
            s4.ScienceMarks = 50;
            StudentInfo s5 = new StudentInfo("Samir", "", "Maharjan");
            s5.MathMarks = 50;
            s5.ScienceMarks = 50;
            Console.WriteLine(s1.ToString());
            Console.WriteLine();
            StudentInfo[] students = new StudentInfo[] { s1, s2, s3, s4, s5 };
            StudentInfo final = new StudentInfo();
            for (int i = 0; i < students.Length; i++)
            {
                final += students[i];
            }

            Console.WriteLine(final.ToString());

            s1 = s1 * 2;
            s1 = 2 * s1;
            s1 = s1 / 2;
        }

        private static void OperatorOverloadingExample()
        {
            StudentInfo s1 = new StudentInfo("Samir", "", "Maharjan");
            s1.MathMarks = 40;
            s1.ScienceMarks = 40;
            s1.ComputereMarks = 40;
            StudentInfo s2 = new StudentInfo("Samir", "", "Maharjan");
            s2.MathMarks = 50;
            s2.ScienceMarks = 50;
            s2.ComputereMarks = 50;

            StudentInfo s3 = new StudentInfo("Samir", "", "Maharjan");
            s3.MathMarks = 50;
            s3.ScienceMarks = 50;
            s3.ComputereMarks = 50;

            StudentInfo s4 = new StudentInfo("Samir", "", "Maharjan");
            s4.MathMarks = 50;
            s4.ScienceMarks = 50;
            StudentInfo s5 = new StudentInfo("Samir", "", "Maharjan");
            s5.MathMarks = 50;
            s5.ScienceMarks = 50;
            int i = 10;
            i = i + 5;
            int j = 6;
            int k = i + j;
            int l = i + 5;

            StudentInfo final = s1 + s2;
            s1 = s1 + 5;
            s1 = final - s2;
            Console.WriteLine(s2 == s3);
            Console.WriteLine(s1 < s2);
            Console.WriteLine(s1 >= s2);
            Console.WriteLine(s1 <= s3);

            i += 5; // i=i+5;

            var totalFullmarks = s1.FullMarks + s2.FullMarks + s3.FullMarks;
            var totalPassmarks = s1.PassMarks + s2.PassMarks + s3.PassMarks;
            StudentInfo sres = new StudentInfo(totalFullmarks, totalPassmarks, "Samir", "", "Maharjan");
            sres.MathMarks = s1.MathMarks + s2.MathMarks + s3.MathMarks;
            sres.ScienceMarks = s1.ScienceMarks + s2.ScienceMarks + s3.ScienceMarks;
            sres.ComputereMarks = s1.ComputereMarks + s2.ComputereMarks + s3.ComputereMarks;
        }

        private static void DateTimeFunction()
        {
            var date = new DateTime(2003, 1, 22);
            var timespan = (DateTime.Now - date).TotalDays;
            Console.WriteLine($"Age => {(int)(timespan / 365)}");
            //to get current datetime
            Console.WriteLine($"Nepal => {DateTime.Now}");
            Console.WriteLine($"Nepal => {DateTime.Now.ToString("yyyy, dd, MMMM hh:mm:ss")}");

            var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            Console.WriteLine($"Eastern Time Zone => {TimeZoneInfo.ConvertTime(DateTime.Now, est)}");

            Console.WriteLine($"Expiry date (1 year from now) : {DateTime.Now.AddYears(1)}");
        }

        private static void ClassAndObjectsV2()
        {
            StudentInfo s1 = new StudentInfo("Samir", "", "Maharjan");
            StudentInfo s2 = new StudentInfo("Sailesh", "Raj", "Aryal");

            s1.ScienceMarks = 00.56f;
            s1.MathMarks = 10.23f;
            Console.WriteLine($"{s1.FullName}\nScience Marks : {s1.ScienceMarks}\nMath Marks : {s1.MathMarks}\nTotal : {s1.Total}\nPercentage : {s1.Percentage}\nDivision : {s1.Division}");
            s1.ScienceMarks = 50;
            Console.WriteLine("\n\nAfter changign marks of science\n\n");
            Console.WriteLine($"{s1.FullName}\nScience Marks : {s1.ScienceMarks}\nMath Marks : {s1.MathMarks}\nTotal : {s1.Total}\nPercentage : {s1.Percentage}\nDivision : {s1.Division}");
            Console.WriteLine(s1.MathMarks);
            //Console.WriteLine(s1.FullName);
            //Console.WriteLine(s2.FullName);
        }

        private static void ClassAndObjects()
        {
            //Class : Blueprint / Designs / Specifications
            //Objects : Instance of Class

            HumanBeing samir = new HumanBeing("Samir");
            HumanBeing sailesh = new HumanBeing();

            Console.WriteLine(samir.FirstName);
            samir.FirstName = "Samir Maharjan";
            Console.WriteLine(samir.FirstName);

            Console.WriteLine(sailesh.FirstName);
            sailesh.FirstName = "Sailesh Aryal";
            Console.WriteLine(sailesh.FirstName);

            samir.DisplayIdentity();
            sailesh.DisplayIdentity();
            //samir.Eat();
            //sailesh.Eat();
            sailesh.SetName("Saiesh");
        }

        private static void StringConcatenation()
        {
            string name = "Sailesh";
            string address = "Ktm";
            string email = "Sailesh@gmail.com";

            //1. Basic
            Console.WriteLine("\n=====================\nUsing Basic Concatenation");
            string result1 = "Name = " + name + "\nAddress = " + address + " " + email;
            Console.WriteLine(result1);

            //2. String formatting
            Console.WriteLine("\n=====================\nUsing String formatting");
            string result2 = string.Format("Name = {0},\nAddress = {1},\nEmail = {2}", name, address, email);
            Console.WriteLine(result2);

            //3. String interpolation
            Console.WriteLine("\n=====================\nUsing String Interpolation");
            string result3 = $"Name = {name}\nAddress = {address}\nEmail = {email}";
            Console.WriteLine(result3);

            //4. String Builder
            Console.WriteLine("\n=====================\nUsing String Builder");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            Console.WriteLine(sb.ToString());
        }

        private static void StructExample()
        {
            StudentStruct s1 = new StudentStruct("Sailesh", "Ktm", "sailesh@gmail.com");
            StudentStruct s2 = new StudentStruct();
            Console.WriteLine(s1.Name + " => " + s1.Address + " => " + s1.Email);
            Console.WriteLine(s2.Name + " => " + s2.Address + " => " + s2.Email);
        }

        private static void ArrayExample()
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Holiday" };
            Console.WriteLine(string.Join(" & ", days));
            //Console.WriteLine(days.Length);
            //Array.Resize(ref days, 5);
            //Console.WriteLine(days.Length);

            //Array.Sort(days);
            //Array.Reverse(days);

            //Array.Clear(days,0,days.Length);
        }

        //looping
        private static void Looping()
        {
            //do while
            //infinite loop
            //int j = 0;
            //do
            //{
            //    j++;
            //} while (j <= 10);
            ////while
            //int i = 0;
            //while (i <= 10)
            //{
            //}
            ////for
            //for (int x = 0; x<5; x++)
            //{
            //}
            //for (int x = 0; x < 10;)
            //{
            //}
            //for (; ; )
            //{
            //}
            //foreach
            //string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Holiday" };
            //for (int x = 0; x < days.Length; x++)
            //{
            //    Console.WriteLine(days[x]);
            //}
            //foreach (var item in days)
            //{
            //    Console.WriteLine(item);
            //}

            //break and continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;

                Console.WriteLine(i);
            }
        }

        private static void SwitchCase()
        {
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                case 8:
                    Console.WriteLine("Noa a valid day");
                    break;

                default:
                    break;
            }

            switch (num)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Weekdays");
                    break;

                case 1:
                case 7:
                    Console.WriteLine("Weekends");
                    break;

                default:
                    break;
            }
        }

        //control statements
        private static void ifElse()
        {
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num == 1) Console.WriteLine("Sunday");
            else if (num == 2) Console.WriteLine("Monday");
            else if (num == 3) Console.WriteLine("Tuesday");
            else if (num == 4) Console.WriteLine("Wednesday");
            else if (num == 5) Console.WriteLine("Thursday");
            else if (num == 6) Console.WriteLine("Friday");
            else if (num == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Not a valid day");

            if (num == 2 || num == 3 || num == 4 || num == 5 || num == 6) Console.WriteLine("Weekdays");
            else if (num == 1 || num == 7) Console.WriteLine("Weekends");

            //ternary: value assign : (condition) ? <true value> : <false value>
            var days = num == 1 ? "Sunday" : num == 2 ? "Monday" : num == 3 ? "Tuesday" : num == 4 ? "Wednesday" : num == 5 ? "Thursday" : num == 6 ? "Friday" : num == 7 ? "Saturday" : "Not a valid day";
        }

        private static void Operators()
        {
            //arithmetic operators
            //+ ,-, *, /, %
        }

        private static void Arrays()
        {
            //collection of similar data types
            int[] i = new int[5];
            //index 0 to 4
            i[0] = 10;
            i[1] = 20;
            i[2] = 25;
            i[3] = 53;
            i[4] = 43;

            string[] str = new string[i[0]];

            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        }

        private const float pi = 3.1415f;

        private static void Casting()
        {
            //implicit / explicit / Type conversion class
            //char => int => long => float => double
            //implicit casting
            char c = 'C';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //Explicit casting
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;
            c = (char)d;

            //type comversion class Convert
            string s = "67";
            i = Convert.ToInt32(s);
            c = Convert.ToChar(s);
            i = int.Parse(s);
            int i1 = 10;
            int _2i = 20;
            //object type
            object o = 1234;
            i = Convert.ToInt32(o);

            var a = 10m;
            a = 9m;
            var b = "";

            object o1 = 10m;
            o1 = "";
            object o2 = "";
        }

        private static void DataTypes()
        {
            //bool either true or false
            //char => single character a b c 1 @ #
            //string => collection of characters

            //int  => signed int 32 bit
            //uint => unsigned int 32 bit
            //short => signed int 16bit
            //ushort => unsigned number 16 bit
            //long => signed int 64 bit
            //ulong =>unsigned int 64 bit

            //float, single => floating point numbers, it contains decimal
            //double => same as float but holds big number
            //decimal => same as float but holds much more bigger number
            ushort u = 65535; //16 bit
            uint ui = 4294967295; //32 bit
            ulong ul = 18446744073709551615; //64 bit
            short s = 32767;
            int i = 2147483647;
            long l = -9223372036854775808;
            string str = "test";
            char c = 'a';
            c = str[1];
        }

        private static void Basic()
        {
            Console.WriteLine("Enter any text");
            string str = Console.ReadLine();
            Console.WriteLine("You have pressed " + str);
            Console.Clear();
        }
    }
}