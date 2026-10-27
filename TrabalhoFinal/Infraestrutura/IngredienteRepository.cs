
using Microsoft.Data.Sqlite;
using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Infraestrutura
{
    public class IngredienteRepository
    {
        private const string MeuBanco = "Data Source=Ingredientes.db";

        public static void Inicializar()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                CREATE TABLE IF NOT EXISTS Ingredientes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Quantidade REAL NOT NULL,
                    Validade TEXT NOT NULL,
                    Fabricante TEXT NOT NULL
                );
            ";

            comando.ExecuteNonQuery();
        }

        public static void Adicionar(Ingredientes ingrediente)
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                INSERT INTO Ingredientes
                (Nome, Quantidade, Validade, Fabricante)
                VALUES
                ($nome, $quantidade, $validade, $fabricante);
            ";

            comando.Parameters.AddWithValue("$nome", ingrediente.Nome);
            comando.Parameters.AddWithValue("$quantidade", ingrediente.Quantidade);
            comando.Parameters.AddWithValue(
                "$validade",
                ingrediente.Validade.ToString("yyyy-MM-dd")
            );
            comando.Parameters.AddWithValue("$fabricante", ingrediente.Fabricante);

            comando.ExecuteNonQuery();
        }

        public static List<Ingredientes> Listar()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                SELECT Id, Nome, Quantidade, Validade, Fabricante
                FROM Ingredientes
                ORDER BY Id;
            ";

            using var leitor = comando.ExecuteReader();

            List<Ingredientes> ingredientes = new List<Ingredientes>();

            while (leitor.Read())
            {
                Ingredientes ingrediente = new Ingredientes();

                ingrediente.Id = leitor.GetInt32(0);
                ingrediente.Nome = leitor.GetString(1);
                ingrediente.Quantidade = leitor.GetDouble(2);
                ingrediente.Validade = DateTime.Parse(leitor.GetString(3));
                ingrediente.Fabricante = leitor.GetString(4);

                ingredientes.Add(ingrediente);
            }

            return ingredientes;
        }
    }
}
