using System;

namespace App.Con
{
    public static class StringExtensions
    {
        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }

        public static void Console(this string a)
        {
            System.Console.WriteLine(a);
        }
    }

    public static class IntExtensions
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }
    }

    public static class DateTimeExtensions
    {
        public static int Age(this DateTime d1)
        {
            var diff = DateTime.Now - d1;
            return (int)(diff.TotalDays / 365);
        }

        public static void Console(this DateTime d1)
        {
            System.Console.WriteLine(d1.ToString());
        }
    }
}