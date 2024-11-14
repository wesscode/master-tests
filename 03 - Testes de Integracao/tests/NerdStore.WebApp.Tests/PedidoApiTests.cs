using Features.Tests;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NerdStore.WebApp.MVC.Models;
using NerdStore.WebApp.Tests.Config;
using System.Net.Http.Json;

namespace NerdStore.WebApp.Tests
{
    [TestCaseOrderer("Features.Tests.PriorityOrderer", "Features.Tests")]
    [Collection(nameof(IntegrationApiTestsFixtureCollection))]
    public class PedidoApiTests
    {
        private readonly IntegrationTestsFixture<Program> _testsFixture;

        public PedidoApiTests(IntegrationTestsFixture<Program> testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact(DisplayName = "Adicionar item em novo pedido"), TestPriority(1)]
        [Trait("Categoria", "Integração API - Pedido")]
        public async Task AdicionarItem_NovoPedido_DeveRetornarComSucesso()
        {
            // Arrange
            var itemInfo = new ItemViewModel
            {
                Id = new Guid("d986add4-f5ec-422c-bfa3-aaea716c5f67"),
                Quantidade = 2
            };

            //await _testsFixture.RealizarLoginApi();
            //_testsFixture.Client.AtribuirToken(_testsFixture.UsuarioToken);

            // Act
            var postResponse = await _testsFixture.Client.PostAsJsonAsync("api/carrinho", itemInfo);

            // Assert
            postResponse.EnsureSuccessStatusCode();
        }
    }
}
