using GerenciamentoVeiculos.Main;
using GerenciamentoVeiculos.Repository;

namespace GerenciamentoVeiculos.Service;

public class VeiculoService
{
    private readonly VeiculoRepository repository = new VeiculoRepository();

    public void Inserir(Veiculo veiculo)
    {
        if (string.IsNullOrWhiteSpace(veiculo.Placa))
        {
            throw new ArgumentException("Preencha a placa do veículo!");
        }

        if (repository.Existe(veiculo.Placa, veiculo.Codigo))
        {
            throw new ArgumentException("Já existe outro veículo cadastrado com essa placa!");
        }
        if (string.IsNullOrWhiteSpace(veiculo.Modelo))
        {
            throw new ArgumentException("Preencha o modelo do veículo!");
        }

        if (veiculo.Ano < 1950 || veiculo.Ano > DateTime.Now.Year)
        {
            throw new ArgumentException("Informe um ano válido!");
        }

        if (veiculo.Marca == null || veiculo.Marca.Codigo <= 0)
        {
            throw new ArgumentException("Selecione uma marca!");
        }

        if (string.IsNullOrWhiteSpace(veiculo.Tipo))
        {
            throw new ArgumentException("Selecione o tipo do veículo!");
        }

        repository.Inserir(veiculo);
    }

    public List<Veiculo> Listar()
    {
        return repository.Listar();
    }

    public void Alterar(Veiculo veiculo)
    {
        if (string.IsNullOrWhiteSpace(veiculo.Placa))
        {
            throw new ArgumentException("Preencha a placa do veículo!");
        }

        // APAGUE ESTE TRECHO
        /*
        if (repository.Existe(veiculo.Placa))
        {
            throw new ArgumentException("Já existe um veículo cadastrado com essa placa!");
        }
        */

        if (string.IsNullOrWhiteSpace(veiculo.Modelo))
        {
            throw new ArgumentException("Preencha o modelo do veículo.");
        }

        if (veiculo.Ano < 1950 || veiculo.Ano > DateTime.Now.Year)
        {
            throw new ArgumentException("Ano inválido.");
        }

        if (veiculo.Marca == null || veiculo.Marca.Codigo <= 0)
        {
            throw new ArgumentException("Selecione uma marca.");
        }

        if (string.IsNullOrWhiteSpace(veiculo.Tipo))
        {
            throw new ArgumentException("Tipo do veículo inválido.");
        }

        repository.Alterar(veiculo);
    }

    public void Excluir(int codigo)
    {
        repository.Excluir(codigo);
    }

}