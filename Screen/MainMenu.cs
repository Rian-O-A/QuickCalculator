using QuickCalculator.Operations;

namespace QuickCalculator.MainMenu{
    struct Menu {


        public void  Init() {

            new ScreenConsole().Clean();
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
            Console.WriteLine("║ 5 - Limpar Historico                 ║");
            Console.WriteLine("║ 6 - Sair                             ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            

            Console.Write(">> ");

            string escolha = Console.ReadLine();

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
                case "5":
                    new ResultsHistory().cleanCache();
                    Init();
                    break;

                case "6":
                    new Message("Saindo da calculadora. Até logo!").Error();
                    Environment.Exit(0);
                    break;

                 default:
                    new Message("Opção inválida. Por favor, escolha uma opção válida.").Error();
                    Console.ReadKey();
                    Init();
                    break;
            }

        }
    }
    }
