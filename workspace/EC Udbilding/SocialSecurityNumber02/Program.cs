using System;
using System.Globalization;

namespace SocialSecurityNumber02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("SocialSecurityNumber (yymmdd-xxxx):");
             // int SocialSecurityNumber02= Console.ReadLine(); //
            // var SocialSecurityNumber02 = Console.ReadLine();
             String socialSecurityNumber = Console.ReadLine();
            Console.Clear();                          // how we know its F/M so we write this commond
            // String genderNumber = SocialSecurityNumber02.Substring(9,1); // now convert string inte INT
            int genderNumber = int.Parse(socialSecurityNumber.Substring(9, 1));// JAG vill ha int as new variable
            bool isFemale = genderNumber % 2 == 0; // TO CHECK is IT gemn eller Ogemn numer
            // step 2//
            String sex = isFemale ? "female" : "male";
            /* if (isFemale)
            {
                sex = "Female";
            }
            else
            {
                sex = "male";
            }*/
            //int age = 30;                                         // substring mean we gonna take sub part of ssn(yymmdd)
            String dateTimePart = socialSecurityNumber.Substring(0, 6);    // declare date time so make new string. Y6?? bcz from yymmdd r 6 digit
             DateTime birthDate = DateTime.ParseExact(dateTimePart, "yymmdd", CultureInfo.InvariantCulture); // here we declare DateTime as a variable.
            int age = DateTime.Now.Year - birthDate.Year;
            if((birthDate.Month > DateTime.Now.Month ||  birthDate.Month  == DateTime.Now.Month && birthDate.Day> DateTime.Now.Day )) // OR THIS COMND if (birthDate.Date> DateTime.Now.AddYears(-age))
            {
                --age;
            }
           // Console.WriteLine(sex + ", 30");
            Console.WriteLine($"{sex},{age}ok ho giya"); // intermunipulation
            Console.ReadLine();
        }
    }
}
