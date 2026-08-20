using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciamentoVeiculos.Service;
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
                service.Excluir(11); 

                Assert.Fail("Era esperado uma exceção.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(
                    "Não é possível excluir esta marca, pois ela está vinculada a um ou mais veículos.",
                    ex.Message);
            }
        }
    }
}