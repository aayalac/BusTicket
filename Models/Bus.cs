using System;
using System.Collections.Generic;

namespace BusTicket.Models;

public partial class Bus
{
    public int IdBus { get; set; }

    public int? ConductorId { get; set; }

    public string? Placa { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? HoraCrea { get; set; }

    public string? UsuCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? HoraMod { get; set; }

    public string? UsuMod { get; set; }
}
