using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaGestionCitasMedicas.Models
{
    public class Cita
    {
        public int Id { get; set; }

        // Unificado: fecha y hora en un solo campo
        [Required(ErrorMessage = "La fecha y hora son obligatorias")]
        [Display(Name = "Fecha y Hora")]
        public DateTime FechaHora { get; set; }

        // Opcional: nombre o descripción de la cita
        [Display(Name = "Descripción de la cita")]
        public string? Nombre { get; set; }   // 👈 ahora es opcional

        // Claves foráneas
        [Required(ErrorMessage = "Debe seleccionar un paciente")]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un médico")]
        public int MedicoId { get; set; }

        // Propiedades de navegación
        public Paciente? Paciente { get; set; }
        public Medico? Medico { get; set; }
    }
}
