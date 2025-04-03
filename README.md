# Conta Corrente

![](https://i.imgur.com/Fruk7K2.gif)

## Sobre o projeto

Uma conta corrente � composta por diversos atributos essenciais para sua opera��o. Ela possui um n�mero de identifica��o �nico, um saldo dispon�vel e um limite de d�bito estabelecido. Al�m disso, a conta mant�m um registro de movimenta��es financeiras, que englobam todas as transa��es realizadas.

Cada movimenta��o registrada na conta corresponde a uma transa��o financeira, que pode ser classificada como cr�dito (dep�sito ou entrada de dinheiro) ou d�bito (saque ou retirada de fundos). Cada transa��o cont�m um valor associado e impacta diretamente o saldo da conta.

## Funcionalidades

- **Saque**: Permite a retirada de valores, respeitando o limite m�ximo permitido.
- **Dep�sito**: Possibilita a adi��o de fundos � conta.
- **Consulta de saldo**: Fornece informa��es atualizadas sobre o montante dispon�vel.
- **Emiss�o de extrato**: Lista todas as movimenta��es realizadas em um per�odo espec�fico.
- **Transfer�ncia entre contas**: Permite a movimenta��o de valores entre contas correntes distintas.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para a compila��o e execu��o do projeto.

## Como usar

1. Clone o reposit�rio

```
git clone https://github.com/estevaosantosribeiro/ContaCorrente.git
```

2. Navegue at� a pasta raiz do projeto:

```sh
cd ContaCorrente
```

3. Restaure as depend�ncias:

```sh
dotnet restore
```