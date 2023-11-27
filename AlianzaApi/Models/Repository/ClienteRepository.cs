using Microsoft.EntityFrameworkCore;

namespace ApiAlianza.Models.Repository
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly AplicationDbContext _context;

        public ClienteRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task DeleteCliente(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cliente>> GetlistClientes()
        {
           return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetCliente(int id)
        {           
            return await _context.Clientes.FindAsync(id);
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            var clienteItem = await _context.Clientes.FirstOrDefaultAsync(x => x.Id == cliente.Id);

            if(clienteItem != null)
            {
                clienteItem.sharedkey = cliente.sharedkey;
                clienteItem.businessid = cliente.businessid;
                clienteItem.email = cliente.email;
                clienteItem.phone = cliente.phone;
                clienteItem.startdate = cliente.startdate;
                clienteItem.enddate = cliente.enddate;

                await _context.SaveChangesAsync();
            }
           
        }
    }
}
