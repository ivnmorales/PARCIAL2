using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Equipo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del equipo es obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre del equipo no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe especificar la cantidad de miembros")]
        public int CantidadMiembros { get; set; }

        public string? ExperienciaGeneral { get; set; }

        public int HackatonId { get; set; } // Clave foránea que vincula al hackatón
        public HackatonEntity Hackaton { get; set; } // Relación con HackatonEntity
    }
}
