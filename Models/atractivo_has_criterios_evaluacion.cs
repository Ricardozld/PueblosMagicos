//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class atractivo_has_criterios_evaluacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public atractivo_has_criterios_evaluacion()
        {
            this.calificacion = new HashSet<calificacion>();
        }
    
        public int id_Atractivo { get; set; }
        public int id_Criterios_evaluacion { get; set; }
    
        public virtual atractivo atractivo { get; set; }
        public virtual criterios_evaluacion criterios_evaluacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calificacion> calificacion { get; set; }
    }
}
