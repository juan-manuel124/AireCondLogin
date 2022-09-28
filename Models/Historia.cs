using System.Collections.Generic;//esta libreria es para el manejo de la lista

namespace AiresAcondDomi.Models
{
    public class Historia : Persona
    {    
        public string Diagnostico { get; set; } = string.Empty;
        public string Entorno { get; set; } = string.Empty;
        public List<SugerenciaMantenimiento> SugerenciaMantenimiento { get; set; }
    }
}