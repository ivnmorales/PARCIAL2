using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Evaluacion
    {
        public int Id { get; set; }

        [Required]
        public int PuntuacionInnovacion { get; set; }

        [Required]
        public int PuntuacionFuncionalidad { get; set; }

        [Required]
        public int PuntuacionPresentacion { get; set; }

        [MaxLength(500, ErrorMessage = "Los comentarios no pueden exceder los 500 caracteres")]
        public string? Comentarios { get; set; }

        public int ProyectoId { get; set; } // Clave foránea para proyecto

        public required Proyecto Proyecto { get; set; }  // Modificador required para C# 11+

        public int MentorId { get; set; } // Clave foránea para mentor
        public Mentor? Mentor { get; set; } // Relación con Mentor
    }
}
