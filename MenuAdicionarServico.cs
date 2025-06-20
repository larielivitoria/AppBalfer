

using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace Balfer_app;

internal class MenuAdicionarServico
{
    public void Executar()
    {

        string conexao = "server=localhost;database=ordemservico;uid=root;pwd=4161;";

        var conn = new MySqlConnection(conexao);
        conn.Open();


            Console.WriteLine("\n---Adicionar novo serviço---\n");

            Console.WriteLine("Digite o nome da empresa:");
            string empresa = Console.ReadLine();

            Console.WriteLine("Insira a ordem de serviço:");
            int ordem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de serviços:");
            int quantidadeServicos = int.Parse(Console.ReadLine());

        var cmd = new MySqlCommand("INSERT INTO ordemdeservico (empresa, ordem, quantidadeServico) VALUES (@empresa, @ordem, @quantidadeServico)",conn);
        cmd.Parameters.AddWithValue("@empresa", empresa);
        cmd.Parameters.AddWithValue("@ordem", ordem);
        cmd.Parameters.AddWithValue("@quantidadeServico", quantidadeServicos);
        cmd.ExecuteNonQuery();
        
            Console.WriteLine("Serviço Registrado com sucesso...");
            Console.WriteLine("Digite uma tecla para voltar ao Menu");
            Console.ReadKey();
            Console.Clear();
            
       
    }
}
