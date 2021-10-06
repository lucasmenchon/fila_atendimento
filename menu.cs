using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaAtendimento
{
    class Menu
    {
        public string menuPrincipal()
        {
            string menu;

            Console.WriteLine("(1) - Cadastro");
            Console.WriteLine("(2) - Alteração de Cadastro");
            Console.WriteLine("(Q) - Sair");
            menu = Console.ReadLine();
            return menu.ToUpper();
        }

    }
}
