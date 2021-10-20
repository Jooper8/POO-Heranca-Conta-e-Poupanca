//Frederico Guilherme Camilli Proença RA:200925

using System;

namespace POO_Herança_Conta_e_Poupança
{
    //Programa principal com o qual o usuário interage que utiliza o código das outras classes.
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variável conta, que utiliza os parâmetros especifícados na ContaJuridica (numero, titular, saldo, emprestimoLimite), e seus dados já definidos.
            ContaJuridica conta = new(1, "Test", 100, 500);
            //Exposição do saldo definido anteriormente.
            Console.WriteLine(conta.Saldo);
        }
    }
}
