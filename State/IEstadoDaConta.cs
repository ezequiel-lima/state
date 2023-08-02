namespace State
{
    public interface IEstadoDaConta
    {
        public void Depositar(ContaBancaria conta, double valor);
        public void Sacar(ContaBancaria conta, double valor);
    }
}
