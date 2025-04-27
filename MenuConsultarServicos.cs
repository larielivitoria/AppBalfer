

namespace Balfer_app;

internal class MenuConsultarServicos
{
    public void Executar(List<KeyValuePair<int, int>> servicos)
    {
        
            foreach (KeyValuePair<int, int> linha in servicos)
            {
                Console.WriteLine("\n---Serviço---");
                Console.WriteLine($"Ordem de Serviço:{linha.Key}");
                Console.WriteLine($"Troca de {linha.Value} cubo de freio\n");
            }

            Console.WriteLine("Digite uma tecla para voltar ao Menu");
            Console.ReadKey();
            Console.Clear();
            
        
    }
}
