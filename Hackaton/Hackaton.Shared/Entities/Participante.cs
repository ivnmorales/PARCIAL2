using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Participante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
        public string? Correo { get; set; }

        [MaxLength(20, ErrorMessage = "El teléfono no puede exceder los 20 caracteres")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio")]
        public string Rol { get; set; } // desarrollador, diseñador, líder

        public string? ExperienciaIndividual { get; set; }

        public int EquipoId { get; set; } // Clave foránea para equipo
        public Equipo Equipo { get; set; } // Relación con Equipo
    }
}
