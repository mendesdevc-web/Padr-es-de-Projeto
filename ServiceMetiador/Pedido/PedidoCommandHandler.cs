using Metiador.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Pedido
{
    public class PedidoCommandHandler
    {
        public PedidoResponse Executar(PedidoCommand comando)
        {
            // 1. Aqui você simularia a inserção no banco de dados Relacional/Lento
            Console.WriteLine($"[COMMAND HANDLER] Salvando pedido do produto {comando.ProdutoId} no banco de escrita...");

            // 2. Calcula o total (Regra de negócio)
            decimal total = comando.Quantidade * comando.Preco;

            // 3. Retorna o DTO de resposta (recibo)
            return new PedidoResponse
            {
                PedidoId = new Random().Next(1000, 9999),
                Status = "Criado e Pago",
                DataCriacao = DateTime.Now,
                ValorTotal = total
            };

        }
    }
}
