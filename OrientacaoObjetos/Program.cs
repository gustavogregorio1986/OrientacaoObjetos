
using OrientacaoObjetos.Entidade;

/*

  Encapsiulamento é o conceito de proteger os dados da classe, permitindo que eles sejam acessados ne modificados
  
   - public -> acessivel a qualquer lugar.
   - private -> acessivel apenas dentro da própria classe.
   - prtected -> acessivel na propria classe e em classes filhas (quando houver herança)
  
   Getters e Setters são formas de acessar e modificar os valores de atributos de uma classe de maneira controlada.
     - O getter (get) ´é responsavel por retoinrar o valor de um atributo.
     - O seter (get) é usado paar definir um novo valor paar esse atributo.
   Eles ajudam a proteger os dados e permitem aplkicar regras, como nãoa ceitar valores negativos por exemplo
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