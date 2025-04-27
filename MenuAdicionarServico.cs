

namespace Balfer_app;

internal class MenuAdicionarServico
{
    public void Executar(List<KeyValuePair<int, int>> servicos)
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
            
       
    }
}
