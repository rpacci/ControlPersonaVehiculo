using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Dominio
{
    public class CategoriaLicencia
    {
        public int ID { get; set; }
        public ClaseLicencia ClaseLicencia { get; set; }
        public int? ClaseLicenciaID { get; set; } 
        public string DescripcionCategoriaLicencia { get; set; }
    }
}
