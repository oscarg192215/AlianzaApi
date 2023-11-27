using ApiAlianza.Models.DTO;
using ApiAlianza.Models.Repository;
using ApiAlianza.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace ApiAlianza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listClientes = await _clienteRepository.GetlistClientes();

                var listClientesDto = _mapper.Map<IEnumerable<ClienteDTO>>(listClientes);

                return Ok(listClientesDto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cliente = await _clienteRepository.GetCliente(id);

                if (cliente == null)
                {
                    return NotFound();
                }

                var clienteDto = _mapper.Map<ClienteDTO>(cliente);

                return Ok(clienteDto);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _clienteRepository.GetCliente(id);

                if (cliente == null)
                {
                    return NotFound();
                }

                await _clienteRepository.DeleteCliente(cliente);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(ClienteDTO clienteDto)
        {
            try
            {
                var cliente = _mapper.Map<Cliente>(clienteDto);

                //var stardate = DateTime.Now;
                //cliente.StartDate = stardate;

                cliente = await _clienteRepository.AddCliente(cliente);

                var clienteItemDto = _mapper.Map<ClienteDTO>(cliente);

                return CreatedAtAction("Get", new { id = clienteItemDto.Id }, clienteItemDto);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ClienteDTO clienteDto)
        {
            try
            {
                var cliente = _mapper.Map<Cliente>(clienteDto);
                cliente.Id = id;

                var clienteItem = await _clienteRepository.GetCliente(id);

                if (clienteItem == null)
                {
                    return NotFound();
                }

                await _clienteRepository.UpdateCliente(cliente);

                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}