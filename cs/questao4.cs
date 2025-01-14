using System;

class Program
{
    static void Main()
    {
        // Valores de faturamento por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27168.48;
        double outros = 19849.30;

        // Calculando o valor total de faturamento mensal
        double total = sp + rj + mg + es + outros;

        // Calculando e imprimindo o percentual de cada estado
        Console.WriteLine($"Percentual de SP: {CalcularPercentual(sp, total):F2}%");
        Console.WriteLine($"Percentual de RJ: {CalcularPercentual(rj, total):F2}%");
        Console.WriteLine($"Percentual de MG: {CalcularPercentual(mg, total):F2}%");
        Console.WriteLine($"Percentual de ES: {CalcularPercentual(es, total):F2}%");
        Console.WriteLine($"Percentual de Outros: {CalcularPercentual(outros, total):F2}%");
    }

    static double CalcularPercentual(double valor, double total)
    {
        return (valor / total) * 100;
    }
}
