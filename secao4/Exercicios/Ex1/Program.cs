using System;
using System.Globalization;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            double largura, altura;

            Console.WriteLine("Entre com a largura e a altura do retângulo");
            Console.Write("Largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo ret = new Retangulo(largura, altura);

            Console.Write("Área do retângulo: {0}\nPerímetro do retângulo: {1}\nDiagonal do retângulo: {2}", ret.Area().ToString("F2", CultureInfo.InvariantCulture), ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture), ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
