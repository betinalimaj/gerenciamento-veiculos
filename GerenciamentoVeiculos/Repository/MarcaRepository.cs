using GerenciamentoVeiculos.Main;
using Npgsql;

namespace GerenciamentoVeiculos.Repository;

public class MarcaRepository
{
    public void Inserir(Marca marca)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand("INSERT INTO marca (nome) VALUES (@nome)", banco);
        comando.Parameters.AddWithValue("@nome", marca.Nome);
        comando.ExecuteNonQuery();

    }

    public List<Marca> Listar()
    {
        List<Marca> marcas = new List<Marca>();

        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand("SELECT codigo, nome FROM marca ORDER BY nome", banco);
        using NpgsqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {

            Marca marca = new Marca
            {
                Codigo = reader.GetInt32(reader.GetOrdinal("codigo")),
                Nome = reader.GetString(reader.GetOrdinal("nome"))
            };
            marcas.Add(marca);
        }

        return marcas;
    }

    public void Alterar(Marca marca)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand("UPDATE marca SET nome = @nome WHERE codigo = @codigo", banco);
        comando.Parameters.AddWithValue("@nome", marca.Nome);
        comando.Parameters.AddWithValue("@codigo", marca.Codigo);
        comando.ExecuteNonQuery();

    }

public void Excluir(int codigo)
{
    Conexao conexao = new Conexao();

    using NpgsqlConnection banco = conexao.AbrirConexao();

    NpgsqlCommand comando = new NpgsqlCommand(
        "DELETE FROM marca WHERE codigo = @codigo", banco);

    comando.Parameters.AddWithValue("@codigo", codigo);

    try
    {
        comando.ExecuteNonQuery();
    }
    catch (PostgresException)
    {
        throw new Exception("Erro ao excluir. Existe um veículo vinculado a essa marca.");
    }
}

    public bool Existe(string nome)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand(
            "SELECT COUNT(*) FROM marca WHERE LOWER(nome) = LOWER(@nome)",
            banco);

        comando.Parameters.AddWithValue("@nome", nome);

        int quantidade = Convert.ToInt32(comando.ExecuteScalar());

        return quantidade > 0;
    }

}