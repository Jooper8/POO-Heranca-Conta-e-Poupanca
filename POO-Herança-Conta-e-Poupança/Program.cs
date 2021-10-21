//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Herança_Conta_e_Poupança
{
    //Programa principal com o qual o usuário interage que utiliza o código das outras classes.
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();
            {
                list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
                list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
                list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
                list.Add(new ContaJuridica(1002, "Mae", 500.0, 400.0));
            }
            double soma = 0.0;
            foreach (Conta acc in list)
            {
                soma += acc.Saldo;
            }
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Conta acc in list)
            {
                acc.Saque(10.0);
            }
            foreach (Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas" + acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}