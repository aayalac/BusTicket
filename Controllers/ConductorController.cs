using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusTicket.Models;

namespace BusTicket.Controllers
{
    public class ConductorController : Controller
    {
        private readonly ApplicationDbContext? _context;

        public ConductorController(ApplicationDbContext? context)
        {
            _context = context;
        }
                
        public IActionResult Conductores()
        {            
            return View();
        }
        
        [HttpGet]
        public IActionResult ConductoresSinBD()
        {
            var mock = GetMockConductores();
            return Ok(mock);
        }

        /// <summary>
        /// Lista simulada de conductores en memoria.
        /// </summary>
        private static List<Conductor> GetMockConductores()
        {
            var ahora = DateTime.UtcNow;
            return new List<Conductor>
            {
                new Conductor
                {
                    IdConductor = 1,
                    Nombres = "Juan",
                    Apellidos = "Pérez",
                    TipoDocumento = "DNI",
                    NumeroDocumento = "12345678",
                    FechaNacimiento = new DateTime(1985, 4, 12),
                    Celular = "+34 600 111 222",
                    Direccion = "Calle Falsa 123",
                    CiudadId = 10,
                    LicenciaConducir = "B12345",
                    FechaCrea = ahora.AddDays(-30),
                    HoraCrea = ahora.AddDays(-30).TimeOfDay.ToString(),
                    UsuCrea = "system",
                    FechaMod = null,
                    HoraMod = null,
                    UsuMod = null
                },
                new Conductor
                {
                    IdConductor = 2,
                    Nombres = "María",
                    Apellidos = "García",
                    TipoDocumento = "Pasaporte",
                    NumeroDocumento = "P987654",
                    FechaNacimiento = new DateTime(1990, 9, 3),
                    Celular = "+34 600 333 444",
                    Direccion = "Avenida Siempre Viva 742",
                    CiudadId = 12,
                    LicenciaConducir = "C98765",
                    FechaCrea = ahora.AddDays(-10),
                    HoraCrea = ahora.AddDays(-10).TimeOfDay.ToString(),
                    UsuCrea = "seed",
                    FechaMod = null,
                    HoraMod = null,
                    UsuMod = null
                },
                new Conductor
                {
                    IdConductor = 3,
                    Nombres = "Carlos",
                    Apellidos = "Ramírez",
                    TipoDocumento = "DNI",
                    NumeroDocumento = "87654321",
                    FechaNacimiento = new DateTime(1978, 1, 20),
                    Celular = "+34 600 555 666",
                    Direccion = "Plaza Mayor 1",
                    CiudadId = 15,
                    LicenciaConducir = "D55555",
                    FechaCrea = ahora.AddDays(-5),
                    HoraCrea = ahora.AddDays(-5).TimeOfDay.ToString(),
                    UsuCrea = "import",
                    FechaMod = ahora.AddDays(-1),
                    HoraMod = ahora.AddDays(-1).TimeOfDay.ToString(),
                    UsuMod = "admin"
                }
            };
        }
    }
}
