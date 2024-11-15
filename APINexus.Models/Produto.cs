namespace APINexus.APINexus.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
            Nome = string.Empty;
            Descricao = string.Empty;
            Preco = 0.0m;
            Quantidade = 0;
        }
    }
}
