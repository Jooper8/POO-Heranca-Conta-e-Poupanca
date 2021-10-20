//Frederico Guilherme Camilli Proença RA:200925

namespace POO_Herança_Conta_e_Poupança
{
    //Declaração da classe Conta, que possui os métodos e variáveis principais a serem utilizadas no programa.
    class Conta
    {
        //Declaração das variáveis int e string Numero e Titular, respectivamente, com o uso de encapsulamento via Automatic Properties.
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Declaração da variável double Saldo, que utiliza encapsulamento via Automatic Properties e o protected set, que permite a mudança do valor para classes variadas da Conta, mas outras classes podem apenas buscar o valor escolhido anteriormente.
        public double Saldo { get; protected set; }
        //Declaração do construtor padrão e um construtor com argumentos, respectivamente.
        public Conta() { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; Titular = titular; Saldo = saldo;
        }
        //Método de Saque.
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //Método de Depósito.
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}
