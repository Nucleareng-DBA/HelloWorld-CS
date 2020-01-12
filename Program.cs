using System;

namespace HelloWorld
{
    class Program
    {
        const double PI = 3.14159265359;
        const int weeks = 52, months  =12;
        const string myBirthday = "30/04/1980";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0} ", myBirthday);
            Console.WriteLine("1+2={0}", Program.Add(1,2));
            WriteSomethingSpecific("I am an argument and called from a method");



        }

        public static int Add(int num1, int num2)
        {
            int resualt = num1 + num2;
            return resualt;
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

    }
}
