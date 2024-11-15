namespace APINexus.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }
        public Pessoa()
        {
            Nome = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
            IsAdmin = false;
        }
    }
}
