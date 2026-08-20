using Npgsql;

namespace GerenciamentoVeiculos.Repository;

public class Conexao
{
    private readonly string stringConexao =
        "Host=localhost;Port=5432;Database=gerenciamento_veiculos;Username=postgres;Password=1234";

    public NpgsqlConnection AbrirConexao()
    {
        NpgsqlConnection conexao = new NpgsqlConnection(stringConexao);
        conexao.Open();

        return conexao;
    }
}