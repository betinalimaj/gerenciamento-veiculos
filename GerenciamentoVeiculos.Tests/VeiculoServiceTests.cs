using Microsoft.VisualStudio.TestTools.UnitTesting;
using GerenciamentoVeiculos.Main;
using GerenciamentoVeiculos.Service;
using System;

namespace GerenciamentoVeiculos.Tests
{
    [TestClass]
    public class VeiculoServiceTests
    {
        [TestMethod]
        public void Inserir_DeveGerarErro_QuandoPlacaJaExiste()
        {
            var service = new VeiculoService();

            var carro = new Carro
            {
                Placa = "JJD7DDF", 
                Modelo = "Uno",
                Ano = 2000,
                Marca = new Marca { Codigo = 11 },
                Tipo = "Carro"
            };

            try
            {
                service.Inserir(carro);

                Assert.Fail("Era esperado uma exceção.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(
                    "Já existe outro veículo cadastrado com essa placa!",
                    ex.Message);
            }
        }
    }
}