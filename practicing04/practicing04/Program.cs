using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.WriteLine("Insira a quantidade de produtos: ");
            n = int.Parse(Console.ReadLine());

            string[] produtos = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Insira as informações para o {i + 1}° produto: ");
                string[] vetor = Console.ReadLine().Split(' ');

                produtos[i] = vetor[0];
                precoCompra[i] = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            }


            //para calcular o Lucro abaixo, Lucro Entre e lucro acima!
            int lucroAbaixo = 0;
            int lucroEntre = 0;
            int lucroAcima = 0;

            double lucroOperacao;
            for (int i = 0; i < n; i++)
            {
                lucroOperacao = precoVenda[i] - precoCompra[i];

                if (lucroOperacao < precoCompra[i] * 10 / 100)
                {
                    lucroAbaixo++;
                }
                else if (lucroOperacao >= precoCompra[i] * 20.1 / 100)
                {
                    lucroAcima++;
                }
                else
                {
                    lucroEntre++;
                }
            }


            //calcular valor total de compra
            double valorTotalCompra = 0;
            for (int i = 0; i < n; i++)
            {
                valorTotalCompra += precoCompra[i];
            }


            //calcular valor total de venda
            double valorTotalVendas = 0;
            for (int i = 0; i < n; i++)
            {
                valorTotalVendas += precoVenda[i];
            }

            // para calcular o lucro total
            double lucroTotal = 0;
            double[] lucro = new double[n];
            for (int i = 0; i < n; i++)
            {
                lucro[i] = precoVenda[i] - precoCompra[i];
                lucroTotal += lucro[i];
            }

            Console.WriteLine("Lucro abaixo de 10%: " + lucroAbaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre);
            Console.WriteLine("lucro acima de 20%: " + lucroAcima);
            Console.WriteLine("valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor total de venda: " + valorTotalVendas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}