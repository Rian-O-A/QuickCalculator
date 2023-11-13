using QuickCalculator.Operations;

namespace QuickCalculator.MainMenu{
    struct Menu {


        public void  Init() {
            while (true)
        {
            
            
            Console.Clear();
            
            new ResultsHistory().outHistory();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║           Quick Calculator           ║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine("║ 1 - Adição                           ║");
            Console.WriteLine("║ 2 - Subtração                        ║");
            Console.WriteLine("║ 3 - Multiplicação                    ║");
            Console.WriteLine("║ 4 - Divisão                          ║");
            Console.WriteLine("║ 5 - Sair                             ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            

            Console.Write(">> ");

            string escolha = Console.ReadLine();

            if (escolha == "5")
            {   
            
                new Message("Saindo da calculadora. Até logo!").Error();
                break;
            }

            switch (escolha){

                case "1":
                
                    new Soma();
                    break;
                case "2":
                    new Subtracao();
                    break;
                case "3":
                    new Multiplicacao();
                    break;
                case "4":
                    new Divisao();
                    break;

                 default:
                    new Message("Opção inválida. Por favor, escolha uma opção válida.").Error();
                    Console.ReadKey();
                    continue;
            }

        }
    }
    }
}