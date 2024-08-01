using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Construction;
using BusTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTicket.Controllers
{
    public class RutaController : Controller
    {
        [HttpGet]
        public IActionResult CrearRutasParcial()
        {
            return PartialView("CrearRutas");
        }

        [HttpGet]
        public IActionResult EditarRutasParcial(int id)
        {
            var ruta = _context.Ruta.Find(id);
            if (ruta == null)
            {
                return NotFound();
            }
            return PartialView("EditarRuta", ruta);
        }

        [HttpGet]
        public IActionResult BorrarRutasParcial(int id)
        {
            var ruta = _context.Ruta.Find(id);
            if (ruta == null)
            {
                return NotFound();
            }
            return PartialView("BorrarRuta", ruta);
        }

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
                                  IdRuta = d.IdRuta,
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Origen,Destino,FechaViaje,TipoServicio")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                ruta.FechaCrea = DateTime.Now;
                ruta.HoraCrea = DateTime.Now.ToString("HH:mm:ss");
                ruta.UsuCrea = "CurrentUser";
                ruta.FechaMod = DateTime.Now;
                ruta.HoraMod = DateTime.Now.ToString("HH:mm:ss");
                ruta.UsuMod = "CurrentUser";

                _context.Add(ruta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Rutas));
            }
            return View(ruta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int IdRuta, [Bind("IdRuta,Origen,Destino,FechaViaje,TipoServicio,UsuMod")] Ruta ruta)
        {
            if (IdRuta != ruta.IdRuta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Obtén la ruta existente sin seguimiento
                    var existingRuta = await _context.Ruta.AsNoTracking().FirstOrDefaultAsync(r => r.IdRuta == IdRuta);

                    if (existingRuta == null)
                    {
                        return NotFound();
                    }

                    ruta.FechaMod = DateTime.Now;
                    ruta.HoraMod = DateTime.Now.ToString("HH:mm:ss");
                    ruta.FechaCrea = existingRuta.FechaCrea;
                    ruta.HoraCrea = existingRuta.HoraCrea;
                    ruta.UsuCrea = existingRuta.UsuCrea;
                    ruta.UsuMod = existingRuta.UsuMod;

                    // Marca la entidad como modificada
                    _context.Entry(ruta).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RutaExists(ruta.IdRuta))
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError("", "La ruta ha sido modificada por otro usuario. Por favor, recargue la página e intente nuevamente.");
                        return View(ruta);
                    }
                }
                return RedirectToAction(nameof(Rutas));
            }
            return View(ruta);
        }

        private bool RutaExists(int id)
        {
            return _context.Ruta.Any(e => e.IdRuta == id);
        }             

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdRuta)
        {
            var ruta = await _context.Ruta.FindAsync(IdRuta);
            _context.Ruta.Remove(ruta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Rutas));
        }

    }
}
