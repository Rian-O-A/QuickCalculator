
namespace QuickCalculator{
    struct ScreenColor{

        public void Green(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Yellow(){
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void ResetColor(){
            Console.ResetColor();
        }

        public void Red(){
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }

}