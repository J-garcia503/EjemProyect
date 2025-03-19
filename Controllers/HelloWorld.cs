using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EjemProyect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

        [HttpGet("GetSaludo/{nombre}")]
        public string Get(string nombre) 
        {
            return "Hola " + nombre;
        }

        private struct user
        {
            public string nombre;
            public int id;
            public string edad;
        }

        [HttpGet("GetUsuario/{id}/{nombre}/{edad}")]
        public string Get(string edad, string nombre, int id)
        {
            user usuario = new user();
            usuario.edad = edad;
            usuario.id = id;
            usuario.nombre = nombre;

            string respuesta = JsonConvert.SerializeObject(usuario);
            return respuesta;
        }

        public class UsuarioP
        {
            public int id { get; set;  }
            public string name { get; set; }
        }
         
        [HttpPost("PostUser")] 
        public string Post(UsuarioP usuario) 
        {
            return JsonConvert.SerializeObject(usuario);
        }

        [HttpDelete("DelUsuario")]
        public string Delete(int id_Usuario) 
        {
            return "Se eliminó correctamente el Usuario";
        }
    }
}
