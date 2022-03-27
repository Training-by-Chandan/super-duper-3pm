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

        private static void DataTypes()
        {
            //bool either true or false
            //char => single character a b c 1 @ #
            //string => collection of characters
            //int  => numbers withour decimal 10, -11 100 
            //uint => same as int but holds only positive numbers 
            //short => numbers same as int but less than size of int
            //ushort
            //long => same as int, holds a bigger numbers
            //ulong =>
            //float, single => floating point numbers, it contains decimal
            //double => same as float but holds big number
            //decimal => same as float but holds much more bigger number
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