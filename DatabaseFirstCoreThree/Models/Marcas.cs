using System;
using System.Collections.Generic;

namespace DatabaseFirstCoreThree.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            Modelos = new HashSet<Modelos>();
            Vehiculos = new HashSet<Vehiculos>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Modelos> Modelos { get; set; }
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
