using System;

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
                //Gerar tratamento para caracteres especiais e espaços
                Console.WriteLine("Informe o valor da cifra para criptografia: ");
                int cifra = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a mensagem que deseja criptografar\nImportante: Os caracteres especiais serão ignorados, acentuação é aceita normalmente. ");
                string msg = Console.ReadLine();

                //Tratamento de caracteres especiais
                string[] comAcento = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };

                string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                for (int i = 0; i < comAcento.Length; i++)
                {
                    msg = msg.Replace(comAcento[i], semAcento[i]);
                }
                /** Troca os caracteres especiais da string por "" inclusive espaços **/
                string[] caracteresEspeciais = { "¹", "²", "³", "£", "¢", "¬", "º", "¨", "\"", "'", ".", ",", "-", ":", "(", ")", "ª", "|", "\\\\", "°", "_", "@", "#", "!", "$", "%", "&", "*", ";", "/", "<", ">", "?", "[", "]", "{", "}", "=", "+", "§", "´", "`", "^", "~"," " };

                for (int i = 0; i < caracteresEspeciais.Length; i++)
                {
                    msg = msg.Replace(caracteresEspeciais[i], "");
                }

                msg = msg.Trim().ToLower();

                Console.WriteLine("A mensagem cifrada é: ");

                foreach (char c in msg)
                    Console.Write((char)((int)c + cifra));

                Console.ReadKey();

            }


            else if (option == 2)
            {

                //Gerar tratamento para caracteres especiais
                Console.WriteLine("Informe o valor da cifra para descriptografar: ");
                int cifra = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a mensagem que deseja descriptografar: ");
                string msg = Console.ReadLine().ToLower();

                Console.WriteLine("A mensagem decifrada é: ");

                foreach (char c in msg)
                    Console.Write((char)((int)c - cifra));

                Console.ReadKey();

            }
        }
    }
}
