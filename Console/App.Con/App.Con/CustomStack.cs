using System;

namespace App.Con
{
    public class CustomStack
    {
        public CustomStack()
        {
            container = new string[5];
        }
        public CustomStack( int newSize)
        {
            container=new string[newSize];
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

    public class CustomStackV2
    {
       
        //1. Container (array)
        private string[] container=new string[0];

    

        //3. push function
        public void Push(string s)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length-1] = s;
        }

        //4. pop function
        public void Pop()
        {
            if (container.Length>1)
            {
                Array.Resize(ref container, container.Length - 1);
            }
 
        }

        public void DisplayAll()
        {
            System.Console.WriteLine("Item in the stack are");
            for (int i = container.Length-1; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

   
}