using MySql.Data.MySqlClient;

namespace Balfer_app.Menus;

internal class MenuConsultarServicos
{
    public void Executar()
    {

        string conexao = "server=localhost;database=ordemservico;uid=root;pwd=4161;";

        var conn = new MySqlConnection(conexao);
        conn.Open();

        Console.WriteLine("Lista de Ordens");

        var cmd = new MySqlCommand("SELECT * FROM ordemdeservico",conn);
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Empresa: {reader["empresa"]}");
            Console.WriteLine($"Ordem de serviço:  {reader["ordem"]}");
            Console.WriteLine($"Troca de {reader["quantidadeServico"]} Cubo de Freio");
            Console.WriteLine("----------------------");
        }

        conn.Close();

        Console.WriteLine("Digite uma tecla para voltar ao Menu");
            Console.ReadKey();
            Console.Clear();
            
        
    }
}
