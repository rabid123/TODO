using System;

namespace ssn2test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            String repeating = new string('*', 20);
            Console.WriteLine(repeating);
            String start = "hello friends my name is ";
            String end = " Rabid Mehmood ";
            String concat = start + end ;
            Console.WriteLine(concat);
            String repeating2 = new string('$', 20);
            Console.WriteLine(repeating2);
            Console.WriteLine("what is value of s1 to be compair. ");
            String s1 = Console.ReadLine();
            Console.WriteLine(" what is value of string2 to be compair");
            String s2 = Console.ReadLine();
            bool result1 = s1 == s2;
            Console.WriteLine("if value of s1 and s2 same then result is: ");
            Console.WriteLine(result1);
            bool result2 = s1 != s2;
            Console.WriteLine(" if we compair s1 with s2 then result is:");
            Console.WriteLine(result2);

            /*
           // bool function ( to check T/F values.)

            Console.WriteLine("what is String 1 to compare.");
            string s1 = Console.ReadLine();
            Console.WriteLine("what is String 2 to compare.");
            string s2 = Console.ReadLine();
            bool result = s1 == s2;                  // result = true
            Console.WriteLine("if we compare both then result is:");
            Console.WriteLine(result);
            bool result2 = s1 != s2;             // result = false
            Console.WriteLine("if we compare not equal of s1 and s2 then result is:");
            Console.WriteLine(result2); */
            /*
            Console.WriteLine("what is String 3 to compare.");
            string s3 = Console.ReadLine()
            string s3 = "String to Compare.";   // Note the capital "C"
            bool result;
            result = s1 == s2;                  // result = true
            Console.WriteLine(result);
            result = s1 == s3;                  // result = false   
            result = s1 != s3;                  // result = true */
        }
    }
}
