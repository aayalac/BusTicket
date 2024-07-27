using System;
using System.Collections.Generic;

namespace BusTicket.Models;

public partial class Ciudad
{
    public int IdCiudad { get; set; }

    public string? NombreCiudad { get; set; }

    public string? Departamento { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? HoraCrea { get; set; }

    public string? UsuCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? HoraMod { get; set; }

    public string? UsuMod { get; set; }
}
