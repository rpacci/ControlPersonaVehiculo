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
        public int ID { get; set; }
        public string NumeroPlaca { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }        
        public ZonaTrabajo ZonaTrabajo { get; set; }
        public int? ZonaTrabajoID { get; set; }


    }
}
