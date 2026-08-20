using System;
using System.IO;
using System.Windows.Forms;

namespace GerenciamentoVeiculos
{
    public static class Logger
    {
        private static readonly string CaminhoLog = "log.txt";

        public static void RegistrarErro(Exception ex)
        {
            string caminhoCompleto = Path.GetFullPath(CaminhoLog);

            MessageBox.Show(caminhoCompleto);

            File.AppendAllText(
                CaminhoLog,
                $"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}]{Environment.NewLine}" +
                $"Mensagem: {ex.Message}{Environment.NewLine}" +
                $"Detalhes: {ex.StackTrace}{Environment.NewLine}" +
                "--------------------------------------------------" +
                Environment.NewLine
            );
        }
    }
}