//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUProyecto
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Aporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aporte()
        {
            this.Registroes = new HashSet<Registro>();
        }
    
        public int idaporte { get; set; }
        public string descripcion { get; set; }
        public string tiempo_actividad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

     
        public virtual ICollection<Registro> Registroes { get; set; }
    }
}
