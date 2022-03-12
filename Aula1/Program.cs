using System;

namespace Aula1
{
    class Program
    {
        static void Main (string[] args)
        {
            int valor1;
            int valor2; 
            int total;

            //Primeiro Fluxo
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse (Console.ReadLine());
            Console.WriteLine("O primeiro valor é " + valor1);

            //Segundo Fluxo
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse (Console.ReadLine());
            Console.WriteLine("O segundo valor é " + valor2);

            //Terceiro Fluxo
            total = valor1 + valor2;
            Console.WriteLine("A soma dos dois valores é " + total);
        }
    }
}

