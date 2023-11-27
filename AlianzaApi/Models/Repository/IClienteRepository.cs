namespace ApiAlianza.Models.Repository
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetlistClientes();
        Task<Cliente> GetCliente(int id);
        Task DeleteCliente(Cliente cliente);
        Task<Cliente> AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
    }
}
