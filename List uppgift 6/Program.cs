using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> priser = new Dictionary<string, int>();

        Console.WriteLine("Skriv in namn på matvaror");
        string[] matvaror = Console.ReadLine().Split();

        Console.WriteLine("Skriv in matvarornas pris");
        string[] matpriser = Console.ReadLine().Split();

        Console.WriteLine("Skriv in din handlingslista");
        string[] shoplist = Console.ReadLine().Split();

        for (int i = 0; i < matvaror.Length; i++)
        {
            priser[matvaror[i]] = int.Parse(matpriser[i]);
        }

        int sum = 0;
        for (int i = 0;i < shoplist.Length; i++)
        {
            sum += priser[shoplist[i]];
        }
        Console.WriteLine($"Du behöver betala {sum} kr, för dina matvaror");
    }
}