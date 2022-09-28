using System;

namespace AiresAcondDomi.Models
{
    public class SugerenciaMantenimiento
    {
          public int Id { get; set; }
          public DateTime FechaHora { get; set; }
          public string Descripcion { get; set; } = string.Empty;
    }
}