using AngleSharp.Html.Parser;
using NerdStore.WebApp.MVC;
using NerdStore.WebApp.Tests.Config;

namespace NerdStore.WebApp.Tests
{
    [Collection(nameof(IntegrationWebTestsFixtureCollection))]
    public class PedidoWebTests
    {
        private readonly IntegrationTestsFixture<StartupWebTests> _testsFixture;

        public PedidoWebTests(IntegrationTestsFixture<StartupWebTests> testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact(DisplayName = "Adicionar item em novo pedido")]
        [Trait("Categoria", "Integração Web - Pedido")]
        public async Task AdicionarItem_NovoPedido_DeveAtualizarValorTotal()
        {
            // Arrange
            var produtorId = new Guid("d986add4-f5ec-422c-bfa3-aaea716c5f67");
            const int quantidade = 2; //aqui podemos buscar do banco, buscar do excel como achar melhor.

            var initialResponse = await _testsFixture.Client.GetAsync($"/produto-detalhe/{produtorId}");
            initialResponse.EnsureSuccessStatusCode();

            var formData = new Dictionary<string, string>
            {
                {"Id", produtorId.ToString()},
                {"quantidade", quantidade.ToString()}
            };

            await _testsFixture.RealizarLoginWeb();

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/meu-carrinho")
            {
                Content = new FormUrlEncodedContent(formData)
            };

            // Act
            var postResponse = await _testsFixture.Client.SendAsync(postRequest);

            // Assert
            postResponse.EnsureSuccessStatusCode();

            var html = new HtmlParser()
                .ParseDocumentAsync(await postResponse.Content.ReadAsStringAsync())
                .Result
                .All;

            var formQuantidade = html?.FirstOrDefault(c => c.Id == "quantidade")?.GetAttribute("value")?.ApenasNumeros();
            var valorUnitario = html?.FirstOrDefault(c => c.Id == "valorUnitario")?.TextContent.Split(".")[0]?.ApenasNumeros();
            var valorTotal = html?.FirstOrDefault(c => c.Id == "valorTotal")?.TextContent.Split(".")[0]?.ApenasNumeros();

            Assert.Equal(valorTotal, valorUnitario * formQuantidade);
        }
    }
}
