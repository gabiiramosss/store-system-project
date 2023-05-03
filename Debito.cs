using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_system
{
    public class Debito : Cartao
    {
        public float Saldo = 1000;


        public override void Pagar()
        {
            if (Valor <= Saldo)
            {
                Console.WriteLine($"Compra aprovada!");
            }
            else
            {
                Console.WriteLine($"Compra negada!");
            }
        }
    }
}