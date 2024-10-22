using NerdStore.Core.DomainObjects;
using Xunit;

namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoTests
    {
        [Fact(DisplayName = "Adicionar Item Novo Pedido")]
        [Trait("Categoria", "Pedido Tests")]
        public void AdicionarItemPedido_NovoPedido_DeveAtualizarValor()
        {
            // Arrange
            var pedido = Pedido.PedidoFactory.NovoPedidoRascunho(Guid.NewGuid());
            var pedidoItem = new PedidoItem(Guid.NewGuid(), "Produto Teste", 2, 100);

            // Act
            pedido.AdicionarItem(pedidoItem);

            // Assert
            Assert.Equal(200, pedido.ValorTotal);
        }

        [Fact(DisplayName = "Adicionar Item Pedido Existente")]
        [Trait("Categoria", "Pedido Tests")]
        public void AdicioanarItemPedido_ItemExistente_DeveIncrementarUnidadesSomarValores()
        {
            // Arrange
            var pedido = Pedido.PedidoFactory.NovoPedidoRascunho(Guid.NewGuid());
            var pedidoId = Guid.NewGuid();
            var pedidoItem = new PedidoItem(pedidoId, "Produto Teste", 2, 100);
            pedido.AdicionarItem(pedidoItem);

            var pedidoItem2 = new PedidoItem(pedidoId, "Produto Teste", 1, 100);

            // Act
            pedido.AdicionarItem(pedidoItem2);

            // Assert
            Assert.Equal(300, pedido.ValorTotal);
            Assert.Equal(1, pedido.PedidoItems.Count);
            Assert.Equal(3, pedido.PedidoItems.FirstOrDefault(p => p.ProdutoId == pedidoId).Quantidade);
        }

        [Fact(DisplayName = "Adicionar Item Pedido Acima do permitido")]
        [Trait("Categoria", "Pedido Tests")]
        public void AdicionarItemPedido_UnidadesItemAcimaDoPermitido_DeveRetornarException()
        {
            // Arrange
            var pedido = Pedido.PedidoFactory.NovoPedidoRascunho(Guid.NewGuid());
            var produtoId = Guid.NewGuid();
            var pedidoItem = new PedidoItem(produtoId, "Produto Teste", Pedido.MAX_UNIDADES_ITENS + 1, 100);

            // Act & Assert
            Assert.Throws<DomainException>(() => pedido.AdicionarItem(pedidoItem));
        }
    }
}
