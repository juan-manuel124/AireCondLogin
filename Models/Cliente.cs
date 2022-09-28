using System;


namespace AiresAcondDomi.Models
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; } = string.Empty;
        public float Longitud { get; set; }
        public float Latitud { get; set; }
        public string Ciudad { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public ProfecionalDesignado Tecnico { get; set; }
        public Repuesto Repuesto { get; set; }
        public Profesional Profesional { get; set; } 
        public Historia Historia { get; set; }
        public System.Collections.Generic.List<Servicios> Servicio { get; set; }
    }
}