using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusTicket.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MaeListados> MaeListados { get; set; }

    public virtual DbSet<Bus> Bus { get; set; }

    public virtual DbSet<Ciudad> Ciudad { get; set; }

    public virtual DbSet<Conductor> Conductors { get; set; }

    public virtual DbSet<HistorialViajes> HistorialViajes { get; set; }

    public virtual DbSet<Pasaje> Pasajes { get; set; }

    public virtual DbSet<Pasajero> Pasajeros { get; set; }

    public virtual DbSet<Ruta> Ruta { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MaeListados>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mae_listados");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.NomCampo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nom_campo");
            entity.Property(e => e.TipoCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_campo");
            entity.Property(e => e.Value)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Bus>(entity =>
        {
            entity.HasKey(e => e.IdBus).HasName("PK__tbl_bus__D507E43181EF58C8");

            entity.ToTable("tbl_bus");

            entity.Property(e => e.IdBus).HasColumnName("id_bus");
            entity.Property(e => e.ConductorId).HasColumnName("conductor_id");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_ciudad");

            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.IdCiudad)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_ciudad");
            entity.Property(e => e.NombreCiudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_ciudad");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        modelBuilder.Entity<Conductor>(entity =>
        {
            entity.HasKey(e => e.IdConductor).HasName("PK__tbl_cond__33A46A9EA72F35CC");

            entity.ToTable("tbl_conductor");

            entity.Property(e => e.IdConductor).HasColumnName("id_conductor");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.LicenciaConducir)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("licencia_conducir");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_documento");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_documento");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        modelBuilder.Entity<HistorialViajes>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__tbl_hist__76E6C5023CA23533");

            entity.ToTable("tbl_historial_viajes");

            entity.Property(e => e.IdHistorial).HasColumnName("id_historial");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.ConductorId).HasColumnName("conductor_id");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.FechaViaje).HasColumnName("fecha_viaje");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.RutaId).HasColumnName("ruta_id");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        modelBuilder.Entity<Pasaje>(entity =>
        {
            entity.HasKey(e => e.IdPasaje).HasName("PK__tbl_pasa__5D39019B2A941F89");

            entity.ToTable("tbl_pasaje");

            entity.Property(e => e.IdPasaje).HasColumnName("id_pasaje");
            entity.Property(e => e.Asiento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("asiento");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.ConductorId).HasColumnName("conductor_id");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.FechaViaje).HasColumnName("fecha_viaje");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.PasajeroId).HasColumnName("pasajero_id");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.RutaId).HasColumnName("ruta_id");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");
        });

        modelBuilder.Entity<Pasajero>(entity =>
        {
            entity.HasKey(e => e.IdPasajero).HasName("PK__tbl_pasa__6A07178C38CE8CA1");

            entity.ToTable("tbl_pasajero");

            entity.Property(e => e.IdPasajero).HasColumnName("id_pasajero");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_documento");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_documento");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        modelBuilder.Entity<Ruta>(entity =>
        {
            entity.HasKey(e => e.IdRuta).HasName("PK__tbl_ruta__33C9344F38402AAB");

            entity.ToTable("tbl_ruta");

            entity.Property(e => e.IdRuta).HasColumnName("id_ruta");
            entity.Property(e => e.Destino).HasColumnName("destino");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.FechaViaje).HasColumnName("fecha_viaje");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.Origen).HasColumnName("origen");
            entity.Property(e => e.TipoServicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_servicio");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__tbl_usua__4E3E04AD77C16D2C");

            entity.ToTable("tbl_usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaCrea).HasColumnName("fecha_crea");
            entity.Property(e => e.FechaMod).HasColumnName("fecha_mod");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.HoraCrea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_crea");
            entity.Property(e => e.HoraMod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora_mod");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_documento");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perfil");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_documento");
            entity.Property(e => e.UsuCrea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_crea");
            entity.Property(e => e.UsuMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usu_mod");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
