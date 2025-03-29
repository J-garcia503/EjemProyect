using Microsoft.AspNetCore.Mvc;
using EjemProyect.Models;
using EjemProyect.Repositories;

namespace EjemProyect.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository repo;

        public ClienteController(ClienteRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            Cliente cliente= repo.GetCliente();
            return View(cliente);
        }
    }
}
