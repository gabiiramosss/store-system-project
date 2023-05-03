namespace payment_system
{
    public class Credito : Cartao
    {

        public int parcelas;
        private float Limite = 1000;



        public override void Pagar()
        {
            if (Valor > Limite)
            {
                Console.WriteLine($"Cartao recusado! O valor excede o limite.");

            }
            else
            {
                if (parcelas <= 6)
                {
                    Console.WriteLine(@$" 
                    o Valor da compra ficou {Valor * 1.05} parcelado em 6x.
                    Com o valor de cada parcela de {Valor * 1.05/parcelas}");

                }
                else if (parcelas <= 12 && parcelas >= 7)
                {
                    Console.WriteLine(@$"
                     o valor da compra ficou {Valor * 1.08}
                     Com o valor de cada parcela de {Valor * 1.08/parcelas}");

                }
                else if (parcelas == 0)
                {
                    Console.WriteLine($"o valor da sua compra ficou{Valor} ");

                }
                else if (parcelas > 12)
                {
                    Console.WriteLine($"Nao e possivel parcelar nessa quantidade de vezes!");
                    
                }
            }

        }
    }
}
