//Frederico Guilherme Camilli Proença RA:200925

namespace POO_Herança_Conta_e_Poupança
{
    //Declaração da classe ContaJuridica, que herdará o código da classe Conta.
    class ContaJuridica : Conta
    {
        //Declaração da variável double EsprestimoLimite, com o uso de encapsulamento via Automatic Properties.
        public double EmprestimoLimite { get; set; }
        //Declaração do Construtor Padrão.
        public ContaJuridica() { }
        //Declaração do Construtor com os parâmetros herdados da classe Conta.
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }
        //Método de Empréstimo.
        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
