//Sistema de pagamentos
using payment_system;

static char menu()
{
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine($"¦           Sistema de Pagamentos           ¦");
    Console.WriteLine($"---------------------------------------------");

    Console.WriteLine($"Informe o valor da compra: ");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine(@$"
    Qual a forma de pagamento?
    1 - Cartão de crédito
    2 - Cartão de débito
    3 - Boleto
    4 - Cancelar operação

    0 - Sair
    ");
    return char.Parse(Console.ReadLine());
}

do
{
    switch (menu())
    {
        case '1':
            Console.WriteLine($"Deseja parcelar? Digite 's' ou 'n'.");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {

            }
            else
            {

            }
            break;

        case '2':
            break;

        case '3':
            //desconto de 12%
            //exibir código de barras
            break;
        
        case '4':
            ;
            break;
    }
} while (menu() != '0');