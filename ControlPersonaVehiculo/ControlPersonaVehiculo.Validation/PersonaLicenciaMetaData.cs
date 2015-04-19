using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Validation
{
    public class PersonaLicenciaMetaData
    {       

        public DateTime FechaEmision { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public decimal PuntajeExamen { get; set; }
    }
}
