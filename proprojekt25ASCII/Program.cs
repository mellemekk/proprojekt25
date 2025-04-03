using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace proprojekt25ASCII
{

    internal class Program
    {
        static int cursorpoint = 0;

        static Regex filter = new Regex(@"[^a-zA-Z\s]");
        static void Main(string[] args)
        {



            




            string[] alfabet = { $" ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\  \\   \r\n \\ \\   __  \\  \r\n  \\ \\  \\ \\  \\ \r\n   \\ \\__\\ \\__\\\r\n    \\|__|\\|__|\r\n          ", $" ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\ /_   \r\n \\ \\   __  \\  \r\n  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ________     \r\n|\\   ____\\    \r\n\\ \\  \\___|    \r\n \\ \\  \\       \r\n  \\ \\  \\____  \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ________     \r\n|\\   ___ \\    \r\n\\ \\  \\_|\\ \\   \r\n \\ \\  \\ \\\\ \\  \r\n  \\ \\  \\_\\\\ \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" _______      \r\n|\\  ___ \\     \r\n\\ \\   __/|    \r\n \\ \\  \\_|/__  \r\n  \\ \\  \\_|\\ \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ________ \r\n|\\  _____\\\r\n\\ \\  \\__/ \r\n \\ \\   __\\\r\n  \\ \\  \\_|\r\n   \\ \\__\\ \r\n    \\|__| \r\n          \r\n          \r\n          \r\n", $" ________     \r\n|\\   ____\\    \r\n\\ \\  \\___|    \r\n \\ \\  \\  ___  \r\n  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ___  ___     \r\n|\\  \\|\\  \\    \r\n\\ \\  \\\\\\  \\   \r\n \\ \\   __  \\  \r\n  \\ \\  \\ \\  \\ \r\n   \\ \\__\\ \\__\\\r\n    \\|__|\\|__|\r\n              \r\n              \r\n              \r\n", $" ___     \r\n|\\  \\    \r\n\\ \\  \\   \r\n \\ \\  \\  \r\n  \\ \\  \\ \r\n   \\ \\__\\\r\n    \\|__|\r\n         \r\n         \r\n         \r\n", $"    ___     \r\n   |\\  \\    \r\n   \\ \\  \\   \r\n __ \\ \\  \\  \r\n|\\  \\\\_\\  \\ \r\n\\ \\________\\\r\n \\|________|\r\n            \r\n            \r\n            \r\n", $" ___  __       \r\n|\\  \\|\\  \\     \r\n\\ \\  \\/  /|_   \r\n \\ \\   ___  \\  \r\n  \\ \\  \\\\ \\  \\ \r\n   \\ \\__\\\\ \\__\\\r\n    \\|__| \\|__|\r\n               \r\n               \r\n               \r\n", $" ___          \r\n|\\  \\         \r\n\\ \\  \\        \r\n \\ \\  \\       \r\n  \\ \\  \\____  \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" _____ ______      \r\n|\\   _ \\  _   \\    \r\n\\ \\  \\\\\\__\\ \\  \\   \r\n \\ \\  \\\\|__| \\  \\  \r\n  \\ \\  \\    \\ \\  \\ \r\n   \\ \\__\\    \\ \\__\\\r\n    \\|__|     \\|__|\r\n                   \r\n                   \r\n                   \r\n", " ________      \r\n|\\   ___  \\    \r\n\\ \\  \\\\ \\  \\   \r\n \\ \\  \\\\ \\  \\  \r\n  \\ \\  \\\\ \\  \\ \r\n   \\ \\__\\\\ \\__\\\r\n    \\|__| \\|__|\r\n               \r\n               \r\n               \r\n", $" ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\  \\   \r\n \\ \\  \\\\\\  \\  \r\n  \\ \\  \\\\\\  \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ________   \r\n|\\   __  \\  \r\n\\ \\  \\|\\  \\ \r\n \\ \\   ____\\\r\n  \\ \\  \\___|\r\n   \\ \\__\\   \r\n    \\|__|   \r\n            \r\n            \r\n            \r\n", $" ________      \r\n|\\   __  \\     \r\n\\ \\  \\|\\  \\    \r\n \\ \\  \\\\\\  \\   \r\n  \\ \\  \\\\\\  \\  \r\n   \\ \\_____  \\ \r\n    \\|___| \\__\\\r\n          \\|__|\r\n               \r\n               \r\n", $" ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\  \\   \r\n \\ \\   _  _\\  \r\n  \\ \\  \\\\  \\| \r\n   \\ \\__\\\\ _\\ \r\n    \\|__|\\|__|\r\n              \r\n              \r\n              \r\n", $" ________      \r\n|\\   ____\\     \r\n\\ \\  \\___|_    \r\n \\ \\_____  \\   \r\n  \\|____|\\  \\  \r\n    ____\\_\\  \\ \r\n   |\\_________\\\r\n   \\|_________|\r\n               \r\n               \r\n", $" _________   \r\n|\\___   ___\\ \r\n\\|___ \\  \\_| \r\n     \\ \\  \\  \r\n      \\ \\  \\ \r\n       \\ \\__\\\r\n        \\|__|\r\n             \r\n             \r\n             \r\n", $" ___  ___     \r\n|\\  \\|\\  \\    \r\n\\ \\  \\\\\\  \\   \r\n \\ \\  \\\\\\  \\  \r\n  \\ \\  \\\\\\  \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n", $" ___      ___ \r\n|\\  \\    /  /|\r\n\\ \\  \\  /  / /\r\n \\ \\  \\/  / / \r\n  \\ \\    / /  \r\n   \\ \\__/ /   \r\n    \\|__|/    \r\n              \r\n              \r\n              \r\n", $" ___       __      \r\n|\\  \\     |\\  \\    \r\n\\ \\  \\    \\ \\  \\   \r\n \\ \\  \\  __\\ \\  \\  \r\n  \\ \\  \\|\\__\\_\\  \\ \r\n   \\ \\____________\\\r\n    \\|____________|\r\n                   \r\n                   \r\n                   \r\n", $" ___    ___ \r\n|\\  \\  /  /|\r\n\\ \\  \\/  / /\r\n \\ \\    / / \r\n  /     \\/  \r\n /  /\\   \\  \r\n/__/ /\\ __\\ \r\n|__|/ \\|__| \r\n            \r\n            \r\n", $"  ___    ___ \r\n |\\  \\  /  /|\r\n \\ \\  \\/  / /\r\n  \\ \\    / / \r\n   \\/  /  /  \r\n __/  / /    \r\n|\\___/ /     \r\n\\|___|/      \r\n             \r\n             \r\n", $" ________     \r\n|\\_____  \\    \r\n \\|___/  /|   \r\n     /  / /   \r\n    /  /_/__  \r\n   |\\________\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n" };
            int startx = 0;
            int starty = 2;

             string[] alinjer = alfabet[0].Split('\n');
             string[] blinjer = alfabet[1].Split('\n');
             string[] clinjer = alfabet[2].Split('\n');
             string[] dlinjer = alfabet[3].Split('\n');
             string[] elinjer = alfabet[4].Split('\n');
             string[] flinjer = alfabet[5].Split('\n');
             string[] glinjer = alfabet[6].Split('\n');
             string[] hlinjer = alfabet[7].Split('\n');
             string[] ilinjer = alfabet[8].Split('\n');
             string[] jlinjer = alfabet[9].Split('\n');
            string[] klinjer = alfabet[10].Split('\n');
            string[] llinjer = alfabet[11].Split('\n');
            string[] mlinjer = alfabet[12].Split('\n');
            string[] nlinjer = alfabet[13].Split('\n');
            string[] olinjer = alfabet[14].Split('\n');
            string[] plinjer = alfabet[15].Split('\n');
            string[] qlinjer = alfabet[16].Split('\n');
            string[] rlinjer = alfabet[17].Split('\n');
            string[] slinjer = alfabet[18].Split('\n');
            string[] tlinjer = alfabet[19].Split('\n');
            string[] ulinjer = alfabet[20].Split('\n');
            string[] vlinjer = alfabet[21].Split('\n');
            string[] wlinjer = alfabet[22].Split('\n');
            string[] xlinjer = alfabet[23].Split('\n');
            string[] ylinjer = alfabet[24].Split('\n');
            string[] zlinjer = alfabet[25].Split('\n');


            while (true)
            {
                Console.WriteLine("Skriv det du vill ha i ASCII : ");
                string input = Console.ReadLine();
                bool containsnumbers = filter.IsMatch(input);
                if (containsnumbers)
                {
                    Console.WriteLine("No siffrer or symboler thanks you very kindly!!");
                    return;
                }
                if (input == "clear")
                {
                    Console.Clear();
                    
                }
                if (input != "clear")
                {

                
                for (int i = 0; i < alinjer.Length; i++)
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

                            if (input[y] == 'd')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(dlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'e')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(elinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'f')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(flinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }


                            if (input[y] == 'g')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(glinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'h')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(hlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'i')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(ilinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'j')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(jlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'k')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(klinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'l')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(llinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'm')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(mlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'n')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(nlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }

                            if (input[y] == 'o')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(olinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'p')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(plinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'q')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(qlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'r')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(rlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 's')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(slinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 't')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(tlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'u')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(ulinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'v')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(vlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'w')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(wlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'x')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(xlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'y')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(ylinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == 'z')
                            {

                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(zlinjer[i]);
                                cursorpoint = cursorpoint + 15;
                            }
                            if (input[y] == ' ')
                            {
                                Console.SetCursorPosition(startx, starty + i);

                                Console.SetCursorPosition(cursorpoint, starty + i);
                                Console.Write(' ');
                                cursorpoint = cursorpoint + 15;
                            }


                        }
                        }

                    }

                Console.ReadKey();
            }

        }
    }
}
