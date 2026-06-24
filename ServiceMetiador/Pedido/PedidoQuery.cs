using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Pedido
{
    public class PedidoQuery
    {
        public int PedidoId { get; private set; }

        // O construtor garante que o ID da busca não seja alterado no caminho
        public PedidoQuery(int pedidoId)
        {
            PedidoId = pedidoId;
        }
    }
}
