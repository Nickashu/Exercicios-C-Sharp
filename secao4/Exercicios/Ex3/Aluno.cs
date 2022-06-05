using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3 {
    class Aluno {

        public string Nome { get; set; }
        public double[] Notas { get; set; } = new double[3];

        public Aluno() {
        }
        public Aluno(string nome, double nota1, double nota2, double nota3) {
            Nome = nome;
            Notas[0] = nota1;
            Notas[1] = nota2;
            Notas[2] = nota3;
        }

        public double NotaFinal() {
            double notaFinal = Notas[0] + Notas[1] + Notas[2];
            return notaFinal;
        }

    }
}
