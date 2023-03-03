using System;
using System.Collections;

namespace Proc420420
{
    class program
    {
        static void Main()
        {
            Storage.StorageTools.InitializeAllRegistry();
            Console.Clear();
            Console.Write("Write ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("HELP");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" for more instructions");

            while(true)
            {
                CommandRecevier.RecognizeCommand(CommandRecevier.ReadCommand());
            }
        }


    }
}
