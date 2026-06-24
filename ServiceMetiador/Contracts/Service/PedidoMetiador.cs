using Metiador.Service.Contracts.Interface;
using Metiador.Service.Dto;
using Metiador.Service.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Contracts.Service
{
    public class PedidoMetiador :IPedidoMetiador
    {
        private readonly PedidoCommandHandler _commandHandler = new PedidoCommandHandler();
        private readonly PedidoQueryHandler _queryHandler = new PedidoQueryHandler();

        public PedidoResponse EnviarComando(PedidoCommand comando)
        {
            // Quando chega um comando, ele joga para o manipulador de comando
            return _commandHandler.Executar(comando);
        }

        public PedidoResponse EnviarConsulta(PedidoQuery consulta)
        {
            // Quando chega uma consulta, ele joga para o manipulador de consulta
            return _queryHandler.Executar(consulta);
        }
    }
}
