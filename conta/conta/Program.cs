using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaCorrente;
            contaCorrente = new Conta();

            contaCorrente.nome();

            contaCorrente.conta();

            contaCorrente.verSaldo();

            contaCorrente.deposita(1);

            contaCorrente.saque(1);

            Console.ReadKey();
        }
    }
}
