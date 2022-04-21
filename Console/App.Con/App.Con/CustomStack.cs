using System;

namespace App.Con
{
    public class CustomStack
    {
        public CustomStack()
        {
            container = new string[5];
        }

        public CustomStack(int newSize)
        {
            container = new string[newSize];
        }

        //1. Container (array)
        private string[] container;

        //2. Counter(int)
        private int counter = -1;

        //3. push function
        public void Push(string s)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = s;
            }
        }

        //4. pop function
        public void Pop()
        {
            if (counter >= 0)
            {
                container[counter] = null;
                counter--;
            }
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the stack are");
            for (int i = counter; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomStackInt
    {
        public CustomStackInt()
        {
            container = new int[5];
        }

        public CustomStackInt(int newSize)
        {
            container = new int[newSize];
        }

        //1. Container (array)
        private int[] container;

        //2. Counter(int)
        private int counter = -1;

        //3. push function
        public void Push(int s)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = s;
            }
        }

        //4. pop function
        public void Pop()
        {
            if (counter >= 0)
            {
                counter--;
            }
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the stack are");
            for (int i = counter; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomStackTemplated<T>
    {
        public CustomStackTemplated()
        {
            container = new T[5];
        }

        public CustomStackTemplated(int newSize)
        {
            container = new T[newSize];
        }

        //1. Container (array)
        private T[] container;

        //2. Counter(int)
        private int counter = -1;

        //3. push function
        public void Push(T s)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = s;
            }
        }

        //4. pop function
        public void Pop()
        {
            if (counter >= 0)
            {
                counter--;
            }
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the stack are");
            for (int i = counter; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomStackV2
    {
        //1. Container (array)
        private string[] container = new string[0];

        //3. push function
        public void Push(string s)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = s;
        }

        //4. pop function
        public void Pop()
        {
            if (container.Length > 1)
            {
                Array.Resize(ref container, container.Length - 1);
            }
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the stack are");
            for (int i = container.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomQueue
    {
        public CustomQueue()
        {
            container = new string[5];
        }

        public CustomQueue(int newSize)
        {
            container = new string[newSize];
        }

        //1. Container (array)
        private string[] container;

        //2. Counter(int)
        private int counter = -1;

        public void Enqueue(string s)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = s;
            }
        }

        public void Dequeue()
        {
            if (counter >= 0)
            {
                container[0] = String.Empty;
                if (counter >= 1)
                {
                    for (int i = 1; i <= counter; i++)
                    {
                        container[i - 1] = container[i];
                    }
                    container[counter] = String.Empty;
                }
                counter--;
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the Queue are");
            for (int i = counter; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomQueueV2
    {
        //1. Container (array)
        private string[] container = new string[0];

        public void Enqueue(string s)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = s;
        }

        public void Dequeue()
        {
            if (container.Length > 0)
            {
                container[0] = String.Empty;
                if (container.Length > 1)
                {
                    for (int i = 1; i < container.Length; i++)
                    {
                        container[i - 1] = container[i];
                    }
                    Array.Resize(ref container, container.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the Queue are");
            for (int i = container.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }
}