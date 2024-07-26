using System.ComponentModel.DataAnnotations;

namespace BusTicket.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
        public string? tipo_documento { get; set; }
        public string? numero_documento { get; set; }
        public DateTime? fecha_nacimiento { get; set; }
        public string? celular {  get; set; }
        public string? direccion {  get; set; }
        public int? ciudad_id { get; set; }
        public string? perfil { get; set; }
        public string? email { get; set; }
        public string? contraseña { get; set; }
        DateTime fecha_crea { get; set; }
        public string? hora_crea { get; set; }
        public string? usu_crea { get; set; }
        DateTime fecha_mod {  get; set; }
        public string? hora_mod { get; set; }
        public string? usu_mod {  get; set; }
    }
}
