namespace upc.edm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
      
        [Key]
        public int Codigo { get; set; }

        public int TipoCliente { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string RazonSocial { get; set; }

        public string DNI { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
        
    }
}
