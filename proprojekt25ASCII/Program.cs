using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proprojekt25ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] alfabet = {  $"\n ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\  \\   \r\n \\ \\   __  \\  \r\n  \\ \\  \\ \\  \\ \r\n   \\ \\__\\ \\__\\\r\n    \\|__|\\|__|\r\n          \r              \r              \r",    $"\r\n ________     \r\n|\\   __  \\    \r\n\\ \\  \\|\\ /_   \r\n \\ \\   __  \\  \r\n  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\\r\n    \\|_______|\r\n              \r\n              \r\n              \r\n"  };
            Console.Write(alfabet[0]);
            Console.SetCursorPosition(14,14 );
            Console.Write(alfabet[0]);

            
            
        }
    }
}
