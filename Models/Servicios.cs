using System;

namespace AiresAcondDomi.Models
{
    public class Servicios
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public float Valor { get; set; }
        public TipoServi Servicio { get; set; }
    }
}