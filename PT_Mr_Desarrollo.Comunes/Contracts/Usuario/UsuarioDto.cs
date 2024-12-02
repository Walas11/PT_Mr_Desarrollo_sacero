namespace PT_Mr_Desarrollo.Comunes.Contracts.Usuario
{
    public class UsuarioDto
    {
        public int ID { get; set; }
        public required string NombreCompleto { get; set; }
        public required string TipoDocumento { get; set; }
        public required int Documento { get; set; }
        public required DateTime FechaNacimiento { get; set; }
        public int? ValorGanar { get; set; }
        public string? EstadoCivil { get; set; }
    }
}
