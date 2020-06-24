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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.Registroes = new HashSet<Registro>();
        }

        [ScaffoldColumn(false)]
        public int idevento { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El nombre del evento es requerido"), MaxLength(55)]
        [Display(Name = "Nombre Evento")]
        public string nombre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Fecha de Inicio")]
        public Nullable<System.DateTime> fecha_inicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Fecha de Final")]
        public Nullable<System.DateTime> fecha_final { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El nombre del organizador es requerido"), MaxLength(55)]
        [Display(Name = "Nombre Organizador")]
        public string organizador { get; set; }

        [Display(Name = "Categoria")]
        public Nullable<int> idcategoria { get; set; }

        [Display(Name = "Categoria")]

        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registroes { get; set; }
    }
}