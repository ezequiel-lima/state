namespace State
{
    public class Negativo : IEstadoDaConta
    {
        public void Depositar(ContaBancaria conta, double valor)
        {
            conta.Saldo = conta.Saldo + (valor * 0.95);

            if (conta.Saldo > 0)
                conta.EstadoDaConta = new Positivo();
        }

        public void Sacar(ContaBancaria conta, double valor)
        {
            throw new Exception("Você Não Tem Saldo Para Sacar");
        }
    }
}
