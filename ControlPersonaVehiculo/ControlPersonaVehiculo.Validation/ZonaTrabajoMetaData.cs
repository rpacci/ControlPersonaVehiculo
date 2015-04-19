using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Validation
{
    public class ZonaTrabajoMetaData
    {
        [Display(Name = "Descripcion: ")]
        [Required(ErrorMessage = "Debe colocar una descripción")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Descripcion { get; set; }
    }
}
