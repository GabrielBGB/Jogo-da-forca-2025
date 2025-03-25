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

                string palavraEscolhida = "MELANCIA";

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                    letrasEncontradas[caractere] = '_';

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
                    string tronco = quantidadeErros >= 2 ? "x" : " ";
                    string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
                    string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
                    string bracoDireito = quantidadeErros >= 4 ? @"\" : " ";
                    string pernas = quantidadeErros >= 5 ? "/ \\" : " ";

                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/        |        ");
                    Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
                    Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
                    Console.WriteLine(" |        {0}       ", troncoBaixo);
                    Console.WriteLine(" |        {0}       ", pernas);
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Erros do jogador: " + quantidadeErros);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Palavra escolhida: " + String.Join("", letrasEncontradas));
                    Console.WriteLine("----------------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()!.ToUpper()[0];

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraEscolhida.Length; contador++)
                    {
                        char letraAtual = palavraEscolhida[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    string palavraEncontrada = String.Join("", letrasEncontradas);

                    jogadorAcertou = palavraEncontrada == palavraEscolhida;
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Você acertou a palavra secreta {palavraEscolhida}, parabéns!");
                        Console.WriteLine("----------------------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Que azar! Tente novamente!");
                        Console.WriteLine("----------------------------------------------");
                    }
                } while (jogadorEnforcou == false && jogadorAcertou == false);

                Console.ReadLine();
            }
        }
    }
}
