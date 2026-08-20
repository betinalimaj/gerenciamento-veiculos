using GerenciamentoVeiculos.Main;
using Npgsql;

namespace GerenciamentoVeiculos.Repository;

public class VeiculoRepository
{
    public void Inserir(Veiculo veiculo)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand(
            @"INSERT INTO veiculo (placa, modelo, ano, marca_id, tipo)
          VALUES (@placa, @modelo, @ano, @marca, @tipo)", banco);

        comando.Parameters.AddWithValue("@placa", veiculo.Placa);
        comando.Parameters.AddWithValue("@modelo", veiculo.Modelo);
        comando.Parameters.AddWithValue("@ano", veiculo.Ano);
        comando.Parameters.AddWithValue("@marca", veiculo.Marca.Codigo);
        comando.Parameters.AddWithValue("@tipo", veiculo.Tipo);

        comando.ExecuteNonQuery();
    }

    public List<Veiculo> Listar()
    {
        List<Veiculo> veiculos = new List<Veiculo>();

        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand(@" SELECT v.codigo AS codigo_veiculo, v.placa, v.modelo, v.ano, v.tipo, m.codigo AS codigo_marca, m.nome AS nome_marca FROM veiculo v INNER JOIN marca m ON v.marca_id = m.codigo ORDER BY v.modelo", banco);

        using NpgsqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {
            Veiculo veiculo;

            string tipo = reader.GetString(reader.GetOrdinal("tipo"));

            if (tipo == "Carro")
                veiculo = new Carro();
            else
                veiculo = new Moto();

            veiculo.Codigo = reader.GetInt32(reader.GetOrdinal("codigo_veiculo"));
            veiculo.Placa = reader.GetString(reader.GetOrdinal("placa"));
            veiculo.Modelo = reader.GetString(reader.GetOrdinal("modelo"));
            veiculo.Ano = reader.GetInt32(reader.GetOrdinal("ano"));
            veiculo.Tipo = tipo;

            veiculo.Marca = new Marca
            {
                Codigo = reader.GetInt32(reader.GetOrdinal("codigo_marca")),
                Nome = reader.GetString(reader.GetOrdinal("nome_marca"))
            };

            veiculos.Add(veiculo);
        }

        return veiculos;
    }

    public void Alterar(Veiculo veiculo)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand(@"UPDATE veiculo SET placa = @placa, modelo = @modelo, ano = @ano, marca_id = @marca, tipo = @tipo WHERE codigo = @codigo", banco);
        comando.Parameters.AddWithValue("@placa", veiculo.Placa);
        comando.Parameters.AddWithValue("@modelo", veiculo.Modelo);
        comando.Parameters.AddWithValue("@ano", veiculo.Ano);
        comando.Parameters.AddWithValue("@marca", veiculo.Marca.Codigo);
        comando.Parameters.AddWithValue("@tipo", veiculo.Tipo);
        comando.Parameters.AddWithValue("@codigo", veiculo.Codigo);
        comando.ExecuteNonQuery();
    }

    public void Excluir(int codigo)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand("DELETE FROM veiculo WHERE codigo = @codigo", banco);
        comando.Parameters.AddWithValue("@codigo", codigo);
        comando.ExecuteNonQuery();

    }

    public bool Existe(string placa)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand(
            "SELECT COUNT(*) FROM veiculo WHERE LOWER(placa) = LOWER(@placa)",
            banco);

        comando.Parameters.AddWithValue("@placa", placa);

        int quantidade = Convert.ToInt32(comando.ExecuteScalar());

        return quantidade > 0;
    }

    public bool Existe(string placa, int codigo)
    {
        Conexao conexao = new Conexao();

        using NpgsqlConnection banco = conexao.AbrirConexao();

        NpgsqlCommand comando = new NpgsqlCommand(
            @"SELECT COUNT(*)
          FROM veiculo
          WHERE LOWER(placa) = LOWER(@placa)
          AND codigo <> @codigo", banco);

        comando.Parameters.AddWithValue("@placa", placa);
        comando.Parameters.AddWithValue("@codigo", codigo);

        int quantidade = Convert.ToInt32(comando.ExecuteScalar());

        return quantidade > 0;
    }

}