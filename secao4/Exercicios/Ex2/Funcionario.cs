using System.Globalization;

namespace Ex2 {
    class Funcionario {

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario() {
        }
        public Funcionario(string nome, double salarioBruto, double imposto) {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido() {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (porcentagem / 100) * SalarioBruto;
        }

        public override string ToString() {
            return "Funcionária(o): " + Nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
