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

                        Paciente[] paciente = new Paciente[3];
                        Console.WriteLine("Cadastro: ");

                        for (p = 0; p < 3; p++)
                        {
                            paciente[p] = new Paciente();

                            Console.WriteLine("Digite seu nome: ");
                            paciente[p].nome = Console.ReadLine();
                            Console.WriteLine("Digite sua idade: ");
                            paciente[p].idade = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Iniciando Atendimento: ");

                        for (p = 0; p < 3; p++) {

                            if (paciente[p].idade >= 60)
                            {

                                Console.WriteLine("Chamando...");
                                Console.WriteLine("Nome: {0}", paciente[p].nome);
                                Console.WriteLine("Idade: {0}", paciente[p].idade);
                                Console.ReadKey();
                            }

                       


                        }

                        Console.WriteLine("Tecle enter para voltar ao menu principal: ");
                        Console.ReadKey();
                        Console.Clear();
                        menu = MenuPrincipal.menuPrincipal();
                        break;

                    case "2":

                        paciente = new Paciente[10];
                        Console.WriteLine("Alteração de cadastro: ");

                        for (p = 0; p < 10; p++)
                        {
                            paciente[p] = new Paciente();
                        }

                        for (p = 0; p < 10; p++)
                        {
                            Console.WriteLine("Digite seu nome: ");
                            paciente[p].nome = Console.ReadLine();
                            Console.WriteLine("Digite sua idade: ");
                            paciente[p].idade = int.Parse(Console.ReadLine());
                        }

                        for (p = 0; p < 10; p++)
                        {
                            Console.WriteLine("Nome: {0}", paciente[p].nome);
                            Console.WriteLine("Idade: {0}", paciente[p].idade);
                        }
                        Console.WriteLine("Tecle enter para voltar ao menu principal: ");
                        Console.ReadKey();
                        Console.Clear();
                        menu = MenuPrincipal.menuPrincipal();
                        break;

                    case "3":

                        

                        Console.ReadKey();
                        Console.Clear();
                        menu = MenuPrincipal.menuPrincipal();
                        break;


                    default:
                        break;
                }
            } while  (true);






        }
    }
}
