namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIdentificacao;
            decimal saldoDisponivel, limiteDebito, valorTransacao;
            char opcaoTransacao;
            string tipoTransacao;
            string[] movimentacoes = new string[100];

            // menu
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                      Conta Corrente");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Para começar digite o número de identificação da sua conta!");
            Console.Write("Número da conta: ");
            numeroIdentificacao = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Escolha o tipo de transação que deseja realizar.");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Transferência");
                Console.Write("Digite a sua opção: ");
                opcaoTransacao = Convert.ToChar(Console.ReadLine()!);
                if(opcaoTransacao != '1' && opcaoTransacao != '2' && opcaoTransacao != '3')
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                } else
                {
                    break;
                }
            }

            if (opcaoTransacao == '1')
            {
                tipoTransacao = "depósito";
            }
            else if (opcaoTransacao == '2')
            {
                tipoTransacao = "saque";
            }
            else
            {
                tipoTransacao = "transferência";
            }

            Console.Write("Digite o valor da transação: ");
            valorTransacao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"A conta {numeroIdentificacao} realizou a operação de {tipoTransacao} de R$ {valorTransacao}");

            Console.ReadLine();
        }
    }
}
