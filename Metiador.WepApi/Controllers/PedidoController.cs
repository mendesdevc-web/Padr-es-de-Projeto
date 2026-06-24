using Metiador.Service.Contracts.Interface;
using Metiador.Service.Contracts.Service;
using Metiador.Service.Dto;
using Metiador.Service.Pedido;
using Microsoft.AspNetCore.Mvc;

namespace Metiador.WepApi.Controllers
{
    [ApiController]
    [Route("api/pedidos")] 
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoMetiador _mediatorPedido;

        public PedidoController(IPedidoMetiador mediatorPedido)
        {
            _mediatorPedido = mediatorPedido;
        }

        [HttpPost]
        public IActionResult CriarPedido([FromBody] PedidoResquest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var comando = new PedidoCommand(
                request.ProdutoId!.Value,
                request.Quantidade,
                request.Preco
            );

            PedidoResponse resposta = _mediatorPedido.EnviarComando(comando);

            return CreatedAtAction(nameof(ObterPedidoPorId), new { id = resposta.PedidoId }, resposta);
        }

        [HttpGet("{id:int}")]
        public IActionResult ObterPedidoPorId(int id)
        {
            var consulta = new PedidoQuery(id);

            PedidoResponse resposta = _mediatorPedido.EnviarConsulta(consulta);

            return Ok(resposta);
        }
    }
}
