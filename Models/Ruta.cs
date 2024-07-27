using System;
using System.Collections.Generic;

namespace BusTicket.Models;

public partial class Ruta
{
    public int IdRuta { get; set; }

    public int? Origen { get; set; }

    public int? Destino { get; set; }

    public DateTime? FechaViaje { get; set; }

    public string? TipoServicio { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? HoraCrea { get; set; }

    public string? UsuCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? HoraMod { get; set; }

    public string? UsuMod { get; set; }
}
