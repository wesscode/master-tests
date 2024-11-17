using TechTalk.SpecFlow;

namespace NerdStore.BDD.Tests.Pedido
{
    [Binding]
    public class Pedido_AdicionarItemAoCarrinhoSteps
    {
        [Given(@"O usuario esteja logado")]
        public void DadoOUsuarioEstejaLogado() // Arrage do BDD
        {            
            //AAA do passo*

            // Arrange

            // Act

            // Assert
        }

        [Given(@"Que um produto esteja na vitrine")]
        public void DadoQueUmProdutoEstejaNaVitrine()
        {
            // Arrange

            // Act

            // Assert
        }

        [Given(@"Esteja disponivel no estoque")]
        public void DadoEstejaDisponivelNoEstoque()
        {
            // Arrange

            // Act

            // Assert
        }

        [Given(@"Não tenha nenhum produto adicionado ao carrinho")]
        public void DadonNaoTenhaNenhumProdutoAdicionadoAoCarrinho()
        {
            // Arrange

            // Act

            // Assert
        }

        [When(@"O usuário adicionar uma unidade ao carrinho")]
        public void QuandoOUsuarioAdicionarUmaUnidadeAoCarrinho()
        {
            // Arrange

            // Act

            // Assert
        }

        [Then(@"O usuário será redirecionado ao resumo da compra")]
        public void EntãoOUsuarioSeraRedirecionadoAoResumoDaCompra()
        {
            // Arrange

            // Act

            // Assert
        }

        [Then(@"O valor total do pedido será exatamente o valor do item adicionado")]
        public void EntãoOValorTotalDoPedidoSeraExatamenteOValorDoItemAdicionado()
        {
            // Arrange

            // Act

            // Assert
        }

        [When(@"O usuário adicionar um item acima da quantidade máxima permitida")]
        public void QuandoOUsuarioAdicionarUmItemAcimaDaQuantidadeMaximaPermitida()
        {
            // Arrange

            // Act

            // Assert
        }

        [Then(@"Receberá uma mensagem de erro mencionando que foi ultrapassada a quantidade limite")]
        public void EntãoReceberaUmaMensagemDeErroMencionandoQueFoiUltrapassadaAQuantidadeLimite()
        {
            // Arrange

            // Act

            // Assert
        }

        [Given(@"O mesmo produto já tenha sido adicionado ao carrinho anteriormente")]
        public void DadoOMesmoProdutoJaTenhaSidoAdicionadoAoCarrinhoAnteriormente()
        {
            // Arrange

            // Act

            // Assert
        }

        [Then(@"A quantidade de itens daquele produto terá sido acrescida em uma unidade a mais")]
        public void EntaoAQuantidadeDeItensDaqueleProdutoTeraSidoAcrescidaEmUmaUnidadeAMais()
        {
            // Arrange

            // Act

            // Assert
        }

        [Then(@"O valor total do pedido será a multiplicação da quantidade de itens pelo valor unitario")]
        public void EntaoOValorTotalDoPedidoSeraAMultiplicacaoDaQuantidadeDeItensPeloValorUnitario()
        {
            // Arrange

            // Act

            // Assert
        }

        [When(@"O usuário adicionar a quantidade máxima permitida ao carrinho")]
        public void QuandoOUsuarioAdicionarAQuantidadeMaximaPermitidaAoCarrinho()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
