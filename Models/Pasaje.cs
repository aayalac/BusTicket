using System;
using System.Collections.Generic;

namespace BusTicket.Models;

public partial class Pasaje
{
    public int IdPasaje { get; set; }

    public int? UsuarioId { get; set; }

    public int? RutaId { get; set; }

    public int? BusId { get; set; }

    public int? ConductorId { get; set; }

    public int? PasajeroId { get; set; }

    public DateTime? FechaViaje { get; set; }

    public string? Asiento { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? HoraCrea { get; set; }

    public string? UsuCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? HoraMod { get; set; }

    public string? UsuMod { get; set; }
}
