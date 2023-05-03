//Sistema de pagamentos
using payment_system;

Pagamento p1 = new Pagamento();
float valor = 0;

char menu()
{
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine($"¦           Sistema de Pagamentos           ¦");
    Console.WriteLine($"---------------------------------------------");

    Console.WriteLine($"Informe o valor da compra: ");
    valor = float.Parse(Console.ReadLine());

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
    Pagamento pagamento;
    switch (menu())
    {
        case '1':
            Console.WriteLine($"Deseja parcelar? Digite 's' ou 'n'.");
            char resposta = char.Parse(Console.ReadLine());
            
            int parcela = 0;

            Credito credito = new Credito();
            
            if (resposta == 's')
            {
                Console.WriteLine($"Em quantas vezes?");
                parcela = int.Parse(Console.ReadLine());
            }
            credito.parcelas = parcela;
            credito.Valor = valor;
            credito.Pagar();
            p1 = credito;
            break;

        case '2':
            Debito debito = new Debito();
            debito.Valor = valor;
            debito.Pagar();
            break;

        case '3':
            //desconto de 12%
            //exibir código de barras
            break;
        
        case '4':
            p1.Cancelar();
            break;
    }
} while (menu() != '0');