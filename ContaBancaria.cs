public class ContaBancaria
{
    public int NumeroDaConta =  0;
    public double Saldo = 0;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }
}