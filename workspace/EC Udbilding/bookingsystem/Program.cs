using System;
using System.Threading;
using static System.Console;

namespace bookingsystem
{
    class Program
    {
        private static object keypressed;

        static void Main(string[] args)
        {
            bool isValidUser = false;
            while (!isValidUser)
            {
                Clear();
               
                SetCursorPosition(2, 1);
                Write("username = Admin");
                SetCursorPosition(6, 1);
                Write("password = pass");
                Clear();
                var username = ReadLine();
                var password = ReadLine();
                // bool validusername = (username1 == username) && (password1 == password);
                if (username == "Admin" && password == "pass") // if user give both username & passwrd correct then he start adding room,list roóm ext.
                {
                    isValidUser = true;
                }
                else
                {
                    WriteLine("Assess Denied!");
                    Thread.Sleep(2000); // 2000 ms / 2 sek
                }

                Console.WriteLine("1: Add room ");
                Console.WriteLine("2: List rooms ");
                Console.WriteLine("3: Remove room");
                Console.WriteLine("4: Make reservation");
                Console.WriteLine("5: List reservations ");
                Console.WriteLine("6: Exit ");
                {
                    Console.WriteLine("Access Granted");

                    ConsoleKeyInfo keyPressed = ReadKey();
                    switch (keypressed.Key)
                    {
                        case ConsoleKey.D1:

                            Room[] newRoom = newRoom[10];
                            WriteLine("Add Room: ");

                            newRoom.Room = ReadLine();
                    }

                }
            }

        else
                {
                    Console.WriteLine("Access Denied");
                }
                String[] rooms = new string[5];
                 String firstroom = rooms[5];
                 String secondroom = rooms[6];
                 Console.WriteLine(rooms.Length);

                Console.ReadLine();
            }
        }
    }


