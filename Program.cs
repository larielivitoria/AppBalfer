
int opcao = 0;
List<KeyValuePair<int, int>> servicos = new List<KeyValuePair<int, int>>();
servicos.Add(new KeyValuePair<int, int>(1555, 10));

void Logo()
{
    Console.WriteLine(@"
█▄─▄─▀██▀▄─██▄─▄███▄─▄▄─█▄─▄▄─█▄─▄▄▀█
██─▄─▀██─▀─███─██▀██─▄████─▄█▀██─▄─▄█
▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀
");
}

void Menu()
{
    Logo();
    Console.WriteLine("Seja Bem Vindo a Balfer");

    Console.WriteLine("[1] adicionar novo serviço");
    Console.WriteLine("[2] consultar serviços");
    Console.Write("Digite uma opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                AdicionarNovoServico();
            }break;
        case 2:
            {
                ConsultarServicos();
            }break;
        default:
            {
                Console.WriteLine("Opção Inválida");
            }break;
    }
}

Menu();

void AdicionarNovoServico()
{
    Console.WriteLine("\n---Adicionar novo serviço---\n");
    Console.WriteLine("Insira a ordem de serviço:");
    int ordem = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de serviços:");
    int quantidadeServicos = int.Parse(Console.ReadLine());

    servicos.Add(new KeyValuePair<int, int>(ordem, quantidadeServicos));

    Console.WriteLine("Serviço Registrado com sucesso...");
    Console.WriteLine("Digite uma tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void ConsultarServicos()
{
    foreach(KeyValuePair<int,int> linha in servicos)
    {
        Console.WriteLine("\n---Serviço---");
        Console.WriteLine($"Ordem de Serviço:{linha.Key}");
        Console.WriteLine($"Troca de {linha.Value} cubo de freio\n");
    }
    
    Console.WriteLine("Digite uma tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}