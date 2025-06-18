using Microsoft.AspNetCore.Mvc;
using crud_cliente.Datos;
using crud_cliente.Models;

namespace crud_cliente.Controllers
{

    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> lista = _db.Cliente;
            return View(lista);
        }
    }
}
