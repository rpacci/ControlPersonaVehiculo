using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Dominio
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [NotMapped]
        public string NombreCompleto
        {
            get
            {
                return Apellido + ' ' + Nombre;
            }
        }
        public IEnumerable<PersonaLicencia> PersonaLicencias { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int? VehiculoID { get; set; }
    }
}
