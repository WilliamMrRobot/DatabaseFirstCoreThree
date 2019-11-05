using System;
using System.Collections.Generic;

namespace DatabaseFirstCoreThree.Models
{
    public partial class Vehiculos
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public Guid? Marcaid { get; set; }
        public Guid? Modeloid { get; set; }
        public int? Año { get; set; }

        public virtual Marcas Marca { get; set; }
        public virtual Modelos Modelo { get; set; }
    }
}
