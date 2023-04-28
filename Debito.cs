using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_system
{
    public class Debito : Cartao
    {
        public float Saldo = 1000;


        public void Debitar()
        {
            if (Valor <= Saldo)
            {
                Console.WriteLine($"COMPRA APROVADA");

            }
            else
            {
                Console.WriteLine($"COMPRA NEGADA");

            }
        }

    }
}