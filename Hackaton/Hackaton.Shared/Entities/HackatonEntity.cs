using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class HackatonEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "El tema es obligatorio")]
        [MaxLength(200, ErrorMessage = "El tema no puede exceder los 200 caracteres")]
        public string TemaPrincipal { get; set; }

        [MaxLength(100, ErrorMessage = "El nombre del organizador no puede exceder los 100 caracteres")]
        public string Organizador { get; set; }
    }
}
