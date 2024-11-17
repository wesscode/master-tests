using System;
using TechTalk.SpecFlow;

namespace NerdStore.BDD.Tests.Pedido
{
    [Binding]
    public class Pedido_AdicionarItemAoCarrinhoSteps
    {
        [Given(@"O usuario esteja logado")]
        public void DadoOUsuarioEstejaLogado()
        {
            throw new PendingStepException();
        }

        [Given(@"Que um produto esteja na vitrine")]
        public void DadoQueUmProdutoEstejaNaVitrine()
        {
            throw new PendingStepException();
        }

        [Given(@"Esteja disponivel no estoque")]
        public void DadoEstejaDisponivelNoEstoque()
        {
            throw new PendingStepException();
        }

        [Given(@"Não tenha nenhum produto adicionado ao carrinho")]
        public void DadonNaoTenhaNenhumProdutoAdicionadoAoCarrinho()
        {
            throw new PendingStepException();
        }

        [When(@"O usuário adicionar uma unidade ao carrinho")]
        public void QuandoOUsuarioAdicionarUmaUnidadeAoCarrinho()
        {
            throw new PendingStepException();
        }

        [Then(@"O usuário será redirecionado ao resumo da compra")]
        public void EntãoOUsuarioSeraRedirecionadoAoResumoDaCompra()
        {
            throw new PendingStepException();
        }

        [Then(@"O valor total do pedido será exatamente o valor do item adicionado")]
        public void EntãoOValorTotalDoPedidoSeraExatamenteOValorDoItemAdicionado()
        {
            throw new PendingStepException();
        }

        [When(@"O usuário adicionar um item acima da quantidade máxima permitida")]
        public void QuandoOUsuarioAdicionarUmItemAcimaDaQuantidadeMaximaPermitida()
        {
            throw new PendingStepException();
        }

        [Then(@"Receberá uma mensagem de erro mencionando que foi ultrapassada a quantidade limite")]
        public void EntãoReceberaUmaMensagemDeErroMencionandoQueFoiUltrapassadaAQuantidadeLimite()
        {
            throw new PendingStepException();
        }

        [Given(@"O mesmo produto já tenha sido adicionado ao carrinho anteriormente")]
        public void DadoOMesmoProdutoJaTenhaSidoAdicionadoAoCarrinhoAnteriormente()
        {
            throw new PendingStepException();
        }

        [Then(@"A quantidade de itens daquele produto terá sido acrescida em uma unidade a mais")]
        public void EntaoAQuantidadeDeItensDaqueleProdutoTeraSidoAcrescidaEmUmaUnidadeAMais()
        {
            throw new PendingStepException();
        }

        [Then(@"O valor total do pedido será a multiplicação da quantidade de itens pelo valor unitario")]
        public void EntaoOValorTotalDoPedidoSeraAMultiplicacaoDaQuantidadeDeItensPeloValorUnitario()
        {
            throw new PendingStepException();
        }

        [When(@"O usuário adicionar a quantidade máxima permitida ao carrinho")]
        public void QuandoOUsuarioAdicionarAQuantidadeMaximaPermitidaAoCarrinho()
        {
            throw new PendingStepException();
        }

    }
}
