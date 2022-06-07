using System;
using System.Globalization;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {

            int numConta;
            string nomeTitular;

            Console.Write("Número da conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            nomeTitular = Console.ReadLine();
            string opcDepositInic;
            while (true) {
                Console.Write("Haverá depósito inicial? (S/N): ");
                opcDepositInic = Console.ReadLine();
                if (opcDepositInic.ToUpper() != "S" && opcDepositInic.ToUpper() != "N") 
                    Console.WriteLine("Opção inválida! Tente novamente.");
                else
                    break;
            }
            ContaBancaria conta;
            if(opcDepositInic.ToUpper() == "S") {
                Console.Write("Valor do depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, nomeTitular, depositoInicial);
            }
            else 
                conta = new ContaBancaria(numConta, nomeTitular);

            Console.WriteLine("\nDados da conta:\n{0}\n", conta.ToString());

            int opcao;
            do {
                Console.Write("1) Depósito\n2) Saque\n3) Finalizar\nDigite sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        Console.Write("Valor do depósito: ");
                        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Deposito(deposito);
                        break;
                    case 2:
                        Console.Write("Valor do saque: ");
                        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Saque(saque);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

            } while (opcao != 3);

        }
    }
}
