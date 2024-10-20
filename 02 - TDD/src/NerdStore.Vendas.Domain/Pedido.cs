using System.Collections.ObjectModel;

namespace NerdStore.Vendas.Domain
{
    public class Pedido
    {
        public Pedido()
        {
            _pedidoItems = new List<PedidoItem>();
        }

        public decimal ValorTotal { get; private set; }

        private readonly List<PedidoItem> _pedidoItems;
        public IReadOnlyCollection<PedidoItem> PedidoItems => _pedidoItems;

        public void AdicionarItem(PedidoItem pedidoItem)
        {
            _pedidoItems.Add(pedidoItem);
            ValorTotal = PedidoItems.Sum(i => i.Quantidade * i.ValorUnitario);
        }
    }
}
