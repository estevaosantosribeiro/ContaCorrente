# Conta Corrente

![](https://i.imgur.com/Fruk7K2.gif)

## Sobre o projeto

Uma conta corrente é composta por diversos atributos essenciais para sua operação. Ela possui um número de identificação único, um saldo disponível e um limite de débito estabelecido. Além disso, a conta mantém um registro de movimentações financeiras, que englobam todas as transações realizadas.

Cada movimentação registrada na conta corresponde a uma transação financeira, que pode ser classificada como crédito (depósito ou entrada de dinheiro) ou débito (saque ou retirada de fundos). Cada transação contém um valor associado e impacta diretamente o saldo da conta.

## Funcionalidades

- **Saque**: Permite a retirada de valores, respeitando o limite máximo permitido.
- **Depósito**: Possibilita a adição de fundos à conta.
- **Consulta de saldo**: Fornece informações atualizadas sobre o montante disponível.
- **Emissão de extrato**: Lista todas as movimentações realizadas em um período específico.
- **Transferência entre contas**: Permite a movimentação de valores entre contas correntes distintas.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para a compilação e execução do projeto.

## Como usar

1. Clone o repositório

```
git clone https://github.com/estevaosantosribeiro/ContaCorrente.git
```

2. Navegue até a pasta raiz do projeto:

```sh
cd ContaCorrente
```

3. Restaure as dependências:

```sh
dotnet restore
```