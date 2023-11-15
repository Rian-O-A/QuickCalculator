using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace QuickCalculator.Utils{

    class InputUser{

        public (float VALUE01, float VALUE02) Read(){

            Console.Clear();
            Console.Write("Value 01: ");
            
            new ScreenColor().ResetColor();
            float v1 = float.Parse(Console.ReadLine());
            new ScreenColor().Green();
            Console.Write("Value 02: ");
            
            new ScreenColor().ResetColor();
            float v2 = float.Parse(Console.ReadLine());
            new ScreenColor().Green();
            return (v1, v2);
            
        }
    }
}