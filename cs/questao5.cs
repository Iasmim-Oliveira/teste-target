using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        string invertedString = InverterString(input);
        Console.WriteLine($"String invertida: {invertedString}");
    }

    static string InverterString(string input)
    {
        char[] caracteres = input.ToCharArray();
        int tamanho = caracteres.Length;

        for (int i = 0; i < tamanho / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - 1 - i];
            caracteres[tamanho - 1 - i] = temp;
        }

        return new string(caracteres);
    }
}
