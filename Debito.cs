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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Compra aprovada!");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Compra negada!");
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}