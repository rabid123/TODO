using System;

namespace firstlast_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLZ write ur first name");
            String x = Console.ReadLine();
            Console.WriteLine("PLZ write ur last name");
            String y = Console.ReadLine(); 
            String z = x+y;
            Console.WriteLine("{0} {1}", x,y);
        }
    }
}
