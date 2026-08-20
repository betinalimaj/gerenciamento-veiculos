namespace GerenciamentoVeiculos.Main;

public abstract class Veiculo
{
    public int Codigo { get; set; }

    public string Placa { get; set; }

    public string Modelo { get; set; }

    public int Ano { get; set; }

    public Marca Marca { get; set; }

    public string Tipo { get; set; }
}