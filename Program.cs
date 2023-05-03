//Sistema de pagamentos
using payment_system;

Pagamento p1 = new Pagamento();
float valor = 0;

char menu()
{
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine($"¦           Sistema de Pagamentos           ¦");
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine();
    
    Console.WriteLine($"Informe o valor da compra: ");
    valor = float.Parse(Console.ReadLine());
    Console.WriteLine();

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

char resposta = '0';

do
{
    Console.WriteLine($"Clique em qualquer botão para continuar.");
    Console.ReadKey();
    Console.Clear();

    Pagamento pagamento;
    resposta = menu();

    switch (resposta)
    {
        case '1':
            Console.Clear();
            Console.WriteLine($"Deseja parcelar? Digite 's' ou 'n'.");
            char respostaP = char.Parse(Console.ReadLine());
            
            int parcela = 0;

            Credito credito = new Credito();
            
            if (respostaP == 's')
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
            Console.Clear();
            Debito debito = new Debito();
            debito.Valor = valor;
            debito.Pagar();
            break;

        case '3':
            Console.Clear();
            Boleto boleto = new Boleto();
            boleto.Valor = valor;
            boleto.Registrar();
            break;
        
        case '4':
            Console.Clear();
            p1.Cancelar();
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (resposta != '0');