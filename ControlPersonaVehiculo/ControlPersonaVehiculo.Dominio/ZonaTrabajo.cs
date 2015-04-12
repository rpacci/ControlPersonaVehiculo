using ControlPersonaVehiculo.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Dominio
{
    [MetadataType(typeof(ZonaTrabajoMetaData))]
    public class ZonaTrabajo
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
