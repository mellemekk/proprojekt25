using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proprojekt25ASCII
{

    internal class Program
    {
        static int cursorpoint = 0;
        static void Main(string[] args)
        {



            Console.WriteLine("Skriv det du vill ha i ASCII : ");
            string  input = Console.ReadLine();




            string[] alfabet = { $" ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\  \\   \r\n \\ \\   __  \\  \r\n  \\ \\  \\ \\  \\ \r\n   \\ \\__\\ \\__\\\r\n    \\|__|\\|__|\r\n          ", $" ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\ /_   \r\n \\ \\   __  \\  \r\n  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ________     \r\n|\\   ____\\    \r\n\\ \\  \\___|    \r\n \\ \\  \\       \r\n  \\ \\  \\____  \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n" };
            int startx = 0;
            int starty = 2;

            string[] alinjer = alfabet[0].Split('\n');
            string[] blinjer = alfabet[1].Split('\n');
            string[] clinjer = alfabet[2].Split('\n');

            for(int i = 0; i < alinjer.Length; i++)
            {
                cursorpoint = 0;

                for (int y = 0; y < input.Length; y++)
                {

                    if (input[y] == 'a')
                    {

                        Console.SetCursorPosition(startx, starty + i);
                        
                        Console.SetCursorPosition(cursorpoint, starty + i);
                        Console.Write(alinjer[i]);
                        cursorpoint = cursorpoint + 15;
                    }







                    if (input[y] == 'b')
                    {
                        Console.SetCursorPosition(startx, starty + i);
                        
                        
                        Console.SetCursorPosition(cursorpoint, starty + i);
                        Console.Write(blinjer[i]);
                        cursorpoint = cursorpoint + 15;
                    }







                    if (input[y] == 'c')
                    {
                        Console.SetCursorPosition(startx, starty + i);
                        
                        
                        Console.SetCursorPosition(cursorpoint, starty + i);
                        Console.Write(clinjer[i]);
                        cursorpoint = cursorpoint + 15;
                    }


                }

            }

            Console.ReadKey();

        }
    }
}
