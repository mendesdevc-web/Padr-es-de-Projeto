using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Pedido
{
    public class PedidoCommand
    {
        public int ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }

        // Construtor para garantir que ninguém altere os dados no caminho
        public PedidoCommand(int produtoId, int quantidade, decimal preco)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
