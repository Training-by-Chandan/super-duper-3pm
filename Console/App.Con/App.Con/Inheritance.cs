namespace App.Con
{
    //a class can be inherited by only one class

    public class LivingThings
    {
        //public private, protected
        public int PublicVariable = 10;

        private int _privateVariable = 10;
        protected int protectedVariable = 10;

        public LivingThings()
        {
        }

        public LivingThings(int i)
        {
        }

        //parent method virtual, override or abstract
        public virtual void Eat()
        {
            System.Console.WriteLine("Living things can eat");
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base()
        {
            protectedVariable = 20;
            PublicVariable = 40;
            //_privateVariable = 20;
        }

        public Animal(int i) : base(i)
        {
        }

        public override void Eat()
        {
            System.Console.WriteLine("Animal can eat");
        }
    }

    public class Plant : LivingThings
    {
        public Plant()
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("Plant can eat");
        }
    }

    public class Human : Animal
    {
        public Human()
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("Human can eat");
        }
    }
}