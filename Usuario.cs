namespace projeto
{
    public class Usuario
    {
        public string Nome { get; set; }

        public int Senha { get; set; }
        public string Email { get; set; }
  
        public Usuario(string _nome,string _email, int _senha )
        {
           this.Nome = _nome;
           this.Email = _email;
           this.Senha = _senha;

        }

        
        
        
    }
}