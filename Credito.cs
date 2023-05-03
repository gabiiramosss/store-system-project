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
                if (parcelas == 0)
                {
                    Console.WriteLine($"O valor da compra ficou R${Valor* 1.05} com juros de 5%.");
                }
                else if (parcelas <= 6)
                {
                    Console.WriteLine($"O valor da compra ficou R${Valor * 1.05} com juros de 5%.");
                    Console.WriteLine($"Com o valor de cada parcela de R${Valor * 1.05/parcelas}.");
                }
                else if (parcelas <= 12)
                {
                    Console.WriteLine(@$"O valor da compra ficou R${Valor * 1.08} com juros de 8%.");
                    Console.WriteLine($"Com o valor de cada parcela de R${Valor * 1.08/parcelas}.");
                }
                else if (parcelas > 12)
                {
                    Console.WriteLine($"Não é possível parcelar nessa quantidade de vezes!");   
                }

            }
        }
    }
}
