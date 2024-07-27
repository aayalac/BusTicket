using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Construction;
using BusTicket.Models;

namespace BusTicket.Controllers
{
    public class RutaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RutaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Rutas()
        {
            List<Ruta> lst = (from d in _context.Ruta                              
                              orderby d.FechaCrea
                              select new Ruta
                              {
                                  Origen = d.Origen,
                                  Destino = d.Destino,
                                  FechaViaje = d.FechaViaje,
                                  TipoServicio = d.TipoServicio,
                                  FechaCrea = d.FechaCrea,
                                  HoraCrea = d.HoraCrea,
                                  UsuCrea = d.UsuCrea,
                                  FechaMod = d.FechaMod,
                                  HoraMod = d.HoraMod,
                                  UsuMod = d.UsuMod
                              }).ToList();

            return View(lst);
        }


        // GET: RutaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ruta/Create
        public IActionResult CrearRutas()
        {
            return View();
        }

        // POST: Ruta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Origen,Destino,FechaViaje,TipoServicio,FechaCrea,HoraCrea,UsuCrea,FechaMod,HoraMod,UsuMod")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                ruta.FechaCrea = DateTime.Now;
                ruta.HoraCrea = DateTime.Now.ToString("HH:mm:ss");
                ruta.FechaMod = DateTime.Now;
                ruta.HoraMod = DateTime.Now.ToString("HH:mm:ss");
                
                _context.Add(ruta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Rutas));
            }
            return View(ruta);
        }

        // GET: RutaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RutaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RutaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RutaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
