//Frederico Guilherme Camilli Proença RA:200925

using System;

namespace POO_Herança_Conta_e_Poupança
{
    //Programa principal com o qual o usuário interage que utiliza o código das outras classes.
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            //Instanciação das variáveis numero, titular e saldo (int, string e double, respectivamente). Também instanciado as variáveis i, que será utilizado em switch, saldoAdd e saldoRmv, que atualizarão o saldo.
            int numero, i;
            string titular;
            double saldo, saldoAdd, saldoRmv;
            //Inserção dos dados solicitados ao usuário.
            Console.WriteLine("Insira o número da conta:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do titular da conta:");
            titular = Console.ReadLine();
            Console.WriteLine("Insira o saldo presente na conta:");
            saldo = double.Parse(Console.ReadLine());
            //Declaração do vetor conta baseada na classe ContaPoupanca.
            ContaPoupanca conta = new(numero, titular, saldo, 2);
            //Ponto para voltar ao selecionar a escolha no switch que será preenchido.
            while (looping)
            {
                //Exposição dos dados inseridos pelo usuário ao usuário.
                Console.WriteLine("Número da Conta: {0}\nTitular: {1}\nSaldo: {2}", numero, titular, saldo);
                //Pedido e inserção do switch i, que representa a ação desejada pelo usuário.
                Console.WriteLine("Insira a ação desejada:\n1)Depósito.\n2)Saque.\n3)Sair.");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        //Case no qual ocorre o depósito.
                        Console.WriteLine("Insira a quantidade a ser depositada:");
                        saldoAdd = double.Parse(Console.ReadLine());
                        if (saldoAdd > 0)
                        {
                            conta.Deposito(saldoAdd);
                            saldo = conta.Saldo;
                        }
                        else
                        {
                            Console.WriteLine("O valor inserido não é válido. Valores válidos são aqueles acima de 0.");
                        }
                        break;
                    case 2:
                        //Case no qual ocorre o saque.
                        Console.WriteLine("Insira a quantidade a ser sacada (Há uma taxa de R$2,00 para saques):");
                        saldoRmv = double.Parse(Console.ReadLine());
                        if (saldoRmv > 0)
                        {
                            conta.Saque(saldoRmv);
                            saldo = conta.Saldo;
                        }
                        else
                        {
                            Console.WriteLine("O valor inseriido não é válido. Valores válidos são aqueles acima de 0.");
                        }
                        break;
                    case 3:
                        //Case no qual o usuário sai da aplicação.
                        looping = false;
                        Console.WriteLine("Saindo do aplicativo.");
                        break;
                    default:
                        //Case no qual o usuário não preenche um valor válido.
                        Console.WriteLine("Comando selecionado não é válido.");
                        break;

                }


            }
        }
    }
}
