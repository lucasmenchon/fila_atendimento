using System;

namespace FilaAtendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Menu MenuPrincipal = new Menu();
            menu = MenuPrincipal.menuPrincipal();
            int p;



            do {
                switch (menu)
                {
                    case "1":

                        

                        Console.WriteLine("Tecle enter para voltar ao menu principal: ");
                        Console.ReadKey();
                        Console.Clear();
                        menu = MenuPrincipal.menuPrincipal();
                        break;

                    case "2":

                        Console.WriteLine("Tecle enter para voltar ao menu principal: ");
                        Console.ReadKey();
                        Console.Clear();
                        menu = MenuPrincipal.menuPrincipal();
                        break;

                    case "Q":

                        Console.Clear();
                        Console.WriteLine("Programa encerrado!");
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Opção invalida.");
                        Console.WriteLine("Tecle enter para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                        menu = MenuPrincipal.menuPrincipal();
                        break;
                }

            } while  (true);

        }
    }
}
