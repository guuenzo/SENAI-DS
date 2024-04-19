namespace Projeto_produto_16._05
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public Usuario()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {
            this.Nome = "Gustavo";
            this.Email = "gustavo@email";
            this.Senha = "enzolindo";
            this.DataCadastro = DateTime.Now;
    
        }

        public void Deletar()
        {
           
        }       
    }
}
