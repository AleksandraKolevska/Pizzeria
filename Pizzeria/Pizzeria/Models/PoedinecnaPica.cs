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
    
    public partial class PoedinecnaPica
    {
        public int PoedinecnaPicaID { get; set; }
        public Nullable<int> Cena { get; set; }
        public Nullable<int> OpisID { get; set; }
        public Nullable<int> VelicinaID { get; set; }
        public Nullable<int> KategoriiID { get; set; }
        public Nullable<int> TipID { get; set; }
    
        public virtual Opi Opi { get; set; }
        public virtual Velicina Velicina { get; set; }
        public virtual Tip Tip { get; set; }
    }
}
