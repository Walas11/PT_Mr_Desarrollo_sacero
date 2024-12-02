using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PT_Mr_Desarrollo.Infraestructura.DataBase.Entities.UsuarioEntity
{
    [Table("Usuario")]
    public class UsuarioEntity
    {
        [Key]
        public int ID { get; set; }
        public required string NombreCompleto { get; set; }
        public required string TipoDocumento { get; set; }
        public required int Documento { get; set; }
        public required DateTime FechaNacimiento { get; set; }
        public decimal? ValorGanar { get; set; }
        public string? EstadoCivil { get; set; }
    }
}
