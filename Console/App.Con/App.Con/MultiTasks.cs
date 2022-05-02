using System;
using System.Threading;
using System.Threading.Tasks;

namespace App.Con
{
    public class MultiTasks
    {
        public async void Run()
        {
            //Thread t1 = new Thread(FunctionOne);
            //Thread t2 = new Thread(FunctionTwo);
            //t1.Start();
            //t2.Start();

            //Task<int> ts1 = new Task<int>(FunctionOne);
            //Task<string> ts2 = new Task<string>(FunctionTwo);
            //ts1.Start();
            //ts2.Start();
            //Console.WriteLine(ts2.Result);
            //Console.WriteLine(ts1.Result);

            var res1 = TaskOne();
            var res2 = TaskTwo();
            var res3 = TaskThree();

            Task.Run(() =>
            {
                Console.WriteLine(res1.Result);
            });
            Task.Run(() =>
            {
                Console.WriteLine(res2.Result);
            });
            Task.Run(() =>
            {
                Console.WriteLine(res3.Result);
            });
        }

        public int FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine($"Function One says => {i}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return 1;
        }

        public string FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"Function Two says => {i}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return "Function 2 ends";
        }

        public async Task<int> TaskOne()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine($"Task One says => {i}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return 1;
        }

        public async Task<string> TaskTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1500);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"Task Two says => {i}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return "Ends";
        }

        public async Task<string> TaskThree()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1900);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine($"Task Three says => {i}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return "Three Ends";
        }
    }
}