using System;

namespace CalculoParcelas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Compra Parcelada");

            Console.Write("Digite o valor da compra: ");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas: ");
            int quantidadeParcelas = Convert.ToInt32(Console.ReadLine());

            double valorParcela;
            double valorFinal;

            if (quantidadeParcelas <= 1)
            {
                valorParcela = valorCompra * 0.9;
                valorFinal = valorParcela;
            }
            else if (quantidadeParcelas <= 5)
            {
                valorParcela = valorCompra / quantidadeParcelas;
                valorFinal = valorCompra;
            }
            else
            {
                valorParcela = (valorCompra * 1.07) / quantidadeParcelas;
                valorFinal = valorCompra * 1.07;
            }

            Console.WriteLine("\nDetalhes da Compra:");
            Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
            Console.WriteLine($"Quantidade de parcelas: {quantidadeParcelas}");
            Console.WriteLine($"Valor das parcelas: R$ {valorParcela:F2}");
            Console.WriteLine($"Valor final da compra: R$ {valorFinal:F2}");
        }
    }
}
