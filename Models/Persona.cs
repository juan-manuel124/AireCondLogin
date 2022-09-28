namespace AiresAcondDomi.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NumeroTelefono { get; set; } = string.Empty; 
        public TipoClien TipoCliente { get; set; }
        public Historia Historia { get; set; }
        
    }
}