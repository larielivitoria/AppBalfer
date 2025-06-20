
using Balfer_app;


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
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                MenuAdicionarServico menu1 = new MenuAdicionarServico();
                menu1.Executar();
                Menu();
                
            }break;
        case 2:
            {
                MenuConsultarServicos menu2 = new MenuConsultarServicos();
                menu2.Executar();
                Menu();
                
            }break;
        default:
            {
                Console.WriteLine("Opção Inválida");
            }break;
    }
}

Menu();


