using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("js/faturamento.json");
        List<Faturamento> faturamentoMensal = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0;
        int diasComFaturamento = 0;

        foreach (var faturamento in faturamentoMensal)
        {
            if (faturamento.Valor > 0)
            {
                if (faturamento.Valor < menorFaturamento)
                {
                    menorFaturamento = faturamento.Valor;
                }

                if (faturamento.Valor > maiorFaturamento)
                {
                    maiorFaturamento = faturamento.Valor;
                }

                somaFaturamento += faturamento.Valor;
                diasComFaturamento++;
            }
        }

        double mediaMensal = somaFaturamento / diasComFaturamento;
        int diasAcimaMedia = 0;

        foreach (var faturamento in faturamentoMensal)
        {
            if (faturamento.Valor > mediaMensal)
            {
                diasAcimaMedia++;
            }
        }

        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaMedia}");
    }
}
