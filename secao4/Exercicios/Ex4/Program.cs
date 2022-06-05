using System;
using System.Globalization;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {
            double cotacao, quantia;

            Console.Write("Cotação do dólar -> ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantia em dólares a ser comprada -> ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ConversorDeMoeda conv = new ConversorDeMoeda(quantia, cotacao);
            Console.Write("Valor a ser pago em reais: R${0}", conv.ValorReais().ToString("F2"));
        }
    }
}
