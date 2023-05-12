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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Cartao recusado! O valor excede o limite.");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                if (parcelas == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor da compra ficou {(Valor* 1.05):C} com juros de 5%.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else if (parcelas <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor da compra ficou {(Valor * 1.05):C} com juros de 5%.");
                    Console.WriteLine($"Com o valor de cada parcela de {(Valor * 1.05/parcelas):C}.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else if (parcelas <= 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"O valor da compra ficou {(Valor * 1.08):C} com juros de 8%.");
                    Console.WriteLine($"Com o valor de cada parcela de {(Valor * 1.08/parcelas):C}.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else if (parcelas > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Não é possível parcelar nessa quantidade de vezes!");   
                    Console.WriteLine();
                    Console.ResetColor();
                }

            }
        }
    }
}
