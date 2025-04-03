namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indiceMovimentacao = 0, numeroIdentificacao;
            decimal saldoDisponivel, valorAdicional, limitePermitido, valorTransacao;
            char acaoEscolhida;
            string tipoTransacao;
            string[] registroMovimentacoes = new string[100];

            // menu
            ExibirCabecalho();
            Console.Write("Número da conta: ");
            numeroIdentificacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saldo disponível: ");
            saldoDisponivel = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Valor adicional: ");
            valorAdicional = Convert.ToDecimal(Console.ReadLine());

            limitePermitido = saldoDisponivel + valorAdicional;

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
                    if (valorTransacao < limitePermitido)
                    {
                        saldoDisponivel -= valorTransacao;
                        tipoTransacao = "saque";
                        registroMovimentacoes[indiceMovimentacao] = $"A conta {numeroIdentificacao} realizou a operação de {tipoTransacao} de R$ {valorTransacao}";
                        indiceMovimentacao++;
                    }
                    else
                    {
                        Console.WriteLine("Limite permitido excedido! Tente novamente.");
                    }
                }
                else if (acaoEscolhida == '2')
                {
                    Console.Write("Digite o valor da transação: ");
                    valorTransacao = Convert.ToDecimal(Console.ReadLine());
                    saldoDisponivel += valorTransacao;
                    tipoTransacao = "depósito";
                    registroMovimentacoes[indiceMovimentacao] = $"A conta {numeroIdentificacao} realizou a operação de {tipoTransacao} de R$ {valorTransacao}";
                    indiceMovimentacao++;
                }
                else if (acaoEscolhida == '3')
                {
                    Console.WriteLine($"Saldo disponível: R$ {saldoDisponivel}");
                }
                else if (acaoEscolhida == '4')
                {
                    if (registroMovimentacoes.Length > 0)
                    {
                        for (int i = 0; i < indiceMovimentacao; i++)
                        {
                            Console.WriteLine(registroMovimentacoes[i]);
                        }
                    } else
                    {
                        Console.WriteLine("Ainda não há movimentações!");
                    }
                }
                else if(acaoEscolhida == '5')
                {
                    Console.Write("Digite o valor da transação: ");
                    valorTransacao = Convert.ToDecimal(Console.ReadLine());
                    if (valorTransacao < limitePermitido)
                    {
                        saldoDisponivel -= valorTransacao;
                        tipoTransacao = "transferência";
                        registroMovimentacoes[indiceMovimentacao] = $"A conta {numeroIdentificacao} realizou a operação de {tipoTransacao} de R$ {valorTransacao}";
                        indiceMovimentacao++;
                    }
                    else
                    {
                        Console.WriteLine("Limite permitido excedido! Tente novamente.");
                    }
                }
                else
                {
                    break;
                }
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
