using System.Runtime.InteropServices;

namespace JogoDaForca.ConsoleApp1
{
    internal class Program
    {

        //  Versão 2: Exibir palavra oculta com traços
        static void Main(string[] args)
        {
            while (true)
            {

                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere , letrasEncontradas.Length; caractere++) ;
                {
                    // acessar o array no indice 0
                    letrasEncontradas[caractere] = '-';
                }

                string dicaDaPalavra = String.Join(" ", lettrasEncontradas);

                    Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Palavra secreta: " + dicaDaPalavr);
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; //obtem aapenas um caractere do que o usuario digita

                Console.WriteLine(chute);

                Console.ReadLine();

            }

        } 

        }
    }
}
