namespace ModelMetiador
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }
        public DateTime DataCriacao { get; set; }

        public Pedido(int produtoId, int quantidade, decimal precoTotal)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            PrecoTotal = precoTotal;
            DataCriacao = DateTime.Now;
        }
    }
}
