using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    public class Conta
    { 
        public string titular { get; set; }
        public int numeroConta { get; set; }
        public int saldo { get; set; }

        public void nome()
        {
            
            Console.Write("Digite seu nome:");
            titular = Console.ReadLine();

            Console.Write($"Olá {titular} ");


        }

        public void conta()
        {
            Console.Write("Informe sua conta:");
            numeroConta = int.Parse(Console.ReadLine());

            Console.Write($"Dono da conta  {numeroConta}.");


        }
        public void verSaldo()
        {
            saldo = 500;
            Console.Write($"Saldo disponivel de {saldo }.");

        }

        public void deposita(int valor)
        {
            if (valor > 0)
            {
                Console.WriteLine("Digite o valor do deposito:");
                valor = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("valor incorreto");
            }

            Console.WriteLine($"Deposito de {valor}, feito com sucesso.");
            Console.Write($"Saldo disponivel de {saldo + valor}.");

        }

        public void saque(int valor)
        {
            int x;
            Console.WriteLine("Digite o valor do saque:");
            valor = int.Parse(Console.ReadLine());

            x = saldo + valor;

            if (valor <= x)
            {
                Console.WriteLine( $"Saque de { valor } reais, realizado com sucesso! ");
            }
            else
            {
                Console.WriteLine("Valor incorreto ou saldo indisponivel!");
            }
            Console.Write($"Saldo disponivel de {saldo - valor}.");

        }
    }
}
