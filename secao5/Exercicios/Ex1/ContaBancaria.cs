using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex1 {
    class ContaBancaria {

        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() {
        }
        public ContaBancaria(int numero, string nomeTitular) {   //Caso não haja depósito inicial
            Numero = numero;
            NomeTitular = nomeTitular;
            Saldo = 0;
        }
        public ContaBancaria(int numero, string nomeTitular, double depositoInicial) {
            Numero = numero;
            NomeTitular = nomeTitular;
            Saldo += depositoInicial;
        }


        public void Saque(double valor) {
            int taxa = 5;
            Saldo = Saldo - taxa - valor;
            Console.WriteLine("\nDados Atualizados:\n{0}\n", this.ToString());
        }
        public void Deposito(double valor) {
            Saldo += valor;
            Console.WriteLine("\nDados Atualizados:\n{0}\n", this.ToString());
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + NomeTitular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
