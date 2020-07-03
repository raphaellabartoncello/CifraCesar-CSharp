using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifraCesar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Apresentação do software e escolha do qual funcionalidade será utilizada
            Console.WriteLine("Seja bem vind@ ao Criptador\n");
            Console.WriteLine("Aqui é possível criptografar e descriptografar mensagens\n");
            Console.WriteLine("Esse processo é realizado conforme a Cifra de César e é finalizado com a geração de um SHA-1\n");
            Console.WriteLine("Então vamos lá, escolha uma opção:\n");
            Console.Write("|---------------------------------|\n");
            Console.Write("| 1 - Criptografar um mensagem    |\n");
            Console.Write("| 2 - Decriptografar uma mensagem |\n");
            Console.Write("| 0 - Sair                        |\n");
            Console.Write("|---------------------------------|\n");

            //Receber a opção (virá como string) e armazenar como int
            int option = int.Parse(Console.ReadLine());

            if (option != 1 && option != 2 && option != 0)
            {
                Console.WriteLine("Insira uma opção válida!");

            }

            if (option == 1)
            {
                //Gerar tratamento para caracteres especiais
                Console.WriteLine("Informe o valor da cifra para criptografia (sem caracteres especiais): ");
                int cifra = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a mensagem que deseja criptografar sem acentos ou caracteres especiais: ");
                string msg = Console.ReadLine().ToLower();

                Console.WriteLine("A mensagem cifrada é: ");

                foreach (char c in msg)
                    Console.Write((char)((int)c + cifra));

                //Gerar SHA-1

                Console.ReadKey();
            }


            else if (option == 2)
            {

                //Gerar tratamento para caracteres especiais
                Console.WriteLine("Informe o valor da cifra para descriptografar (sem caracteres especiais): ");
                int cifra = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a mensagem que deseja descriptografar sem acentos ou caracteres especiais: ");
                string msg = Console.ReadLine().ToLower();

                Console.WriteLine("A mensagem decifrada é: ");

                foreach (char c in msg)
                    Console.Write((char)((int)c - cifra));

                //Gerar SHA-1

                Console.ReadKey();
            }
        }
    }
}
