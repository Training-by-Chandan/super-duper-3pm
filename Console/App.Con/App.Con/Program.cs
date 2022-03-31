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
                ifElse();

                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }

        //looping
        private static void Looping()
        {
            //do while
            //infinite loop
            int j = 0;
            do
            {
                j++;
            } while (j <= 10);
            //while
            int i = 0;
            while (i <= 10)
            {
            }
            //for
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
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Holiday" };
            for (int x = 0; x < days.Length; x++)
            {
            }
            foreach (var item in days)
            {
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

        private static void Array()
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
<<<<<<< HEAD
            //int  => numbers withour decimal 10, -11 100 
            //uint => same as int but holds only positive numbers 
            //short => numbers same as int but less than size of int
            //ushort
            //long => same as int, holds a bigger numbers
            //ulong =>
=======
            //int  => signed int 32 bit
            //uint => unsigned int 32 bit
            //short => signed int 16bit
            //ushort => unsigned number 16 bit
            //long => signed int 64 bit
            //ulong =>unsigned int 64 bit
>>>>>>> 935510ac8e1f513a9fff2a7f9821c6104397e59b
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