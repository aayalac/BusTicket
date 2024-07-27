using System;
using System.Collections.Generic;

namespace BusTicket.Models;

public partial class Conductor
{
    public int IdConductor { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Celular { get; set; }

    public string? Direccion { get; set; }

    public int? CiudadId { get; set; }

    public string? LicenciaConducir { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? HoraCrea { get; set; }

    public string? UsuCrea { get; set; }

    public DateTime? FechaMod { get; set; }

    public string? HoraMod { get; set; }

    public string? UsuMod { get; set; }
}
