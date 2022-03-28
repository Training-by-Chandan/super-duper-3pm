using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Con
{
    public class Program
    {
        public static void Main()
        {
            //Basic();

            Console.ReadLine();
        }

        private static void Operators()
        {
            //arithmetic operators
            //+ ,-, *, /, %
        }

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