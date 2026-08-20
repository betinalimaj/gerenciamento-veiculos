using GerenciamentoVeiculos.UI;

namespace GerenciamentoVeiculos;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormPrincipal());
    }
}