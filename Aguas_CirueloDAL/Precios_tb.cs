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
    
    public partial class Precios_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Precios_tb()
        {
            this.Pagos_tb = new HashSet<Pagos_tb>();
        }
    
        public int Id_precio { get; set; }
        public string Pilas_Precio { get; set; }
        public string Tanques_Precio { get; set; }
        public string Cisternas_Precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos_tb> Pagos_tb { get; set; }
    }
}
