public class ContaPoupanca : ContaBancaria
{
    public double TaxaDeJuros = 0;

    public void AplicarJuros()
    {
        Saldo += Saldo * TaxaDeJuros;
    }
}