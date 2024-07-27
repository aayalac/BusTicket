using System;
using System.Collections.Generic;

namespace BusTicket.Models;

public partial class HistorialViajes
{
    public int IdHistorial { get; set; }

    public int? BusId { get; set; }

    public int? ConductorId { get; set; }

    public int? RutaId { get; set; }

    public DateTime? FechaViaje { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? HoraCrea { get; set; }

    public string? UsuCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? HoraMod { get; set; }

    public string? UsuMod { get; set; }
}
