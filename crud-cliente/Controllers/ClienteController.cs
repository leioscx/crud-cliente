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

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Cliente.Add(cliente);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Cliente.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Cliente.Update(cliente);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Cliente.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Cliente cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }
            _db.Cliente.Remove(cliente);
            _db.SaveChanges(); 
            return RedirectToAction(nameof(Index));
        }
    }
}
