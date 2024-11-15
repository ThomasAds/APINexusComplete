using APINexus.Models;

namespace APINexus.Services
{
    public class AuthService
    {
        private readonly List<Pessoa> _usuarios;

        public AuthService()
        {
            _usuarios = new List<Pessoa>
            {
                new Pessoa { Id = 1, Nome = "Admin", Email = "admin@example.com", Senha = "admin123", IsAdmin = true },
                new Pessoa { Id = 2, Nome = "User", Email = "user@example.com", Senha = "user123", IsAdmin = false }
            };
        }

        public bool Authenticate(string email, string senha)
        {
            var user = _usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            return user != null;
        }

        public bool IsAdmin(string email)
        {
            var user = _usuarios.FirstOrDefault(u => u.Email == email);
            return user != null && user.IsAdmin;
        }
    }
}
