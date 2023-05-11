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
    5 - Sair
    ");
    return char.Parse(Console.ReadLine());
}

char resposta = '0';

void CadastroCartão(Cartao cartao)
{
    Console.WriteLine($"Primeiramente, vamos cadastrar seu cartão!");
    Console.Write($"Insira o titular: ");
    string titular = Console.ReadLine();
    Console.Write($"Insira a bandeira: ");
    string bandeira = Console.ReadLine();
    Console.Write($"Insira o número do cartão: ");
    string numero = Console.ReadLine();
    Console.Write($"Insira o CVV: ");
    string cvv = Console.ReadLine();

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(cartao.SalvarCartao(bandeira, numero, titular, cvv));
    Console.ResetColor(); 
    Console.WriteLine(); 
}

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

            Credito credito = new Credito();
            CadastroCartão(credito);

            Console.WriteLine($"Deseja parcelar? Digite 's' ou 'n'.");
            char respostaP = char.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int parcela = 0;

            
            if (respostaP == 's')
            {
                Console.WriteLine($"Em quantas vezes?");
                parcela = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            credito.parcelas = parcela;
            credito.Valor = valor;
            credito.Pagar();
            p1 = credito;
            break;

        case '2':
            Console.Clear();
            Debito debito = new Debito();
            CadastroCartão(debito);
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(p1.Cancelar());
            Console.ResetColor();
            break;

        case '5':
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inválida!");
            Console.ResetColor();
            break;
    }
} while (resposta != '5');