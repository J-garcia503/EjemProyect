using AutoMapper;
using EjemProyect.Models;

namespace EjemProyect.Repositories
{
    public class ClienteRepository
    {
        private readonly IMapper mapper;

        public ClienteRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Cliente GetCliente()
        {
            ClienteRequest clienteRequest = new ClienteRequest();

            clienteRequest.IdCliente = 1;
            clienteRequest.Correo = "prueba@gmail.com";
            clienteRequest.Nombre = "Cliente1";

            return mapper.Map<Cliente>(clienteRequest);
        }
    }
}
