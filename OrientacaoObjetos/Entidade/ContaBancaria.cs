using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Entidade
{
    public class ContaBancaria
    {
        public string Titular;
        public string Numero;
        public string Agencia;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Deposito de R$ {valor} realizado. Saldo atual: R$ {Saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado. Saldo atual: R$ {Saldo}");

            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Conta: {Numero}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo: R$ {Saldo}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
