using System;

namespace ParouImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicacao();
        }
        static void Aplicacao()
        {
            Console.WriteLine("Insira o numero para o teste: ");
            int numero = int.Parse(Console.ReadLine());

            int teste = numero % 2;
            if (teste == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            };
        }

    }

}