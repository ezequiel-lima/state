namespace State
{
    public class ContaBancaria
    {
        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
            EstadoDaConta = saldo >= 0 ? new Positivo() : new Negativo();
        }

        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public IEstadoDaConta EstadoDaConta { get; private set; }

        public void Depositar(double valor)
        {
            EstadoDaConta.Depositar(this, valor);                   
        }

        public void Sacar(double valor)
        {
            EstadoDaConta.Sacar(this, valor);
        }

        private class Positivo : IEstadoDaConta
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

        private class Negativo : IEstadoDaConta
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
}
