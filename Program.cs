using System;

namespace HelloWorld
{
    class Program
    {
        const double PI = 3.14159265359;
        const int weeks = 52, months  =12;
        const string myBirthday = "30/04/1980";
        const string eran = "Eran";
        const string liran = "Liran";
        const string ofri = "Ofri";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0} ", myBirthday);
            Console.WriteLine("1+2={0}", Add(1,2));
            Console.WriteLine("12*37={0}", Multi(12,37));
            Console.WriteLine("12*37={0}", Dedive(12, 8));
            WriteSomethingSpecific("I am an argument and called from a method");
            GreetFriend(eran);
            GreetFriend(liran);
            GreetFriend(ofri);



        }

        public static int Add(int num1, int num2)
        {
            //int resualt = num1 + num2;
            return num1 + num2;
        }

        public static void WriteSomethingSpecific(string myText) => Console.WriteLine(myText);

        public static long Multi(int num1, int num2) => num1 * num2;

        public static double Dedive(double num1, double num2) => num1 / num2;

        public static void GreetFriend(string friendName) => Console.WriteLine("Hi {0}, my friend!,{1}", friendName, friendName);

    }
}
