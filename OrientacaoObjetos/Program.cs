
using OrientacaoObjetos.Entidade;

/*

  Encapsiulamento é o conceito de proteger os dados da classe, permitindo que eles sejam acessados ne modificados
  
   - public -> acessivel a qualquer lugar.
   - private -> acessivel apenas dentro da própria classe.
   - prtected -> acessivel na propria classe e em classes filhas (quando houver herança)
  

 */

ContaBancaria conta = new ContaBancaria();

conta.Titular = "Gustavo Gfregorio";
conta.Numero = "123456";
conta.Agencia = "0001";

//conta.Sacar(500);
//conta.Depositar(1500);
//conta.Sacar(10000);

conta.Depositar(1000);
conta.Sacar(250);

conta.MostrarDados();