using JogoDaForcaV2.ConsoleApp;


namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Escolha uma categoria:");
                Console.WriteLine("1 - Frutas");
                Console.WriteLine("2 - Animais");
                Console.WriteLine("3 - Países");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite sua escolha: ");

                string escolha = Console.ReadLine();
                string[] categoriaEscolhida;

                switch (escolha)
                {
                    case "1":
                        categoriaEscolhida = Lista.Frutas;
                        break;
                    case "2":
                        categoriaEscolhida = Lista.Animais;
                        break;
                    case "3":
                        categoriaEscolhida = Lista.Paises;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        continue;
                }

                string[] historicoDeTentivas = new string[100];
                int contadorHistorico = 0;

                Random geradorDeNumeros = new Random();

                int indicePalavraEscolhida = geradorDeNumeros.Next(categoriaEscolhida.Length);

                string palavraSecreta = categoriaEscolhida[indicePalavraEscolhida];

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    letrasEncontradas[caractere] = '_';
                }

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = String.Join("", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("-------------------------------------");

                    Arte.DesenharForca(quantidadeErros);

                    Console.WriteLine("palavra secreta : " + dicaDaPalavra);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Quantidade de erros : " + quantidadeErros);
                    Console.WriteLine("-------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine().ToUpper()[0];

                    historicoDeTentivas[contadorHistorico] = $"A letra chutada foi : {chute}";
                    contadorHistorico++;

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    dicaDaPalavra = String.Join("", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;
                    jogadorEnforcou = quantidadeErros == 6;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta, Parabéns!!");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.Clear();
                        Arte.DesenharForca(quantidadeErros);
                        Console.WriteLine("Você errou a palavra secreta, Tente novamente!! a palavra secreta era : " + palavraSecreta);
                        Console.WriteLine("-------------------------------------");
                    }

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Histórico de Tentativas");
                    Console.WriteLine("--------------------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoDeTentivas[contador]);
                    }

                } while (jogadorAcertou == false && jogadorEnforcou == false);

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
