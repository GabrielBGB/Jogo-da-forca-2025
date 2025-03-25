namespace JogoDaForca.ConsoleApp1
{
    internal class Program
    {

        //  Versão 2: Exibir palavra oculta com traços
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-----------------------");

                Console.WriteLine("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; //obtem aapenas um caractere do que o usuario digita

                Console.WriteLine(chute);

                Console.ReadLine();

            }

        } 

        }
    }
}
