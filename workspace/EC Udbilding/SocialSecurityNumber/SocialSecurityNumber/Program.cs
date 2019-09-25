using System;
using System.Globalization;
​
namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
​
        {
            Console.Write("Social Security Number (900416-0082): ");
            string socialSecurityNumber = Console.ReadLine();
        Console.Clear();
​
            int genderNumber = int.Parse(socialSecurityNumber.Substring(9, 1));
​
            bool isFemale = genderNumber % 2 == 0;
​
            string gender = isFemale ? "Female" : "Male";
​
            string dateTimePart = socialSecurityNumber.Substring(0, 6);
        DateTime birthDate = DateTime.ParseExact(dateTimePart, "yyMMdd", CultureInfo.InvariantCulture);

        int age = DateTime.Now.Year - birthDate.Year;
​
            if ((birthDate.Month > DateTime.Now.Month) || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age--;
            }
            else
            { 
               Console.WriteLine($"{gender}, and the age is {age}");
        }
    }
}