using System;
using System;
using System.Threading;
using static System.Console;
namespace TheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] matrix = new bool[0, 0];
            while (true)
            {
                Clear();
                WriteLine("1. Create battery grid");
                WriteLine("2. Purge battery grid");
                WriteLine("3. Install human");
                WriteLine("4. Discard human");
                WriteLine("5. Print battery grid");
                WriteLine("6. Calculate energy output(bonus)");
                WriteLine("7. Exit");
                ConsoleKeyInfo keyPressed = ReadKey(true);
                Clear();
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        SetCursorPosition(1, 2);
                        Write("Namn: ");
                        SetCursorPosition(1, 4);
                        Write("Rows: ");
                        SetCursorPosition(1, 6);
                        Write("Columns: ");
                        SetCursorPosition("Name: ".Length + 2, 2);
                        string gridName = ReadLine();
                        SetCursorPosition("Rows: ".Length + 2, 4);
                        ushort gridRows = ushort.Parse(ReadLine());
                        SetCursorPosition("Columns: ".Length + 2, 6);
                        ushort gridColumns = ushort.Parse(ReadLine());
                        matrix = new bool[gridRows, gridColumns];
                        Clear();
                        break;
                    case ConsoleKey.D3:
                        SetCursorPosition(1, 2);
                        Write("Row: ");
                        SetCursorPosition(1, 4);
                        Write("Column: ");
                        SetCursorPosition("Row: ".Length + 2, 1);
                        ushort gridRow = ushort.Parse(ReadLine());
                        gridRow -= 1;
                        SetCursorPosition("Column: ".Length + 2, 4);
                        ushort gridColumn = ushort.Parse(ReadLine());
                        gridColumn -= 1;
                        Clear();
                        if (matrix[gridRow, gridColumn])
                        {
                            WriteLine("Already occupied");
                        }
                        else
                        {
                            matrix[gridRow, gridColumn] = true;
                            WriteLine("Successfully installed human");
                        }
                        Thread.Sleep(2000); // 2 sec
                        Clear();
                        break;

                    case ConsoleKey.D5:
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j])
                                {
                                    Write($"| X |");
                                }
                                else
                                {
                                    Write("|  |");
                                }

                            }
                            WriteLine(" \n ");
                            
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }
                        ReadKey();

                }
            }

        }
    }
}
    


