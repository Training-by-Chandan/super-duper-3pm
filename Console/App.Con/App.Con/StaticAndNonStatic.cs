namespace App.Con
{
    // if the class is static thn the whole members of the static class are also static
    public static class StaticClass
    {
        static StaticClass()
        {
        }

        public static int Number { get; set; }

        public static void Function()
        {
        }
    }

    //we can add both static and nonstatic members
    public class NonStaticClass
    {
        static NonStaticClass()
        {
        }

        public static int StaticNumber { get; set; }

        public static void StaticFunction()
        {
            StaticNumber++;
            AnotherStaticFunction();
        }

        public static void AnotherStaticFunction()
        {
        }

        public NonStaticClass()
        {
        }

        public int Number { get; set; }

        public void Function()
        {
            //StaticFunction();
            //AnotherStaticFunction();
            Number++;
            StaticNumber++;
            System.Console.WriteLine($"Number = {Number}\nStaticNumber = {StaticNumber}");
        }
    }
}