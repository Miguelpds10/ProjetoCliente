using ProjetoCliente.Models;

namespace ProjetoCliente.Repositorio
{
    public interface IClienteRepositorio
    {
        //CRUD 
        IEnumerable<Cliente> TodosClientes();
        void Cadastrar(Cliente cliente);

    }

}
