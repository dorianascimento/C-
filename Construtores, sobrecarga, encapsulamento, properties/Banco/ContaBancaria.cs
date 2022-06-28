using System.Globalization;

namespace Course
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numeroConta)
        {
            NumeroConta = numeroConta;
            NomeTitular = nome;
        }

        public ContaBancaria(string nome, int numeroConta, double saldo): this(nome, numeroConta)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quntia)
        {
            Saldo = (Saldo - quntia) - 5.0;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + 
                ", Titular: " + NomeTitular + 
                ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
