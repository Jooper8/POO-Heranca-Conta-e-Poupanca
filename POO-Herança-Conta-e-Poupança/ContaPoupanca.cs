//Frederico Guilherme Camilli Proença RA:200925

namespace POO_Herança_Conta_e_Poupança
{
    //Declaração da classe ContaPoupanca, que herda o código da classe conta.
    class ContaPoupanca : Conta
    {
        //Declaração da variável double TaxaJuros, com o uso de encapsulamento via Automatic Properties.
        public double TaxaJuros { get; set; }
        //Declaração do construtor padrão e do construtor com parâmetros herdados da classe Conta, respectivamente.
        public ContaPoupanca() { }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        //Método de Atualização do Saldo.
        public void AtualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //Método de Saque selado, criado com override em base no Saque da classe Conta.
        public sealed override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}
