using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciamentoVeiculos.Service;
using GerenciamentoVeiculos.Main;
using System;

namespace GerenciamentoVeiculos.Tests
{
    [TestClass]
    public class MarcaServiceTests
    {
        [TestMethod]
        public void Excluir_DeveGerarErro_QuandoMarcaPossuiVeiculo()
        {
            var service = new MarcaService();

            try
            {
                service.Excluir(23);

                Assert.Fail("Era esperado uma exceção.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(
                    "Erro ao excluir. Existe um veículo vinculado a essa marca.",
                    ex.Message);
            }
        }
    }
}