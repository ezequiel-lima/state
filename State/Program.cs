using State;

ContaBancaria conta = new ContaBancaria("Ezequiel", 2000);

Console.WriteLine(conta.EstadoDaConta.ToString());

Console.WriteLine("--------");

conta.Sacar(2000);

Console.WriteLine(conta.Saldo);

Console.WriteLine(conta.EstadoDaConta.ToString());

Console.WriteLine("--------");

conta.Depositar(100);

Console.WriteLine(conta.Saldo);

Console.WriteLine(conta.EstadoDaConta.ToString());

Console.WriteLine("--------");

conta.Depositar(100);

Console.WriteLine(conta.Saldo);

Console.WriteLine(conta.EstadoDaConta.ToString());

Console.ReadKey();
