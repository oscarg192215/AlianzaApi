using AutoMapper;
using ApiAlianza.Models.DTO;

namespace ApiAlianza.Models.Profiles
{
    public class ClienteProfile: Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();
        }
    }
}
