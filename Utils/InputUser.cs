using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace QuickCalculator.Utils{

    class InputUser{

        public (float VALUE01, float VALUE02) Read(){

            Console.Clear();
            Console.Write("Value 01: ");
            
            Console.ResetColor();
            float v1 = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Value 02: ");
            
            Console.ResetColor();
            float v2 = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            return (v1, v2);
        }
    }
}