
using OrientacaoObjetos.Entidade;

ContaBancaria conta = new ContaBancaria();

conta.Titular = "Gustavo Gfregorio";
conta.Numero = "123456";
conta.Agencia = "0001";
conta.Saldo = 1000;

conta.Sacar(500);
conta.Depositar(1500);
conta.Sacar(10000);

conta.MostrarDados();