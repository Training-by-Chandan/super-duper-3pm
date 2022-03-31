using System;

namespace App.Con
{
    public class HumanBeing
    {
        //1. Constructors
        //2. Destructor
        //3. Variables
        //4. Properties
        //5. Methods / Functions

        public void Eat()
        {
            Console.WriteLine($"{this.GetHashCode()} is eating");
        }

        public void DisplayIdentity()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}