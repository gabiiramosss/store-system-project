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
            
            Console.WriteLine($" Código de Barras do pagamento de valor { Valor * 0.88f } é {codigoBarras.Next()}");

            
        }
    }
}