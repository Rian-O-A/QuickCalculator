using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace QuickCalculator.Utils{

    class InputUser{

        public (float VALUE01, float VALUE02) Read(){

            Console.Clear();
            Console.Write("Value 01: ");
            
            new ScreenConsole().ResetColor();
            float v1 = float.Parse(Console.ReadLine());
            new ScreenConsole().Green();
            Console.Write("Value 02: ");
            
            new ScreenConsole().ResetColor();
            float v2 = float.Parse(Console.ReadLine());
            new ScreenConsole().Green();
            return (v1, v2);
            
        }
    }
}