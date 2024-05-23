namespace ProjetoCliente.Models
{
    public class Cliente
    {
        //Criando encapsulamento do objeto com get e set
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Telefone { get; set; }
        public string? Email { get; set; }

        public List<Cliente>? ListaCliente { get; set; }

        
        
    }
}
