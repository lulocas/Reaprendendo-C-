namespace JogoDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindos ao jogo da velha #!!");
            Console.WriteLine("Vamos começar!!/n");

            string[] jogAtual = { "O", "X" };

            string[,] jogo = { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };

            bool onOf = false;
            int l, c;

            PrintJogo(jogo);

            while (!onOf)
            {
                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine("-------------Jogador " + (i + 1) + "-------------");
                    Console.Write("Linha: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Coluna: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    jogo[l, c] = jogAtual[i];
                    PrintJogo(jogo);
                    onOf = Verificar(jogo, jogAtual[i]);
                    if(onOf)
                    {
                        break;
                    }
                }
            }
        }

        static void PrintJogo(string[,] jogo)
        {
            for(int i =0;i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" " + jogo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool Verificar(string[,] jogo, string jogAtual)
        {
            int num = 0;
            if(jogAtual == "O")
            {
                num = 1;
            }
            else
            {
                num = 2;
            }
                for (int i = 0; i < 3; i++)
                {
                    if (jogo[i, 0] == jogAtual && jogo[i, 1] == jogAtual && jogo[i, 2] == jogAtual)
                    {
                        Console.WriteLine("Jogador " + num + " venceu!!!");
                        return true;
                    }
                    if (jogo[0, i] == jogAtual && jogo[1, i] == jogAtual && jogo[2, i] == jogAtual)
                    {
                        Console.WriteLine("Jogador " + num + " venceu!!!");
                        return true;
                    }
                }
            if (jogo[0, 0] == jogAtual && jogo[1, 1] == jogAtual && jogo[2, 2] == jogAtual)
            {
                Console.WriteLine("Jogador " + num + " venceu!!!");
                return true;
            }
            if(jogo[0, 2] == jogAtual && jogo[1, 1] == jogAtual && jogo[2, 0] == jogAtual)
            {
                Console.WriteLine("Jogador " + num + " venceu!!!");
                return true;
            }

            return false;
           
        }
    }
}
