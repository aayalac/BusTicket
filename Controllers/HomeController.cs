using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusTicket.Models;
using System.Linq;
using System.Diagnostics;

namespace BusTicket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login", "_LoginLayout");
        }

        public ActionResult Ingresar(string email, string contraseña)
        {
            try
            {
                var lst = from d in _context.Usuario
                          where d.Email == email && d.Contraseña == contraseña
                          select d;

                if (lst.Any())
                {
                    Usuario oUsuario = lst.First();                    
                    HttpContext.Session.SetString("Usuario", oUsuario.Email.ToString()); // Ajusta según sea necesario
                    return Content("1");                    
                }
                else
                { 
                    return Content("Usuario Invalido");
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :( " + ex.Message);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
