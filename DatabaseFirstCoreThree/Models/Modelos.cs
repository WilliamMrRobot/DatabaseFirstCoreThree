using System;
using System.Collections.Generic;

namespace DatabaseFirstCoreThree.Models
{
    public partial class Modelos
    {
        public Modelos()
        {
            Vehiculos = new HashSet<Vehiculos>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public Guid? MarcaId { get; set; }

        public virtual Marcas Marca { get; set; }
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
