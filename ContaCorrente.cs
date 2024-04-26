public class ContaCorrente : ContaBancaria
{
    public double TaxaDeManutencao = 0;

    public ContaCorrente(int numeroDaConta, double saldo, double taxaDeManutencao)
    {
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        TaxaDeManutencao = taxaDeManutencao;
    }
}