using System;

namespace cs_1._20_AreaParalelogramo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis do programa
            double b, h, area;

            // Entrada de dados
            Console.Write("Digite o valor da base: ");
            b = double.Parse(Console.ReadLine());
            b = Math.Abs(b); // Garante base positiva
            Console.Write("Digite o valor da altura: ");
            h = double.Parse(Console.ReadLine());
            h = Math.Abs(h); // Garante base positiva

            // Processamento de dados
            area = b * h;

            // Saída de dados
            Console.WriteLine($"Área do paralelogramo: {area}");
        }
    }
}
