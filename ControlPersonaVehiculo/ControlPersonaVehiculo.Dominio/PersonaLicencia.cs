using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Dominio
{
    public class PersonaLicencia
    {
        public int ID { get; set; }
        public Persona Persona { get; set; }
        public int? PersonaID { get; set; }
        public ClaseLicencia ClaseLicencia { get; set; }
        public int? ClaseLicenciaID { get; set; }
        public CategoriaLicencia CategoriaLicencia { get; set; }
        public int? CategoriaLicenciaID { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public decimal PuntajeExamen { get; set; }
    }
}
