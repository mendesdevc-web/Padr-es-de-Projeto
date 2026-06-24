using Metiador.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Pedido
{
    public class PedidoQueryHandler
    {
        public PedidoResponse Executar(PedidoQuery query)
        {
            // 1. Aqui simulamos a busca direta no banco de dados RÁPIDO (NoSQL/Cache)
            Console.WriteLine($"[QUERY HANDLER] Procurando o Pedido #{query.PedidoId} no banco de leitura rápido...");

            // 2. Simula que encontrou os dados e monta o DTO de resposta
            // (Note que aqui não há cálculos nem regras de negócio pesadas, é só entrega de dados)
            return new PedidoResponse
            {
                PedidoId = query.PedidoId,
                Status = "Entregue e Finalizado", // Dado que veio do banco rápido
                DataCriacao = DateTime.Now.AddDays(-1),
                ValorTotal = 299.90m
            };
        }
    }
}
