using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Dominio
{
    public class Vehiculo
    {
        [Key]
        public int IDVehiculo { get; set; }
    }
}
