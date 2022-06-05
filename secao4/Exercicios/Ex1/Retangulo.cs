using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1 {
    class Retangulo {

        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo() {
        }

        public Retangulo(double largura, double altura) {
            Largura = largura;
            Altura = altura;
        }

        public double Area() {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro() {
            double perimetro = (Largura * 2) + (Altura * 2);
            return perimetro;
        }

        public double Diagonal() {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }

    }
}
