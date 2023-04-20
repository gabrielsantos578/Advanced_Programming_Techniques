// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

class Program
{

    static void Main()
    {

        int[] vetor = new int[10];

        Random numero = new Random();

        for (int i = 0; i < 10; i++)
        {
            vetor[i] = numero.Next(99);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Vetor[" + i + "]: " + vetor[i]);
        }
        Console.WriteLine();

        for (int i = 9; i > -1; i--)
        {
            Console.WriteLine("Vetor[" + i + "]: " + vetor[i]);
        }

    }

};
