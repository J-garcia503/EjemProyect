using AutoMapper;
using EjemProyect.Models;

namespace EjemProyect.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile() 
        {
            CreateMap<ClienteRequest, Cliente>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Nombre))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Correo));
        }
    }
}
