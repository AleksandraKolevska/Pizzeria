//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizzeria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Velicina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Velicina()
        {
            this.PoedinecnaPicas = new HashSet<PoedinecnaPica>();
            this.Narackas = new HashSet<Naracka>();
        }
    
        public int VelicinaID { get; set; }
        public string Golemina { get; set; }
        public Nullable<int> Gramaza { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PoedinecnaPica> PoedinecnaPicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Naracka> Narackas { get; set; }
    }
}
