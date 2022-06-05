using System;
using System.Globalization;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            string nome;
            double salarioBruto, imposto;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario func = new Funcionario(nome, salarioBruto, imposto);
            Console.WriteLine(func.ToString());

            double porcentagemAumento;
            Console.Write("Digite a porcentagem de aumento do salário: ");
            porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagemAumento);

            Console.Write("Dados atualizados -> " + func.ToString());
        }
    }
}
