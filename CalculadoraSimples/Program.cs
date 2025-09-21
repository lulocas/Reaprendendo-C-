using System.Runtime.InteropServices;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            while(opc != 0)
            {
                Menu();
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        Console.WriteLine("Até a próxima :)");
                        break;
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Sub();
                        break;
                    case 3:
                        Multi();
                        break;
                    case 4:
                        Div();
                        break;
                    default:
                        Console.WriteLine("Escolha um número válido");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
        }

        static void Soma()
        {
            Console.WriteLine("Escreva o primeiro numero: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero: ");
            float b = Convert.ToSingle(Console.ReadLine());
            float result = a + b;
            Console.WriteLine("Resultado: " + result);
        }
        static void Sub()
        {
            Console.WriteLine("Escreva o primeiro numero: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero: ");
            float b = Convert.ToSingle(Console.ReadLine());
            float result = a - b;
            Console.WriteLine("Resultado: " + result);
        }
        static void Multi()
        {
            Console.WriteLine("Escreva o primeiro numero: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero: ");
            float b = Convert.ToSingle(Console.ReadLine());
            float result = a * b;
            Console.WriteLine("Resultado: " + result);
        }
        static void Div()
        {
            Console.WriteLine("Escreva o primeiro numero: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero: ");
            float b = Convert.ToSingle(Console.ReadLine());
            float result = a / b;
            Console.WriteLine("Resultado: " + result);
        }
    }
}
