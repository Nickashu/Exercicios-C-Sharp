using System;
using System.Globalization;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {
            string nome;
            double nota1, nota2, nota3;

            Console.Write("Nome da(o) aluna(o): ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas da(o) aluna(o):");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno alun = new Aluno(nome, nota1, nota2, nota3);

            double notaFinal = alun.NotaFinal();
            Console.WriteLine("Nota final: {0}", notaFinal.ToString("F2", CultureInfo.InvariantCulture));
            if(notaFinal >= 60) {
                Console.Write("APROVADA(O)!");
            }
            else {
                Console.Write("REPROVADA(O)!\nFaltaram {0} pontos.", (60-notaFinal).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
