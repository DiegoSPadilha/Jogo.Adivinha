using System.Threading.Channels;

namespace Jogo.Adivinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*Bem vindo ao jogo da adivinhação*");
            Console.WriteLine("**********************************");


            Console.WriteLine("Insira a dificuldade do jogo (1 = fácil, 2 = médio, 3 = difícil):");

            int dificuldade = int.Parse(Console.ReadLine());
            int chances = 0;
            int pontuacao = 1000;
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1,20);

            switch (dificuldade)
            {
                case 1:
                    chances = 15;
                    Console.WriteLine("Este é um jogo fácil. Você tem " + chances + " chances.");
                    break;
                case 2:
                    chances = 10;
                    Console.WriteLine("Este é um jogo médio. Você tem " + chances + " chances.");
                    break;
                case 3:
                    chances = 5;
                    Console.WriteLine("Este é um jogo difícil. Você tem " + chances + " chances.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.ReadLine();

            for (int i = 0; i < chances; i++)
            {
                Console.WriteLine("Digite o numero: ");
                int numeroChute = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Você fez " + pontuacao + " pontos!");
                pontuacao = Math.Abs(pontuacao - (numeroChute + numeroAleatorio) / 2);
                Console.WriteLine();

                if (numeroChute == numeroAleatorio)
                {
                Console.WriteLine("Voce acertou, parabéns!");
                ;
                break;
                }
                else if (chances - 1 == i)
                {
                Console.WriteLine("Voce perdeu o jogo tente novamente!");
                break;
                }
                else if (numeroChute > numeroAleatorio)
                {
                Console.WriteLine("O numero é maior que o numero sugerido!");
                }
                else if (numeroChute < numeroAleatorio)
                {
                Console.WriteLine("O numero é menor que o numero sugerido!");
                }

            }
            
        }
    }
}