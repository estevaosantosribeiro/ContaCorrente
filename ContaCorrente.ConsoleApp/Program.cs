namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorTransacao;
            char acaoEscolhida;

            // menu
            ExibirCabecalho();
            Console.Write("Número da conta: ");
            ContaCorrente.numeroIdentificacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saldo disponível: ");
            ContaCorrente.saldoDisponivel = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Valor adicional: ");
            ContaCorrente.valorAdicional = Convert.ToDecimal(Console.ReadLine());

            ContaCorrente.AtualizarLimite();

            while (true)
            {
                Console.Clear();
                ExibirMenu();
                Console.Write("Digite a sua opção: ");
                acaoEscolhida = Convert.ToChar(Console.ReadLine()!);

                if (acaoEscolhida == '1')
                {
                    Console.Write("Digite o valor da transação: ");
                    valorTransacao = Convert.ToDecimal(Console.ReadLine());
                    ContaCorrente.RealizarSaque(valorTransacao);
                }
                else if (acaoEscolhida == '2')
                {
                    Console.Write("Digite o valor da transação: ");
                    valorTransacao = Convert.ToDecimal(Console.ReadLine());
                    ContaCorrente.RealizarDeposito(valorTransacao);
                }
                else if (acaoEscolhida == '3')
                {
                    ContaCorrente.ExibirSaldo();
                }
                else if (acaoEscolhida == '4')
                {
                    ContaCorrente.GerarExtrato();
                }
                else if(acaoEscolhida == '5')
                {
                    Console.Write("Digite o valor da transação: ");
                    valorTransacao = Convert.ToDecimal(Console.ReadLine());
                    ContaCorrente.RealizarTrasferencia(valorTransacao);
                }
                else
                {
                    break;
                }
                ContaCorrente.AtualizarLimite();
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        static void ExibirCabecalho()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                      Conta Corrente");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Para começar digite o número de identificação, o saldo e o \nvalor adicional da sua conta.");
        }

        static void ExibirMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Consuta de saldo");
            Console.WriteLine("4 - Emissão de extrato");
            Console.WriteLine("5 - Transferência entre contas");
            Console.WriteLine("6 - Sair");
            Console.WriteLine();
        }
    }
}
