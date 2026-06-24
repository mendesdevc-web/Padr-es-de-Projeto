using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metiador.Service.Dto
{
    public class PedidoResquest
    {
        [Required(ErrorMessage = "O ID do produto é obrigatório.")]
        public int? ProdutoId { get; set; }

        [Range(1, 99, ErrorMessage = "A quantidade permitida deve ser entre 1 e 99 unidades.")]
        public int Quantidade { get; set; }

        [Range(0.01, 999999.99, ErrorMessage = "O preço unitário deve ser maior que zero.")]
        public decimal Preco { get; set; }
    }
}
