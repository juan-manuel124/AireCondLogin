namespace AiresAcondDomi.Models
{
    public class Repuesto : Persona
    {
        public string Codigo { get; set; } = string.Empty;
        public int NombrePieza { get; set; }
    }
}