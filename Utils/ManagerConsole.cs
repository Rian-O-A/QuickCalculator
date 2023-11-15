
namespace QuickCalculator{
    public struct ScreenConsole{

        public void Green(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Yellow(){
            Console.ForegroundColor = ConsoleColor.Yellow;
        }


        public void Red(){
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void ResetColor(){
            Console.ResetColor();
        }

        public void Clean(){
            Console.Clear();
        }
    }

}