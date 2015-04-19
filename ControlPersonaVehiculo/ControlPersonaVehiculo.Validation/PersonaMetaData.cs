using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Validation
{
    public class PersonaMetaData
    {   
        [Display(Name = "Nombre: " )]
        [Required(ErrorMessage = "Debe colocar el nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido: ")]
        [Required(ErrorMessage = "Debe colocar un apellido")]
        public string Apellido { get; set; }
     
    }
}
