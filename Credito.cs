namespace store_system_project
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
                    Console.WriteLine($" o Valor da compra ficou {Valor * 0.95} parcelado em 6x.");

                }
                else if (parcelas <= 12 && parcelas >= 7)
                {
                    Console.WriteLine($" o valor da compra ficou {Valor * 0.92}");

                }
                else if (parcelas = 0)
                {
                    Console.WriteLine($"o valor da sua compra ficou{Valor} ");

                }
            }

        }
    }
}
