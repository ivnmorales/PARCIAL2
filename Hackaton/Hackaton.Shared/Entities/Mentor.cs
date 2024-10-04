using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Mentor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(100, ErrorMessage = "La especialidad no puede exceder los 100 caracteres")]
        public string? Especialidad { get; set; }

        public int HackatonId { get; set; } // Clave foránea para el hackatón
        public HackatonEntity Hackaton { get; set; } // Relación con Hackaton
    }
}
