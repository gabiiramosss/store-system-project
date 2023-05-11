using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace payment_system
{
    public class Boleto : Pagamento
    {
        private Random codigoBarras = new Random ();

        public void Registrar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O Código de Barras do pagamento de valor {(Valor * 0.88f):C} é '{codigoBarras.Next()}'.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Preste atenção na validade! O prazo de vencimento deste código é {DateTime.Now.AddDays(3).ToString("MM/dd/yyyy")}!");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}