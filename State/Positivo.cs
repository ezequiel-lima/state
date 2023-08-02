namespace State
{
    public class Positivo : IEstadoDaConta
    {
        public void Depositar(ContaBancaria conta, double valor)
        {
            conta.Saldo = conta.Saldo + (valor * 0.98);
        }

        public void Sacar(ContaBancaria conta, double valor)
        {
            conta.Saldo -= valor;
            
            if (conta.Saldo <= 0)
                conta.EstadoDaConta = new Negativo();
        }
    }
}
