using System;

namespace swap_values
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 5, b = 10;
            String a;
           String b;
            String temp;

            Console.WriteLine("write value of (A) "); // user give values
            a= Console.ReadLine();
            Console.WriteLine("Write value of (B) ");
            b= Console.ReadLine();
            //String temp;
            temp = a; // now stor value of (a) in temp
            a = b;    // now in (a) store value of b
            b = temp; // now in (b) come value of temp
            Console.WriteLine("A =  " + a + " B = " + b);
            
        }

        }
}
