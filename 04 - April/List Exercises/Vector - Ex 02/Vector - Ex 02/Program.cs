// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

class Program
{

    static void Main()
    {

        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];

        Random numero = new Random();

        for (int i = 0; i < 10; i++)
        {
            vetor1[i] = numero.Next(99);
        }

        for (int i = 0; i < 10; i++)
        {
            vetor2[i] = vetor1[(9 - i)];
        }
        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Vetor1[" + i + "]: " + vetor1[i]);
            Console.WriteLine("Vetor2[" + i + "]: " + vetor2[i]);
        }

    }

};
