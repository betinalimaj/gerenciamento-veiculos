using GerenciamentoVeiculos.Main;
using GerenciamentoVeiculos.Repository;

namespace GerenciamentoVeiculos.Service;

public class MarcaService
{
    private readonly MarcaRepository repository = new MarcaRepository();

    public void Inserir(Marca marca)
    {
        if (string.IsNullOrWhiteSpace(marca.Nome))
        {
            throw new ArgumentException("Preencha o nome da marca!");
        }
        if (repository.Existe(marca.Nome))
        {
            throw new ArgumentException("Marca já cadastrada!");
        }
        repository.Inserir(marca);
    }

    public List<Marca> Listar()
    {
        return repository.Listar();
    }

    public void Alterar(Marca marca)
    {
        if (string.IsNullOrWhiteSpace(marca.Nome))
        {
            throw new ArgumentException("Preencha o nome da marca!");
        }
        repository.Alterar(marca);
    }

    public void Excluir(int codigo)
    {
        repository.Excluir(codigo);
    }

}