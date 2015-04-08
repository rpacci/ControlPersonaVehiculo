using ControlPersonaVehiculo.Dominio;
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
        public ControlPersonaVehiculoContext()
            : base("name = ControlPersonaVehiculo")
        { 
        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<ZonaTrabajo> ZonaTrabajo { get; set; }
        public DbSet<CategoriaLicencia> CategoriaLicencia { get; set; }
        public DbSet<ClaseLicencia> ClaseLicencia { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<PersonaLicencia> PersonaLicencia { get;set; }
    }
}
