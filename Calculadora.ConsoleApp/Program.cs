// Requisito 01: Nossa calculadora deve permtir a soma de dois números
// Requisito 02: Nossa calculadora deve permtir a subtração de dois números
// Requisito 03: Nossa calculadora deve permtir a multiplicação de dois números
// Requisito 04: Nossa calculadora deve permtir a divisão de dois números
// Requisito 05: Nossa calculadora deve permitir a execução de múltiplas operações

bool deveContinuar = true; // atribuição

while (deveContinuar == true) // condição
{
    // Console.Clear();

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.WriteLine("Selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue;
    }

    Console.WriteLine("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
       Console.WriteLine("Digite um número válido!");
       Console.ReadLine();

       continue; 
    }

    decimal numeroDecimal = 1.1234567m;

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;

    switch(operacaoSelecionada) // operador do switch
    {
        case "1": 
            resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            break;
        
         case "3":
            resultado = primeiroNumero * segundoNumero;
            break;
        
         case "4":
            if (segundoNumero == 0)
        {
            Console.WriteLine("Não é possível fazer uma divisão por zero. Tente novamente.");

            return;
        }

         resultado = primeiroNumero / segundoNumero;
         break;
    
    default:
        Console.WriteLine("Selecione uma operação válida!");
        Console.ReadLine(); 

        continue;
    }

    Console.WriteLine("A operação dos dois números resulta em: " + resultado);

    Console.ReadLine();
}
