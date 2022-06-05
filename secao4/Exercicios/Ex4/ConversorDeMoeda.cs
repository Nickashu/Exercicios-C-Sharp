using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4 {
    class ConversorDeMoeda {

        public double Quantia { get; set; }
        public double Cotacao { get; set; }
        public double IoF { get; } = 6;

        public ConversorDeMoeda() {
        }
        public ConversorDeMoeda(double quantia, double cotacao) {
            Quantia = quantia;
            Cotacao = cotacao;
        }

        public double ValorReais() {
            double total = Quantia * Cotacao;
            double valorReais = total * ((100 + IoF) / 100);
            return valorReais;
        }

    }
}
