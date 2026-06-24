using Metiador.Service.Dto;
using Metiador.Service.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Contracts.Interface
{
    public interface IPedidoMetiador
    {
        // Método para o fluxo de escrita
        PedidoResponse EnviarComando(PedidoCommand comando);

        // Método para o fluxo de leitura
        PedidoResponse EnviarConsulta(PedidoQuery consulta);
    }
}
