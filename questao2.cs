using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"O numero {numero} pertence a sequencia de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O numero {numero} nao pertence a sequencia de Fibonacci.");
        }
    }

    static bool PertenceAFibonacci(int numero)
    {
        int a = 0;
        int b = 1;
        
        if (numero == a || numero == b)
        {
            return true;
        }

        int c = a + b;
        while (c <= numero)
        {
            if (c == numero)
            {
                return true;
            }

            a = b;
            b = c;
            c = a + b;
        }

        return false;
    }
}