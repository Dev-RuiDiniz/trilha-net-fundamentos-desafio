using DesafioFundamentos.Models;
using System.Globalization;

// Configura UTF8 para acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Função auxiliar para ler decimal com validação
decimal LerDecimal(string mensagem)
{
    decimal valor;
    while (true)
    {
        Console.WriteLine(mensagem);
        if (decimal.TryParse(Console.ReadLine(), out valor) && valor >= 0)
            return valor;
        Console.WriteLine("Valor inválido. Digite um número válido.");
    }
}

// Solicita preços com validação
decimal precoInicial = LerDecimal("Digite o preço inicial:");
decimal precoPorHora = LerDecimal("Digite o preço por hora:");

// Instancia estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // Validar placa
            string placa;
            do
            {
                Console.WriteLine("Digite a placa do veículo:");
                placa = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(placa))
                    Console.WriteLine("Placa inválida. Digite novamente.");
            } while (string.IsNullOrWhiteSpace(placa));

            es.AdicionarVeiculo(placa);
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou!");
