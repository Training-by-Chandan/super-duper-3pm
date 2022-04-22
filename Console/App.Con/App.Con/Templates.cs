namespace App.Con
{
    public class TemplatedClass<T1, T2, T3, T4>
        where T1 : class
        where T2 : struct
        where T3 : IShape
        where T4 : LivingThings
    {
        public T1 Variable1 { get; set; }
        public T1 Variable2 { get; set; }
        public T2 Variable3 { get; set; }
        public T2 Variable4 { get; set; }
        public T3 Variable5 { get; set; }
        public T3 Variable6 { get; set; }
        public T4 Variable7 { get; set; }
        public T4 Variable8 { get; set; }
    }

    public class NonTemplatedClass
    {
        public static void FunctionOne<T1, T2>(T1 item1, T2 item3)
            where T1 : IShape
            where T2 : struct
        {
        }
    }
}