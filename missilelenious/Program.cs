using System;

namespace missilelenious
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator<int>.AreEqual(4, 4);
            bool strEqual = Calculator<string>.AreEqual("Interview", "Happy");



            Console.WriteLine(equal + " " + strEqual);

            Console.ReadLine();
        }
    }

    public class Calculator<T> 
    {
        public static bool AreEqual (T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
