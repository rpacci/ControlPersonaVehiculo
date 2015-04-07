using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonaVehiculo.Repository
{
    public class ControlPersonaVehiculoContext : DbContext
    {
        public ControlPersonaVehiculoContext() : base("name = ControlPersonaVehiculo")
        {
 
        }
    }
}
