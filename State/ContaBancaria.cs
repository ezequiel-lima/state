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
        public double Saldo { get; set; }
        public IEstadoDaConta EstadoDaConta { get; set; }

        public void Depositar(double valor)
        {
            EstadoDaConta.Depositar(this, valor);                   
        }

        public void Sacar(double valor)
        {
            EstadoDaConta.Sacar(this, valor);
        }
    }
}
