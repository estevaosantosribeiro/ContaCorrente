namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        public static int indiceMovimentacao = 0, numeroIdentificacao;
        public static decimal saldoDisponivel, valorAdicional, limitePermitido;
        public static char acaoEscolhida;
        public static string tipoTransacao = "";
        public static string[] registroMovimentacoes = new string[100];

        public static void RealizarSaque(decimal valorTransacao)
        {
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

        public static void RealizarDeposito(decimal valorTransacao)
        {
            saldoDisponivel += valorTransacao;
            tipoTransacao = "depósito";
            registroMovimentacoes[indiceMovimentacao] = $"A conta {numeroIdentificacao} realizou a operação de {tipoTransacao} de R$ {valorTransacao}";
            indiceMovimentacao++;
        }

        public static void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível: R$ {saldoDisponivel}");
        }

        public static void GerarExtrato()
        {
            if (registroMovimentacoes.Length > 0)
            {
                for (int i = 0; i < indiceMovimentacao; i++)
                {
                    Console.WriteLine(registroMovimentacoes[i]);
                }
            }
            else
            {
                Console.WriteLine("Ainda não há movimentações!");
            }
        }

        public static void RealizarTrasferencia(decimal valorTransacao)
        {
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

        public static void AtualizarLimite()
        {
            limitePermitido = saldoDisponivel + valorAdicional;
        }
    }
}
