namespace desafio_estagio_target
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha uma questão para ver a resposta:");
                Console.WriteLine("1 - Questão 1");
                Console.WriteLine("2 - Questão 2");
                Console.WriteLine("3 - Questão 3");
                Console.WriteLine("4 - Questão 4");
                Console.WriteLine("5 - Questão 5");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Questao1();
                            break;
                        case 2:
                            Questao2();
                            break;
                        case 3:
                            Questao3();
                            break;
                        case 4:
                            Questao4();
                            break;
                        case 5:
                            Questao5();
                            break;
                        case 0:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                Console.WriteLine();
            } while (opcao != 0);
        }

        static void Questao1()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("Resposta da Questão 1:");
            Console.WriteLine($"Ao final do processamento, o valor da variável SOMA será: {SOMA}");
        }

        static void Questao2()
        {
            Console.WriteLine("Resposta da Questão 2:");
            Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());
            bool pertence = VerificarFibonacci(numero);
            Console.WriteLine($"O número {numero} {(pertence ? "pertence" : "não pertence")} à sequência de Fibonacci.");
        }

        static bool VerificarFibonacci(int numero)
        {
            int a = 0, b = 1;
            while (b < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == numero;
        }

        static void Questao3()
        {
            Console.WriteLine("Resposta da Questão 3:");
            Console.WriteLine("a) 1, 3, 5, 7, ___ --> A próxima sequência seria 9.");
            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____ --> A próxima sequência seria 128.");
            Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____ --> A próxima sequência seria 49.");
            Console.WriteLine("d) 4, 16, 36, 64, ____ --> A próxima sequência seria 100.");
            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____ --> A próxima sequência seria 13.");
            Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, ____ --> A próxima sequência seria 20.");
        }

        static void Questao4()
        {
            Console.WriteLine("Resposta da Questão 4:");
            Console.WriteLine("Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma" +
                " sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os" +
                " interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.");
            Console.WriteLine("Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, " +
                "qual interruptor controla cada lâmpada?");
            Console.WriteLine("Você pode descobrir qual interruptor controla cada lâmpada da seguinte maneira:");
            Console.WriteLine("1. Ligue o primeiro interruptor e aguarde alguns minutos.");
            Console.WriteLine("2. Desligue o primeiro interruptor e ligue o segundo interruptor.");
            Console.WriteLine("3. Entre na sala onde as lâmpadas estão.");
            Console.WriteLine("   - A lâmpada que estiver acesa corresponde ao primeiro interruptor.");
            Console.WriteLine("   - A lâmpada que estiver apagada e quente corresponde ao segundo interruptor.");
            Console.WriteLine("   - A lâmpada que estiver apagada e fria corresponde ao terceiro interruptor.");
        }

        static void Questao5()
        {
            Console.WriteLine("Resposta da Questão 5:");
            Console.WriteLine("Digite uma string para ser invertida:");
            string texto = Console.ReadLine();
            string textoInvertido = InverterString(texto);
            Console.WriteLine($"A string invertida é: {textoInvertido}");
        }

        static string InverterString(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            int esquerda = 0;
            int direita = caracteres.Length - 1;

            while (esquerda < direita)
            {
                char temp = caracteres[esquerda];
                caracteres[esquerda] = caracteres[direita];
                caracteres[direita] = temp;

                esquerda++;
                direita--;
            }

            return new string(caracteres);
        }
    }
}