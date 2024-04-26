﻿namespace Controle_de_contas_bancarias;

class Program
{
	static void Main()
	{
		ContaPoupanca contaPoupanca = new ContaPoupanca { NumeroDaConta = 36446, Saldo = 23654, TaxaDeJuros = 0.08 };
		ContaCorrente contaCorrente = new ContaCorrente(082267, 2289, 9);

		contaPoupanca.Depositar(840);
		contaPoupanca.Sacar(3980);
		contaPoupanca.AplicarJuros();

		contaCorrente.Depositar(4000);
		contaCorrente.Sacar(870);
		
		Console.WriteLine("Saldo da Poupança: " + contaPoupanca.Saldo);
		Console.WriteLine("Saldo da Corrente: " + contaCorrente.Saldo);
	}
}