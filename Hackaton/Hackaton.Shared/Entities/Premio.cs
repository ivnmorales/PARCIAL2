using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Premio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del premio es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre del premio no puede exceder los 100 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
        public string? Descripcion { get; set; }

        [Required]
        public string Categoria { get; set; } // Innovación, Funcionalidad, Presentación, etc.

        public int HackatonId { get; set; } // Clave foránea para hackatón
        public HackatonEntity Hackaton { get; set; } // Relación con Hackaton
    }
}
