//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aguas_CirueloDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagos_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagos_tb()
        {
            this.Usuarios_tb = new HashSet<Usuarios_tb>();
        }
    
        public int Id_Pago { get; set; }
        public Nullable<System.DateTime> Fecha_Pago { get; set; }
        public Nullable<System.DateTime> FechaProx_Pago { get; set; }
        public string DiasFacturados_Pago { get; set; }
        public string Mora_Pago { get; set; }
        public string Total_Pago { get; set; }
        public Nullable<int> Id_Cliente { get; set; }
        public Nullable<int> Id_Usuario { get; set; }
        public Nullable<int> Id_precio { get; set; }
    
        public virtual Clientes_tb Clientes_tb { get; set; }
        public virtual Precios_tb Precios_tb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios_tb> Usuarios_tb { get; set; }
    }
}